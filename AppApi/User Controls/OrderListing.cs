using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppApi.Api;
using AppApi.Models;
using AppApi.Forms;

namespace AppApi.User_Controls
{
    public partial class OrderListing : UserControl
    {
        private readonly HttpClient _httpClient;
        private BindingSource _bindingSource = new BindingSource();
        private List<Orders> _allOrders = new List<Orders>();
        private bool _sortAscending = true; // Kiem dang sort theo chieu nao
        public OrderListing()
        {
            InitializeComponent();

            // lay http client truc tiep tu api client
            _httpClient = ApiClient.Instance;
        }

        public async void OrderListing_Load(object sender, EventArgs e)
        {
            datagvOrderListing.AutoGenerateColumns = false;
            await load_Order();

        }

        public async Task load_Order(string keyword = "")
        {
            // tat add them row vao grid
            datagvOrderListing.AllowUserToAddRows = false;

            try
            {
                var orders = await _httpClient.GetFromJsonAsync<List<Orders>>("api/orders");


                // lưu tất cả các order để lọc và search
                _allOrders = orders;

                _bindingSource.DataSource = _allOrders;
                datagvOrderListing.DataSource = _bindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi khi tai san pham" + ex.Message);
            }

        }

        private async void datagvOrderListing_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && datagvOrderListing.Columns[e.ColumnIndex].Name == "Status")
            {
                var orderItem = (Orders)datagvOrderListing.Rows[e.RowIndex].DataBoundItem;

                // lay gia tri moi cua status
                string newStatus = datagvOrderListing.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();
                try
                {
                    // goi api de put status
                    HttpResponseMessage respone = null;
                    switch (newStatus)
                    {
                        case "Completed":
                            respone = await _httpClient.PutAsync($"api/orders/{orderItem.TransactionId}/complete", null);
                            break;
                        case "Canceled":
                            respone = await _httpClient.PutAsync($"api/orders/{orderItem.TransactionId}/cancel", null);
                            break;
                        case "Processing":
                            respone = await _httpClient.PutAsync($"api/orders/{orderItem.TransactionId}/process", null);
                            break;
                        case "Pending":
                            return;
                    }
                    if (respone != null && respone.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Cap nhat status thanh cong");
                    }
                    else if (respone == null)
                    {
                        MessageBox.Show("Cap nhat status that bai");
                    }
                }
                catch (Exception ex)
                {
                    {
                        MessageBox.Show("Loi khi thay doi gia tri" + ex.Message);
                    }
                }
            }
        }

        private void datagvOrderListing_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && datagvOrderListing.Columns[e.ColumnIndex].Name == "OrderDetail")
            {
                var order = (Orders)datagvOrderListing.Rows[e.RowIndex].DataBoundItem;

                // mo form
                OrderDetails form = new OrderDetails(order);
                form.ShowDialog();
            }
        }

        // searching
        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            string keyword = searchBox.Text.Trim().ToLower();

            var filtered = _allOrders
                .Where(o => o.TransactionId.ToString().Contains(keyword)
                         || o.CustomerName.ToLower().Contains(keyword)
                         || o.OrderDate.ToString("dd/MM/yyyy").Contains(keyword))
                .ToList();

            _bindingSource.DataSource = filtered;
        }

        // sorting 
        private void datagvOrderListing_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            string columnName = datagvOrderListing.Columns[e.ColumnIndex].DataPropertyName;

            if (_sortAscending)
            {
                _allOrders = _allOrders.OrderBy(o => GetPropertyValue(o, columnName)).ToList();
            }
            else
            {
                _allOrders = _allOrders.OrderByDescending(o => GetPropertyValue(o, columnName)).ToList();
            }

            _sortAscending = !_sortAscending;

            _bindingSource.DataSource = _allOrders;
        }


        // hàm hỗ trợ lấy giá trị property động
        private object GetPropertyValue(Orders order, string propertyName)
        {
            var prop = typeof(Orders).GetProperty(propertyName);
            return prop != null ? prop.GetValue(order, null) : null;
        }

      


    }
}
