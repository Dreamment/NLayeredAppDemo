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
            groupBox1 = new GroupBox();
            btnAdd = new Button();
            lblAddQuantityPerUnit = new Label();
            lblAddUnitsInStock = new Label();
            lblAddUnitPrice = new Label();
            lblAddCategoryId = new Label();
            lblAddProductName = new Label();
            cbxAddCategoryId = new ComboBox();
            tbxAddQuantityPerUnit = new TextBox();
            tbxAddUnitsInStock = new TextBox();
            tbxAddUnitPrice = new TextBox();
            tbxAddProductName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgwProducts).BeginInit();
            gbxFilterCategory.SuspendLayout();
            gbxFilterProductName.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgwProducts
            // 
            dgwProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwProducts.Location = new Point(12, 190);
            dgwProducts.Name = "dgwProducts";
            dgwProducts.RowTemplate.Height = 25;
            dgwProducts.Size = new Size(920, 278);
            dgwProducts.TabIndex = 0;
            // 
            // gbxFilterCategory
            // 
            gbxFilterCategory.Controls.Add(cbxFilterCategory);
            gbxFilterCategory.Controls.Add(lblFilterCategory);
            gbxFilterCategory.Location = new Point(12, 12);
            gbxFilterCategory.Name = "gbxFilterCategory";
            gbxFilterCategory.Size = new Size(920, 80);
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
            gbxFilterProductName.Size = new Size(920, 86);
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
            tbxFilterProductName.TextChanged += tbxFilterProductName_TextChanged;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(lblAddQuantityPerUnit);
            groupBox1.Controls.Add(lblAddUnitsInStock);
            groupBox1.Controls.Add(lblAddUnitPrice);
            groupBox1.Controls.Add(lblAddCategoryId);
            groupBox1.Controls.Add(lblAddProductName);
            groupBox1.Controls.Add(cbxAddCategoryId);
            groupBox1.Controls.Add(tbxAddQuantityPerUnit);
            groupBox1.Controls.Add(tbxAddUnitsInStock);
            groupBox1.Controls.Add(tbxAddUnitPrice);
            groupBox1.Controls.Add(tbxAddProductName);
            groupBox1.Location = new Point(12, 474);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(343, 203);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(220, 167);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(109, 30);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add Product";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblAddQuantityPerUnit
            // 
            lblAddQuantityPerUnit.AutoSize = true;
            lblAddQuantityPerUnit.Location = new Point(9, 141);
            lblAddQuantityPerUnit.Name = "lblAddQuantityPerUnit";
            lblAddQuantityPerUnit.Size = new Size(98, 15);
            lblAddQuantityPerUnit.TabIndex = 9;
            lblAddQuantityPerUnit.Text = "Quantity Per Unit";
            // 
            // lblAddUnitsInStock
            // 
            lblAddUnitsInStock.AutoSize = true;
            lblAddUnitsInStock.Location = new Point(18, 112);
            lblAddUnitsInStock.Name = "lblAddUnitsInStock";
            lblAddUnitsInStock.Size = new Size(89, 15);
            lblAddUnitsInStock.TabIndex = 8;
            lblAddUnitsInStock.Text = "Stock Amount :";
            // 
            // lblAddUnitPrice
            // 
            lblAddUnitPrice.AutoSize = true;
            lblAddUnitPrice.Location = new Point(68, 83);
            lblAddUnitPrice.Name = "lblAddUnitPrice";
            lblAddUnitPrice.Size = new Size(39, 15);
            lblAddUnitPrice.TabIndex = 7;
            lblAddUnitPrice.Text = "Price :";
            // 
            // lblAddCategoryId
            // 
            lblAddCategoryId.AutoSize = true;
            lblAddCategoryId.Location = new Point(46, 54);
            lblAddCategoryId.Name = "lblAddCategoryId";
            lblAddCategoryId.Size = new Size(61, 15);
            lblAddCategoryId.TabIndex = 6;
            lblAddCategoryId.Text = "Category :";
            // 
            // lblAddProductName
            // 
            lblAddProductName.AutoSize = true;
            lblAddProductName.Location = new Point(17, 25);
            lblAddProductName.Name = "lblAddProductName";
            lblAddProductName.Size = new Size(90, 15);
            lblAddProductName.TabIndex = 5;
            lblAddProductName.Text = "Product Name :";
            // 
            // cbxAddCategoryId
            // 
            cbxAddCategoryId.FormattingEnabled = true;
            cbxAddCategoryId.Location = new Point(113, 51);
            cbxAddCategoryId.Name = "cbxAddCategoryId";
            cbxAddCategoryId.Size = new Size(216, 23);
            cbxAddCategoryId.TabIndex = 4;
            // 
            // tbxAddQuantityPerUnit
            // 
            tbxAddQuantityPerUnit.Location = new Point(113, 138);
            tbxAddQuantityPerUnit.Name = "tbxAddQuantityPerUnit";
            tbxAddQuantityPerUnit.Size = new Size(216, 23);
            tbxAddQuantityPerUnit.TabIndex = 3;
            // 
            // tbxAddUnitsInStock
            // 
            tbxAddUnitsInStock.Location = new Point(113, 109);
            tbxAddUnitsInStock.Name = "tbxAddUnitsInStock";
            tbxAddUnitsInStock.Size = new Size(216, 23);
            tbxAddUnitsInStock.TabIndex = 2;
            // 
            // tbxAddUnitPrice
            // 
            tbxAddUnitPrice.Location = new Point(113, 80);
            tbxAddUnitPrice.Name = "tbxAddUnitPrice";
            tbxAddUnitPrice.Size = new Size(216, 23);
            tbxAddUnitPrice.TabIndex = 1;
            // 
            // tbxAddProductName
            // 
            tbxAddProductName.Location = new Point(113, 22);
            tbxAddProductName.Name = "tbxAddProductName";
            tbxAddProductName.Size = new Size(216, 23);
            tbxAddProductName.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 689);
            Controls.Add(groupBox1);
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
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private GroupBox groupBox1;
        private Label lblAddQuantityPerUnit;
        private Label lblAddUnitsInStock;
        private Label lblAddUnitPrice;
        private Label lblAddCategoryId;
        private Label lblAddProductName;
        private ComboBox cbxAddCategoryId;
        private TextBox tbxAddQuantityPerUnit;
        private TextBox tbxAddUnitsInStock;
        private TextBox tbxAddUnitPrice;
        private TextBox tbxAddProductName;
        private Button btnAdd;
    }
}