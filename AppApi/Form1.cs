using AppApi.User_Controls;

namespace AppApi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // khoi tao user control
            var productListing = new ProductListing();
            productListing1.Visible = false;
            orderListing1.Visible = false;
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            productListing1.Visible = true;
            orderListing1.Visible=false;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            productListing1.Visible = false;
            orderListing1.Visible = true;
        }
    }
}
