using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppApi.Models;

namespace AppApi.Forms
{
    public partial class AddEditProductForm : Form
    {
        private Products _product;
        private bool _isEdit; // kiem tra coi la trang thai chinh sua hay trang thai them moi

        //expose public property để lấy object bên ngoài//dung de code ben ngoai co the lay thong tin cua form addedit
        public Products Product => _product;
        public AddEditProductForm(Products products = null)
        {
            InitializeComponent();

            // kiem tra tao moi 1 san pham

            if (products == null)
            {
                _product = new Products();

                // set trang thai la tao moi
                _isEdit = false;
            }
            else
            {
                _product = products;
                _isEdit = true;
                loadProductData();
            }

        }
        private void loadProductData()
        {
            if (_product != null)
            {
                cbboxCate.SelectedItem = _product.Category;
                txtboxProductname.Text = _product.ProductName;
                nudPrice.Value = _product.Price;
                nudCost.Value = _product.Cost;
                dtpickerIntroDate.Value = _product.IntroducedDate;
                cbactive.Checked = _product.Active;
                cbseasonal.Checked = _product.Seasonal;
                rtboxDescription.Text = _product.Description ?? "";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtboxProductname.Text))
            {
                MessageBox.Show("Vui long nhap ten san pham");
                return;
            }
            if (cbboxCate.SelectedItem == null)
            {
                MessageBox.Show("Vui long lua chon loai san pham");
                return;
            }

            _product.ProductName = txtboxProductname.Text;
            _product.Category = cbboxCate.SelectedItem?.ToString();
            _product.Price = nudPrice.Value;
            _product.Cost = nudCost.Value;
            _product.IntroducedDate = dtpickerIntroDate.Value;
            _product.Active = cbactive.Checked;
            _product.Seasonal = cbseasonal.Checked;
            _product.Description = rtboxDescription.Text;

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
