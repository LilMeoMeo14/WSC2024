using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppApi.Api;
using AppApi.Models;

namespace AppApi.Forms
{
    public partial class OrderDetails : Form
    {
        private Orders _order;
        private OrderItems _orderItem;
        public Orders Order => _order;
        public OrderItems OrderItem => _orderItem;
        private readonly HttpClient _httpClient;
        
        public OrderDetails(Orders order)
        {
            InitializeComponent();
            _order = order;
            _httpClient = ApiClient.Instance;
            LoadOrderItems();
        }
        private async Task LoadOrderItems()
        {
            if (Order != null)
            {
                lbOderId.Text = Order.TransactionId.ToString();
                lbCustomer.Text = Order.CustomerName.ToString();
                lbOrderDate.Text = Order.OrderDate.ToString();
                lbTotalAmount.Text = Order.TotalAmount.ToString();
                lbStatus.Text = Order.Status.ToString();

                // grid view 
                dtgvListOfItems.AutoGenerateColumns = false;

                var orderItems = await _httpClient.GetFromJsonAsync<List<OrderItems>>($"api/OrderItems/order/{Order.TransactionId}");
                dtgvListOfItems.DataSource = orderItems;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.Cancel;
            this.Close();
        
        }
    }
}
