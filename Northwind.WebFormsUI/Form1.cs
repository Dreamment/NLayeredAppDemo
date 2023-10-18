using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.DataAccess.Concrete.NHibernate;
using Northwind.Entities.Concrete;

namespace Northwind.WebFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _productService = new ProductManager(new EfProductDal());
            _categoryService = new CategoryManager(new EfCategoryDal());
        }

        private IProductService _productService;
        private ICategoryService _categoryService;
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();

        }

        private void LoadCategories()
        {
            cbxFilterCategory.DataSource = _categoryService.GetAll();
            cbxFilterCategory.DisplayMember = "CategoryName";
            cbxFilterCategory.ValueMember = "CategoryId";

            cbxAddCategoryId.DataSource = _categoryService.GetAll();
            cbxAddCategoryId.DisplayMember = "CategoryName";
            cbxAddCategoryId.ValueMember = "CategoryId";
        }

        private void LoadProducts()
        {
            dgwProducts.DataSource = _productService.GetAll();
        }

        private void cbxFilterCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwProducts.DataSource = _productService.GetProductsByCategory(Convert.ToInt32(cbxFilterCategory.SelectedValue));
            }
            catch
            {

            }
        }

        private void tbxFilterProductName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxFilterProductName.Text))
            {
                dgwProducts.DataSource = _productService.GetProductsByProductName(tbxFilterProductName.Text);
            }
            else
            {
                LoadProducts();
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productService.Add(new Product
            {
                CategoryId = Convert.ToInt32(cbxAddCategoryId.SelectedValue),
                ProductName = tbxAddProductName.Text,
                QuantityPerUnit = tbxAddQuantityPerUnit.Text,
                UnitPrice = Convert.ToDecimal(tbxAddUnitPrice.Text),
                UnitsInStock = Convert.ToInt16(tbxAddUnitsInStock.Text)
            });
            LoadProducts();
            MessageBox.Show("Product Added!");
        }
    }
}