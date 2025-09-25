namespace AppApi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pnLeft = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnSetting = new Button();
            btnReport = new Button();
            btnCustomer = new Button();
            btnProduct = new Button();
            btnOrder = new Button();
            btnDashboard = new Button();
            panel3 = new Panel();
            panel2 = new Panel();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panelControl = new Panel();
            orderListing1 = new AppApi.User_Controls.OrderListing();
            productListing1 = new AppApi.User_Controls.ProductListing();
            pnLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelControl.SuspendLayout();
            SuspendLayout();
            // 
            // pnLeft
            // 
            pnLeft.Controls.Add(label1);
            pnLeft.Controls.Add(pictureBox1);
            pnLeft.Controls.Add(btnSetting);
            pnLeft.Controls.Add(btnReport);
            pnLeft.Controls.Add(btnCustomer);
            pnLeft.Controls.Add(btnProduct);
            pnLeft.Controls.Add(btnOrder);
            pnLeft.Controls.Add(btnDashboard);
            pnLeft.Controls.Add(panel3);
            pnLeft.Controls.Add(panel2);
            pnLeft.Dock = DockStyle.Left;
            pnLeft.Location = new Point(0, 0);
            pnLeft.Margin = new Padding(4);
            pnLeft.Name = "pnLeft";
            pnLeft.Size = new Size(234, 905);
            pnLeft.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label1.Location = new Point(54, 155);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(122, 65);
            label1.TabIndex = 1;
            label1.Text = "Staff";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(40, 15);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(156, 126);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnSetting
            // 
            btnSetting.Location = new Point(4, 608);
            btnSetting.Margin = new Padding(4);
            btnSetting.Name = "btnSetting";
            btnSetting.Size = new Size(230, 69);
            btnSetting.TabIndex = 6;
            btnSetting.Text = "SETTING";
            btnSetting.UseVisualStyleBackColor = true;
            // 
            // btnReport
            // 
            btnReport.Location = new Point(4, 531);
            btnReport.Margin = new Padding(4);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(230, 69);
            btnReport.TabIndex = 5;
            btnReport.Text = "REPORTS";
            btnReport.UseVisualStyleBackColor = true;
            // 
            // btnCustomer
            // 
            btnCustomer.Location = new Point(4, 455);
            btnCustomer.Margin = new Padding(4);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(230, 69);
            btnCustomer.TabIndex = 4;
            btnCustomer.Text = "CUSTOMERS";
            btnCustomer.UseVisualStyleBackColor = true;
            // 
            // btnProduct
            // 
            btnProduct.Location = new Point(4, 379);
            btnProduct.Margin = new Padding(4);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(230, 69);
            btnProduct.TabIndex = 3;
            btnProduct.Text = "PRODUCT";
            btnProduct.UseVisualStyleBackColor = true;
            btnProduct.Click += btnProduct_Click;
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(4, 302);
            btnOrder.Margin = new Padding(4);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(230, 69);
            btnOrder.TabIndex = 2;
            btnOrder.Text = "ORDER";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(4, 226);
            btnDashboard.Margin = new Padding(4);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(230, 69);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "DASHBOARD";
            btnDashboard.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Location = new Point(241, 4);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(981, 871);
            panel3.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Location = new Point(241, 4);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(195, 62);
            panel2.TabIndex = 1;
            // 
            // panelControl
            // 
            panelControl.Controls.Add(orderListing1);
            panelControl.Controls.Add(productListing1);
            panelControl.Dock = DockStyle.Fill;
            panelControl.Location = new Point(234, 0);
            panelControl.Margin = new Padding(4);
            panelControl.Name = "panelControl";
            panelControl.Size = new Size(1257, 905);
            panelControl.TabIndex = 1;
            // 
            // orderListing1
            // 
            orderListing1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            orderListing1.Location = new Point(0, 0);
            orderListing1.Margin = new Padding(5);
            orderListing1.Name = "orderListing1";
            orderListing1.Size = new Size(1258, 905);
            orderListing1.TabIndex = 1;
            // 
            // productListing1
            // 
            productListing1.Location = new Point(0, 0);
            productListing1.Margin = new Padding(5);
            productListing1.Name = "productListing1";
            productListing1.Size = new Size(1258, 901);
            productListing1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1491, 905);
            Controls.Add(panelControl);
            Controls.Add(pnLeft);
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            pnLeft.ResumeLayout(false);
            pnLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnLeft;
        private Panel panel3;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button btnSetting;
        private Button btnReport;
        private Button btnCustomer;
        private Button btnProduct;
        private Button btnOrder;
        private Button btnDashboard;
        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panelControl;
        private User_Controls.ProductListing productListing1;
        private User_Controls.OrderListing orderListing1;
    }
}
