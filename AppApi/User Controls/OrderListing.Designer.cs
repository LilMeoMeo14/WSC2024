namespace AppApi.User_Controls
{
    partial class OrderListing
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            datagvOrderListing = new DataGridView();
            OrderID = new DataGridViewTextBoxColumn();
            CustomerName = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            TotalAmount = new DataGridViewTextBoxColumn();
            Status = new DataGridViewComboBoxColumn();
            OrderDetail = new DataGridViewLinkColumn();
            btnOrderNewProduct = new Button();
            searchBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)datagvOrderListing).BeginInit();
            SuspendLayout();
            // 
            // datagvOrderListing
            // 
            datagvOrderListing.AllowUserToAddRows = false;
            datagvOrderListing.AllowUserToDeleteRows = false;
            datagvOrderListing.AllowUserToResizeColumns = false;
            datagvOrderListing.AllowUserToResizeRows = false;
            datagvOrderListing.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagvOrderListing.Columns.AddRange(new DataGridViewColumn[] { OrderID, CustomerName, Date, TotalAmount, Status, OrderDetail });
            datagvOrderListing.Location = new Point(20, 156);
            datagvOrderListing.Margin = new Padding(4);
            datagvOrderListing.Name = "datagvOrderListing";
            datagvOrderListing.RowHeadersVisible = false;
            datagvOrderListing.RowHeadersWidth = 51;
            datagvOrderListing.Size = new Size(1220, 701);
            datagvOrderListing.TabIndex = 5;
            datagvOrderListing.CellContentClick += datagvOrderListing_CellContentClick;
            datagvOrderListing.CellValueChanged += datagvOrderListing_CellValueChanged;
            datagvOrderListing.ColumnHeaderMouseClick += datagvOrderListing_ColumnHeaderMouseClick;
            // 
            // OrderID
            // 
            OrderID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            OrderID.DataPropertyName = "TransactionId";
            OrderID.HeaderText = "Order ID";
            OrderID.MinimumWidth = 6;
            OrderID.Name = "OrderID";
            // 
            // CustomerName
            // 
            CustomerName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CustomerName.DataPropertyName = "CustomerName";
            CustomerName.HeaderText = "Customer Name";
            CustomerName.MinimumWidth = 6;
            CustomerName.Name = "CustomerName";
            // 
            // Date
            // 
            Date.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Date.DataPropertyName = "OrderDate";
            Date.HeaderText = "Date";
            Date.MinimumWidth = 6;
            Date.Name = "Date";
            // 
            // TotalAmount
            // 
            TotalAmount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TotalAmount.DataPropertyName = "TotalAmount";
            TotalAmount.HeaderText = "Total Amount";
            TotalAmount.MinimumWidth = 6;
            TotalAmount.Name = "TotalAmount";
            // 
            // Status
            // 
            Status.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Status";
            Status.Items.AddRange(new object[] { "Pending", "Processing", "Completed", "Canceled" });
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.Resizable = DataGridViewTriState.True;
            Status.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // OrderDetail
            // 
            OrderDetail.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            OrderDetail.HeaderText = "Order Detail";
            OrderDetail.MinimumWidth = 6;
            OrderDetail.Name = "OrderDetail";
            OrderDetail.SortMode = DataGridViewColumnSortMode.Automatic;
            OrderDetail.Text = "Detail View";
            OrderDetail.UseColumnTextForLinkValue = true;
            // 
            // btnOrderNewProduct
            // 
            btnOrderNewProduct.Location = new Point(921, 49);
            btnOrderNewProduct.Margin = new Padding(4);
            btnOrderNewProduct.Name = "btnOrderNewProduct";
            btnOrderNewProduct.Size = new Size(302, 56);
            btnOrderNewProduct.TabIndex = 4;
            btnOrderNewProduct.Text = "Add New Product";
            btnOrderNewProduct.UseVisualStyleBackColor = true;
            // 
            // searchBox
            // 
            searchBox.Location = new Point(56, 60);
            searchBox.Margin = new Padding(4);
            searchBox.Name = "searchBox";
            searchBox.PlaceholderText = "Search on Id / CustomerName / Date";
            searchBox.Size = new Size(423, 31);
            searchBox.TabIndex = 3;
            searchBox.TextChanged += searchBox_TextChanged;
            // 
            // OrderListing
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(datagvOrderListing);
            Controls.Add(btnOrderNewProduct);
            Controls.Add(searchBox);
            Margin = new Padding(4);
            Name = "OrderListing";
            Size = new Size(1258, 905);
            Load += OrderListing_Load;
            ((System.ComponentModel.ISupportInitialize)datagvOrderListing).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private DataGridView datagvOrderListing;
        private Button btnOrderNewProduct;
        private TextBox searchBox;
        private DataGridViewTextBoxColumn OrderID;
        private DataGridViewTextBoxColumn CustomerName;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn TotalAmount;
        private DataGridViewComboBoxColumn Status;
        private DataGridViewLinkColumn OrderDetail;
    }
}
