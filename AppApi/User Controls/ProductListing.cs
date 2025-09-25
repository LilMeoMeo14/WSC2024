using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppApi.Api;
using AppApi.Forms;
using AppApi.Models;

namespace AppApi.User_Controls
{
    public partial class ProductListing : UserControl
    {
        private readonly HttpClient _httpClient;
        public ProductListing()
        {
            InitializeComponent();
            _httpClient = ApiClient.Instance; // lay http client tu api client
        }


        private async void ProductListing_Load(object sender, EventArgs e)
        {
            datagvProductListing.AutoGenerateColumns = false;
            await LoadProducts();
        }


        // lay du lieu tu san pham
        private async Task LoadProducts(string keyword = "")
        {
            // tat cho phep user add them rows
            datagvProductListing.AllowUserToAddRows = false;
            try
            {
                var products = await _httpClient.GetFromJsonAsync<List<Products>>("api/Products");

                datagvProductListing.DataSource = products;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi khi tai san pham" + ex.Message);
            }
        }

        private async void datagvProductListing_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && datagvProductListing.Columns[e.ColumnIndex].Name == "Active")
            {
                var product = (Products)datagvProductListing.Rows[e.RowIndex].DataBoundItem;

                try
                {
                    // goi api de put san pham
                    var respone = await _httpClient.PutAsJsonAsync($"api/products/{product.ProductId}", product);

                    if (!respone.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Cap nhat that bai: " + respone.ReasonPhrase);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Loi khi cap nhat: " + ex.Message);
                }

            }
        }

        private async void btnNewProduct_Click_1(object sender, EventArgs e)
        {
            // goi toi form add/edit khi an vao btn
            AddEditProductForm form = new AddEditProductForm();


            if (form.ShowDialog() == DialogResult.OK)
            {
                // lay san pham tu form
                var newProducts = form.Product;
                try
                {
                    var respone = await _httpClient.PostAsJsonAsync("api/products", newProducts);
                    if (respone.IsSuccessStatusCode)
                    {
                        MessageBox.Show("them san pham thanh cong! ");
                        await LoadProducts();
                    }
                    else
                    {
                        var content = await respone.Content.ReadAsStringAsync();
                        MessageBox.Show($"Them san pham that bai! {respone.StatusCode}\n{content}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Loi: " + ex.Message);
                }
            }
        }


        // Update thông tin của product
        private async void datagvProductListing_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // update product
            if (e.RowIndex >= 0 && datagvProductListing.Columns[e.ColumnIndex].Name == "Action")
            {
                // lay thong tin ve product da chon
                var product = (Products)datagvProductListing.Rows[e.RowIndex].DataBoundItem;

                // mo form thong tin chi tiet
                AddEditProductForm form = new AddEditProductForm(product);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    // goi api de update
                    var response = await _httpClient.PutAsJsonAsync($"api/products/{product.ProductId}", product);
                    if (response.IsSuccessStatusCode)
                    {
                        await LoadProducts();
                    }
                    else
                    {
                        MessageBox.Show("Update that bai", response.ReasonPhrase);
                    }

                }
            }

            // delete product

            if (e.RowIndex >= 0 && datagvProductListing.Columns[e.ColumnIndex].Name == "Delete")
            {
                // lay thong tin product da chon
                var product = (Products)datagvProductListing.Rows[e.RowIndex].DataBoundItem;

                //thong bao comfirm voi nguoi dung
                var comfirmMessage = MessageBox.Show("Ban co chac chan muon xoa san pham nay chu ?",
                    "xac nhan xoa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (comfirmMessage == DialogResult.Yes)
                {
                    var response = await _httpClient.DeleteAsync($"api/products/{product.ProductId}");
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Xoa san pham thanh cong");
                        await LoadProducts();
                    }
                    else
                    {
                        var content = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Xóa thất bại!\n{content}");
                    }
                }
            }
        }


    }
}
