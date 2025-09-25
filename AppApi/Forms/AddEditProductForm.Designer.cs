namespace AppApi.Forms
{
    partial class AddEditProductForm
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
            cbboxCate = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtboxProductname = new TextBox();
            nudPrice = new NumericUpDown();
            nudCost = new NumericUpDown();
            dtpickerIntroDate = new DateTimePicker();
            cbactive = new CheckBox();
            cbseasonal = new CheckBox();
            rtboxDescription = new RichTextBox();
            btnSave = new Button();
            btnCancel = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCost).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 76);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(84, 25);
            label1.TabIndex = 0;
            label1.Text = "Category";
            // 
            // cbboxCate
            // 
            cbboxCate.DisplayMember = "Tarte";
            cbboxCate.FormattingEnabled = true;
            cbboxCate.Items.AddRange(new object[] { "Tarte", "Bread", "Pastry", "Viennoiserie" });
            cbboxCate.Location = new Point(296, 76);
            cbboxCate.Margin = new Padding(4);
            cbboxCate.Name = "cbboxCate";
            cbboxCate.Size = new Size(468, 33);
            cbboxCate.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 151);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(126, 25);
            label2.TabIndex = 2;
            label2.Text = "Product Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 228);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(49, 25);
            label3.TabIndex = 3;
            label3.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 502);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(102, 25);
            label4.TabIndex = 6;
            label4.Text = "Description";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 369);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(127, 25);
            label5.TabIndex = 5;
            label5.Text = "Introduct Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 294);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(48, 25);
            label6.TabIndex = 4;
            label6.Text = "Cost";
            // 
            // txtboxProductname
            // 
            txtboxProductname.Location = new Point(296, 142);
            txtboxProductname.Margin = new Padding(4);
            txtboxProductname.Name = "txtboxProductname";
            txtboxProductname.Size = new Size(468, 31);
            txtboxProductname.TabIndex = 7;
            // 
            // nudPrice
            // 
            nudPrice.Location = new Point(296, 219);
            nudPrice.Margin = new Padding(4);
            nudPrice.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(469, 31);
            nudPrice.TabIndex = 8;
            // 
            // nudCost
            // 
            nudCost.Location = new Point(296, 285);
            nudCost.Margin = new Padding(4);
            nudCost.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudCost.Name = "nudCost";
            nudCost.Size = new Size(469, 31);
            nudCost.TabIndex = 9;
            // 
            // dtpickerIntroDate
            // 
            dtpickerIntroDate.Format = DateTimePickerFormat.Short;
            dtpickerIntroDate.Location = new Point(296, 360);
            dtpickerIntroDate.Margin = new Padding(4);
            dtpickerIntroDate.Name = "dtpickerIntroDate";
            dtpickerIntroDate.Size = new Size(468, 31);
            dtpickerIntroDate.TabIndex = 10;
            // 
            // cbactive
            // 
            cbactive.AutoSize = true;
            cbactive.Location = new Point(15, 435);
            cbactive.Margin = new Padding(4);
            cbactive.Name = "cbactive";
            cbactive.Size = new Size(86, 29);
            cbactive.TabIndex = 11;
            cbactive.Text = "Active";
            cbactive.UseVisualStyleBackColor = true;
            // 
            // cbseasonal
            // 
            cbseasonal.AutoSize = true;
            cbseasonal.Location = new Point(296, 435);
            cbseasonal.Margin = new Padding(4);
            cbseasonal.Name = "cbseasonal";
            cbseasonal.Size = new Size(108, 29);
            cbseasonal.TabIndex = 12;
            cbseasonal.Text = "Seasonal";
            cbseasonal.UseVisualStyleBackColor = true;
            // 
            // rtboxDescription
            // 
            rtboxDescription.Location = new Point(296, 499);
            rtboxDescription.Margin = new Padding(4);
            rtboxDescription.Name = "rtboxDescription";
            rtboxDescription.Size = new Size(468, 149);
            rtboxDescription.TabIndex = 13;
            rtboxDescription.Text = "";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(84, 676);
            btnSave.Margin = new Padding(4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(272, 36);
            btnSave.TabIndex = 14;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(492, 676);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(272, 36);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(820, 704);
            panel1.TabIndex = 16;
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 42);
            panel2.Name = "panel2";
            panel2.Size = new Size(105, 44);
            panel2.TabIndex = 0;
            // 
            // AddEditProductForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 739);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(rtboxDescription);
            Controls.Add(cbseasonal);
            Controls.Add(cbactive);
            Controls.Add(dtpickerIntroDate);
            Controls.Add(nudCost);
            Controls.Add(nudPrice);
            Controls.Add(txtboxProductname);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cbboxCate);
            Controls.Add(label1);
            Controls.Add(panel1);
            Margin = new Padding(4);
            Name = "AddEditProductForm";
            Text = "AddEditProductForm";
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCost).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbboxCate;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtboxProductname;
        private NumericUpDown nudPrice;
        private NumericUpDown nudCost;
        private DateTimePicker dtpickerIntroDate;
        private CheckBox cbactive;
        private CheckBox cbseasonal;
        private RichTextBox rtboxDescription;
        private Button btnSave;
        private Button btnCancel;
        private Panel panel1;
        private Panel panel2;
    }
}