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
            gbxAdd = new GroupBox();
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
            gbxUpdate = new GroupBox();
            btnUpdate = new Button();
            lblUpdateQuantityPerUnit = new Label();
            lblUpdateUnitsInStock = new Label();
            lblUpdateUnitPrice = new Label();
            lblUpdateCategoryId = new Label();
            lblUpdateProductName = new Label();
            cbxUpdateCategoryId = new ComboBox();
            tbxUpdateQuantityPerUnit = new TextBox();
            tbxUpdateUnitsInStock = new TextBox();
            tbxUpdateUnitPrice = new TextBox();
            tbxUpdateProductName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgwProducts).BeginInit();
            gbxFilterCategory.SuspendLayout();
            gbxFilterProductName.SuspendLayout();
            gbxAdd.SuspendLayout();
            gbxUpdate.SuspendLayout();
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
            dgwProducts.CellClick += dgwProducts_CellClick;
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
            // gbxAdd
            // 
            gbxAdd.Controls.Add(btnAdd);
            gbxAdd.Controls.Add(lblAddQuantityPerUnit);
            gbxAdd.Controls.Add(lblAddUnitsInStock);
            gbxAdd.Controls.Add(lblAddUnitPrice);
            gbxAdd.Controls.Add(lblAddCategoryId);
            gbxAdd.Controls.Add(lblAddProductName);
            gbxAdd.Controls.Add(cbxAddCategoryId);
            gbxAdd.Controls.Add(tbxAddQuantityPerUnit);
            gbxAdd.Controls.Add(tbxAddUnitsInStock);
            gbxAdd.Controls.Add(tbxAddUnitPrice);
            gbxAdd.Controls.Add(tbxAddProductName);
            gbxAdd.Location = new Point(12, 474);
            gbxAdd.Name = "gbxAdd";
            gbxAdd.Size = new Size(343, 203);
            gbxAdd.TabIndex = 3;
            gbxAdd.TabStop = false;
            gbxAdd.Text = "Add a Product";
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
            // gbxUpdate
            // 
            gbxUpdate.Controls.Add(btnUpdate);
            gbxUpdate.Controls.Add(lblUpdateQuantityPerUnit);
            gbxUpdate.Controls.Add(lblUpdateUnitsInStock);
            gbxUpdate.Controls.Add(lblUpdateUnitPrice);
            gbxUpdate.Controls.Add(lblUpdateCategoryId);
            gbxUpdate.Controls.Add(lblUpdateProductName);
            gbxUpdate.Controls.Add(cbxUpdateCategoryId);
            gbxUpdate.Controls.Add(tbxUpdateQuantityPerUnit);
            gbxUpdate.Controls.Add(tbxUpdateUnitsInStock);
            gbxUpdate.Controls.Add(tbxUpdateUnitPrice);
            gbxUpdate.Controls.Add(tbxUpdateProductName);
            gbxUpdate.Location = new Point(361, 474);
            gbxUpdate.Name = "gbxUpdate";
            gbxUpdate.Size = new Size(343, 203);
            gbxUpdate.TabIndex = 11;
            gbxUpdate.TabStop = false;
            gbxUpdate.Text = "Update a Product";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(220, 167);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(109, 30);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update Product";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lblUpdateQuantityPerUnit
            // 
            lblUpdateQuantityPerUnit.AutoSize = true;
            lblUpdateQuantityPerUnit.Location = new Point(9, 141);
            lblUpdateQuantityPerUnit.Name = "lblUpdateQuantityPerUnit";
            lblUpdateQuantityPerUnit.Size = new Size(98, 15);
            lblUpdateQuantityPerUnit.TabIndex = 9;
            lblUpdateQuantityPerUnit.Text = "Quantity Per Unit";
            // 
            // lblUpdateUnitsInStock
            // 
            lblUpdateUnitsInStock.AutoSize = true;
            lblUpdateUnitsInStock.Location = new Point(18, 112);
            lblUpdateUnitsInStock.Name = "lblUpdateUnitsInStock";
            lblUpdateUnitsInStock.Size = new Size(89, 15);
            lblUpdateUnitsInStock.TabIndex = 8;
            lblUpdateUnitsInStock.Text = "Stock Amount :";
            // 
            // lblUpdateUnitPrice
            // 
            lblUpdateUnitPrice.AutoSize = true;
            lblUpdateUnitPrice.Location = new Point(68, 83);
            lblUpdateUnitPrice.Name = "lblUpdateUnitPrice";
            lblUpdateUnitPrice.Size = new Size(39, 15);
            lblUpdateUnitPrice.TabIndex = 7;
            lblUpdateUnitPrice.Text = "Price :";
            // 
            // lblUpdateCategoryId
            // 
            lblUpdateCategoryId.AutoSize = true;
            lblUpdateCategoryId.Location = new Point(46, 54);
            lblUpdateCategoryId.Name = "lblUpdateCategoryId";
            lblUpdateCategoryId.Size = new Size(61, 15);
            lblUpdateCategoryId.TabIndex = 6;
            lblUpdateCategoryId.Text = "Category :";
            // 
            // lblUpdateProductName
            // 
            lblUpdateProductName.AutoSize = true;
            lblUpdateProductName.Location = new Point(17, 25);
            lblUpdateProductName.Name = "lblUpdateProductName";
            lblUpdateProductName.Size = new Size(90, 15);
            lblUpdateProductName.TabIndex = 5;
            lblUpdateProductName.Text = "Product Name :";
            // 
            // cbxUpdateCategoryId
            // 
            cbxUpdateCategoryId.FormattingEnabled = true;
            cbxUpdateCategoryId.Location = new Point(113, 51);
            cbxUpdateCategoryId.Name = "cbxUpdateCategoryId";
            cbxUpdateCategoryId.Size = new Size(216, 23);
            cbxUpdateCategoryId.TabIndex = 4;
            // 
            // tbxUpdateQuantityPerUnit
            // 
            tbxUpdateQuantityPerUnit.Location = new Point(113, 138);
            tbxUpdateQuantityPerUnit.Name = "tbxUpdateQuantityPerUnit";
            tbxUpdateQuantityPerUnit.Size = new Size(216, 23);
            tbxUpdateQuantityPerUnit.TabIndex = 3;
            // 
            // tbxUpdateUnitsInStock
            // 
            tbxUpdateUnitsInStock.Location = new Point(113, 109);
            tbxUpdateUnitsInStock.Name = "tbxUpdateUnitsInStock";
            tbxUpdateUnitsInStock.Size = new Size(216, 23);
            tbxUpdateUnitsInStock.TabIndex = 2;
            // 
            // tbxUpdateUnitPrice
            // 
            tbxUpdateUnitPrice.Location = new Point(113, 80);
            tbxUpdateUnitPrice.Name = "tbxUpdateUnitPrice";
            tbxUpdateUnitPrice.Size = new Size(216, 23);
            tbxUpdateUnitPrice.TabIndex = 1;
            // 
            // tbxUpdateProductName
            // 
            tbxUpdateProductName.Location = new Point(113, 22);
            tbxUpdateProductName.Name = "tbxUpdateProductName";
            tbxUpdateProductName.Size = new Size(216, 23);
            tbxUpdateProductName.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 689);
            Controls.Add(gbxUpdate);
            Controls.Add(gbxAdd);
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
            gbxAdd.ResumeLayout(false);
            gbxAdd.PerformLayout();
            gbxUpdate.ResumeLayout(false);
            gbxUpdate.PerformLayout();
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
        private GroupBox gbxAdd;
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
        private GroupBox gbxUpdate;
        private Button btnUpdate;
        private Label lblUpdateQuantityPerUnit;
        private Label lblUpdateUnitsInStock;
        private Label lblUpdateUnitPrice;
        private Label lblUpdateCategoryId;
        private Label lblUpdateProductName;
        private ComboBox cbxUpdateCategoryId;
        private TextBox tbxUpdateQuantityPerUnit;
        private TextBox tbxUpdateUnitsInStock;
        private TextBox tbxUpdateUnitPrice;
        private TextBox tbxUpdateProductName;
    }
}