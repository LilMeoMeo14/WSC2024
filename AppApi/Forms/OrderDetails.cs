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
    public partial class OrderDetails : Form
    {
        private Orders _order;
        public Orders Order => _order;
        public OrderDetails(Orders order)
        {
            InitializeComponent();
            _order = order;
            LoadOrderItems();

        }
        private void LoadOrderItems()
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
                dtgvListOfItems.DataSource = Order.OrderItems;
                Items.DataPropertyName = "ItemName";
                Quantity.DataPropertyName = "Quantity";
                Price.DataPropertyName = "Price";
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
