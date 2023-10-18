namespace Northwind.WebFormsUI
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
            dgwProducts = new DataGridView();
            gbxFilterCategory = new GroupBox();
            cbxFilterCategory = new ComboBox();
            lblFilterCategory = new Label();
            gbxFilterProductName = new GroupBox();
            tbxFilterProductName = new TextBox();
            lblFilterProductName = new Label();
            ((System.ComponentModel.ISupportInitialize)dgwProducts).BeginInit();
            gbxFilterCategory.SuspendLayout();
            gbxFilterProductName.SuspendLayout();
            SuspendLayout();
            // 
            // dgwProducts
            // 
            dgwProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwProducts.Location = new Point(12, 190);
            dgwProducts.Name = "dgwProducts";
            dgwProducts.RowTemplate.Height = 25;
            dgwProducts.Size = new Size(1076, 278);
            dgwProducts.TabIndex = 0;
            // 
            // gbxFilterCategory
            // 
            gbxFilterCategory.Controls.Add(cbxFilterCategory);
            gbxFilterCategory.Controls.Add(lblFilterCategory);
            gbxFilterCategory.Location = new Point(12, 12);
            gbxFilterCategory.Name = "gbxFilterCategory";
            gbxFilterCategory.Size = new Size(1076, 80);
            gbxFilterCategory.TabIndex = 1;
            gbxFilterCategory.TabStop = false;
            gbxFilterCategory.Text = "Filter By Category";
            // 
            // cbxFilterCategory
            // 
            cbxFilterCategory.FormattingEnabled = true;
            cbxFilterCategory.Location = new Point(102, 29);
            cbxFilterCategory.Name = "cbxFilterCategory";
            cbxFilterCategory.Size = new Size(139, 23);
            cbxFilterCategory.TabIndex = 1;
            cbxFilterCategory.SelectedIndexChanged += cbxFilterCategory_SelectedIndexChanged;
            // 
            // lblFilterCategory
            // 
            lblFilterCategory.AutoSize = true;
            lblFilterCategory.Location = new Point(35, 32);
            lblFilterCategory.Name = "lblFilterCategory";
            lblFilterCategory.Size = new Size(61, 15);
            lblFilterCategory.TabIndex = 0;
            lblFilterCategory.Text = "Category :";
            // 
            // gbxFilterProductName
            // 
            gbxFilterProductName.Controls.Add(tbxFilterProductName);
            gbxFilterProductName.Controls.Add(lblFilterProductName);
            gbxFilterProductName.Location = new Point(12, 98);
            gbxFilterProductName.Name = "gbxFilterProductName";
            gbxFilterProductName.Size = new Size(1076, 86);
            gbxFilterProductName.TabIndex = 2;
            gbxFilterProductName.TabStop = false;
            gbxFilterProductName.Text = "Filter By Product Name";
            // 
            // tbxFilterProductName
            // 
            tbxFilterProductName.Location = new Point(102, 37);
            tbxFilterProductName.Name = "tbxFilterProductName";
            tbxFilterProductName.Size = new Size(139, 23);
            tbxFilterProductName.TabIndex = 1;
            // 
            // lblFilterProductName
            // 
            lblFilterProductName.AutoSize = true;
            lblFilterProductName.Location = new Point(6, 40);
            lblFilterProductName.Name = "lblFilterProductName";
            lblFilterProductName.Size = new Size(90, 15);
            lblFilterProductName.TabIndex = 0;
            lblFilterProductName.Text = "Product Name :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 480);
            Controls.Add(gbxFilterProductName);
            Controls.Add(gbxFilterCategory);
            Controls.Add(dgwProducts);
            Name = "Form1";
            Text = "Products";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgwProducts).EndInit();
            gbxFilterCategory.ResumeLayout(false);
            gbxFilterCategory.PerformLayout();
            gbxFilterProductName.ResumeLayout(false);
            gbxFilterProductName.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgwProducts;
        private GroupBox gbxFilterCategory;
        private GroupBox gbxFilterProductName;
        private ComboBox cbxFilterCategory;
        private Label lblFilterCategory;
        private TextBox tbxFilterProductName;
        private Label lblFilterProductName;
    }
}