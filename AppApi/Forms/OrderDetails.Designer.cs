namespace AppApi.Forms
{
    partial class OrderDetails
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dtgvListOfItems = new DataGridView();
            btnSave = new Button();
            btnCancel = new Button();
            lbStatus = new Label();
            lbTotalAmount = new Label();
            lbOrderDate = new Label();
            lbCustomer = new Label();
            lbOderId = new Label();
            ItemName = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgvListOfItems).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 0;
            label1.Text = "Order ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 80);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 1;
            label2.Text = "Customer Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 132);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 2;
            label3.Text = "Order Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 284);
            label4.Name = "label4";
            label4.Size = new Size(96, 20);
            label4.TabIndex = 5;
            label4.Text = "List of items :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 232);
            label5.Name = "label5";
            label5.Size = new Size(91, 20);
            label5.TabIndex = 4;
            label5.Text = "Order Status";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 179);
            label6.Name = "label6";
            label6.Size = new Size(99, 20);
            label6.TabIndex = 3;
            label6.Text = "Total Amount";
            // 
            // dtgvListOfItems
            // 
            dtgvListOfItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvListOfItems.Columns.AddRange(new DataGridViewColumn[] { ItemName, Quantity, Price });
            dtgvListOfItems.Location = new Point(61, 320);
            dtgvListOfItems.Name = "dtgvListOfItems";
            dtgvListOfItems.RowHeadersWidth = 51;
            dtgvListOfItems.Size = new Size(544, 188);
            dtgvListOfItems.TabIndex = 11;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(101, 538);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(193, 29);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(394, 538);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(193, 29);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.Location = new Point(244, 232);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(50, 20);
            lbStatus.TabIndex = 10;
            lbStatus.Text = "label8";
            // 
            // lbTotalAmount
            // 
            lbTotalAmount.AutoSize = true;
            lbTotalAmount.Location = new Point(244, 179);
            lbTotalAmount.Name = "lbTotalAmount";
            lbTotalAmount.Size = new Size(50, 20);
            lbTotalAmount.TabIndex = 9;
            lbTotalAmount.Text = "label9";
            // 
            // lbOrderDate
            // 
            lbOrderDate.AutoSize = true;
            lbOrderDate.Location = new Point(244, 132);
            lbOrderDate.Name = "lbOrderDate";
            lbOrderDate.Size = new Size(58, 20);
            lbOrderDate.TabIndex = 8;
            lbOrderDate.Text = "label10";
            // 
            // lbCustomer
            // 
            lbCustomer.AutoSize = true;
            lbCustomer.Location = new Point(244, 80);
            lbCustomer.Name = "lbCustomer";
            lbCustomer.Size = new Size(58, 20);
            lbCustomer.TabIndex = 7;
            lbCustomer.Text = "label11";
            // 
            // lbOderId
            // 
            lbOderId.AutoSize = true;
            lbOderId.Location = new Point(244, 27);
            lbOderId.Name = "lbOderId";
            lbOderId.Size = new Size(58, 20);
            lbOderId.TabIndex = 6;
            lbOderId.Text = "label12";
            // 
            // ItemName
            // 
            ItemName.DataPropertyName = "ItemName";
            ItemName.HeaderText = "Items";
            ItemName.MinimumWidth = 6;
            ItemName.Name = "ItemName";
            ItemName.Width = 150;
            // 
            // Quantity
            // 
            Quantity.DataPropertyName = "Quantity";
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.Width = 190;
            // 
            // Price
            // 
            Price.DataPropertyName = "Price";
            Price.HeaderText = "Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.Width = 150;
            // 
            // OrderDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(689, 591);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(dtgvListOfItems);
            Controls.Add(lbStatus);
            Controls.Add(lbTotalAmount);
            Controls.Add(lbOrderDate);
            Controls.Add(lbCustomer);
            Controls.Add(lbOderId);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "OrderDetails";
            Text = "OrderDetails";
            ((System.ComponentModel.ISupportInitialize)dtgvListOfItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private DataGridView dtgvListOfItems;
        private Button btnSave;
        private Button btnCancel;
        private Label lbStatus;
        private Label lbTotalAmount;
        private Label lbOrderDate;
        private Label lbCustomer;
        private Label lbOderId;
        private DataGridViewTextBoxColumn ItemName;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Price;
    }
}