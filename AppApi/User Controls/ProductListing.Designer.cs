namespace AppApi.User_Controls
{
    partial class ProductListing
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
            searchBox = new TextBox();
            btnNewProduct = new Button();
            datagvProductListing = new DataGridView();
            Active = new DataGridViewCheckBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Cost = new DataGridViewTextBoxColumn();
            Action = new DataGridViewLinkColumn();
            Delete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)datagvProductListing).BeginInit();
            SuspendLayout();
            // 
            // searchBox
            // 
            searchBox.Location = new Point(44, 52);
            searchBox.Margin = new Padding(4);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(423, 31);
            searchBox.TabIndex = 0;
            // 
            // btnNewProduct
            // 
            btnNewProduct.Location = new Point(909, 41);
            btnNewProduct.Margin = new Padding(4);
            btnNewProduct.Name = "btnNewProduct";
            btnNewProduct.Size = new Size(302, 56);
            btnNewProduct.TabIndex = 1;
            btnNewProduct.Text = "Add New Product";
            btnNewProduct.UseVisualStyleBackColor = true;
            btnNewProduct.Click += btnNewProduct_Click_1;
            // 
            // datagvProductListing
            // 
            datagvProductListing.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagvProductListing.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagvProductListing.Columns.AddRange(new DataGridViewColumn[] { Active, ProductName, Category, Price, Cost, Action, Delete });
            datagvProductListing.Location = new Point(21, 149);
            datagvProductListing.Margin = new Padding(4);
            datagvProductListing.Name = "datagvProductListing";
            datagvProductListing.RowHeadersVisible = false;
            datagvProductListing.RowHeadersWidth = 51;
            datagvProductListing.Size = new Size(1171, 701);
            datagvProductListing.TabIndex = 2;
            datagvProductListing.CellContentClick += datagvProductListing_CellContentClick;
            datagvProductListing.CellValueChanged += datagvProductListing_CellValueChanged;
            // 
            // Active
            // 
            Active.DataPropertyName = "Active";
            Active.HeaderText = "Active";
            Active.MinimumWidth = 6;
            Active.Name = "Active";
            Active.Resizable = DataGridViewTriState.True;
            Active.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // ProductName
            // 
            ProductName.DataPropertyName = "ProductName";
            ProductName.HeaderText = "ProductName";
            ProductName.MinimumWidth = 6;
            ProductName.Name = "ProductName";
            // 
            // Category
            // 
            Category.DataPropertyName = "Category";
            Category.HeaderText = "Category";
            Category.MinimumWidth = 6;
            Category.Name = "Category";
            // 
            // Price
            // 
            Price.DataPropertyName = "Price";
            Price.HeaderText = "Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            // 
            // Cost
            // 
            Cost.DataPropertyName = "Cost";
            Cost.HeaderText = "Cost";
            Cost.MinimumWidth = 6;
            Cost.Name = "Cost";
            // 
            // Action
            // 
            Action.HeaderText = "Action";
            Action.MinimumWidth = 6;
            Action.Name = "Action";
            Action.Text = "Edit/Delete";
            Action.UseColumnTextForLinkValue = true;
            // 
            // Delete
            // 
            Delete.HeaderText = "Delete";
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.Text = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            // 
            // ProductListing
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(datagvProductListing);
            Controls.Add(btnNewProduct);
            Controls.Add(searchBox);
            Margin = new Padding(4);
            Name = "ProductListing";
            Size = new Size(1258, 905);
            Load += ProductListing_Load;
            ((System.ComponentModel.ISupportInitialize)datagvProductListing).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox searchBox;
        private Button btnNewProduct;
        private DataGridView datagvProductListing;
        private DataGridViewCheckBoxColumn Active;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Cost;
        private DataGridViewLinkColumn Action;
        private DataGridViewButtonColumn Delete;
    }
}
