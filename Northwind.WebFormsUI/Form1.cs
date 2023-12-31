using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.Business.DependencyResolvers.Ninject;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.DataAccess.Concrete.NHibernate;
using Northwind.Entities.Concrete;
using System;

namespace Northwind.WebFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _productService = InstanceFactory.GetInstance<IProductService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
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
            Category chooseFilterCategory = new Category
            {
                CategoryId = 0,
                CategoryName = "Choose Category"
            };
            List<Category> filterCategories = _categoryService.GetAll();
            filterCategories.Insert(0, chooseFilterCategory);
            cbxFilterCategory.DataSource = filterCategories;
            cbxFilterCategory.DisplayMember = "CategoryName";
            cbxFilterCategory.ValueMember = "CategoryId";

            Category chooseAddCategory = new Category
            {
                CategoryId = 0,
                CategoryName = "Choose Category"
            };
            List<Category> addCategories = _categoryService.GetAll();
            addCategories.Insert(0, chooseAddCategory);
            cbxAddCategoryId.DataSource = addCategories;
            cbxAddCategoryId.DisplayMember = "CategoryName";
            cbxAddCategoryId.ValueMember = "CategoryId";

            Category chooseUpdateCategory = new Category
            {
                CategoryId = 0,
                CategoryName = "Choose Category"
            };
            List<Category> updateCategories = _categoryService.GetAll();
            updateCategories.Insert(0, chooseUpdateCategory);
            cbxUpdateCategoryId.DataSource = updateCategories;
            cbxUpdateCategoryId.DisplayMember = "CategoryName";
            cbxUpdateCategoryId.ValueMember = "CategoryId";
        }

        private void LoadProducts()
        {
            dgwProducts.DataSource = _productService.GetAll();
        }

        private void cbxFilterCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxFilterCategory.SelectedIndex == 0)
            {
                LoadProducts();
            }
            else
            {
                try
                {
                    dgwProducts.DataSource = _productService.GetProductsByCategory(Convert.ToInt32(cbxFilterCategory.SelectedValue));
                }
                catch
                {

                }
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
            if (cbxAddCategoryId.SelectedIndex == 0)
            {
                MessageBox.Show("Please choose a category!");
                return;
            }
            else
            {
                try
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
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int selectedProductId = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value);
            if (cbxUpdateCategoryId.SelectedIndex == 0)
            {
                MessageBox.Show("Please choose a category!");
                return;
            }
            else
            {
                try
                {
                    _productService.Update(new Product
                    {
                        ProductId = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                        CategoryId = Convert.ToInt32(cbxUpdateCategoryId.SelectedValue),
                        ProductName = tbxUpdateProductName.Text,
                        QuantityPerUnit = tbxUpdateQuantityPerUnit.Text,
                        UnitPrice = Convert.ToDecimal(tbxUpdateUnitPrice.Text),
                        UnitsInStock = Convert.ToInt16(tbxUpdateUnitsInStock.Text)
                    });
                    LoadProducts();
                    MessageBox.Show("Product Updated!");

                    tbxUpdateProductName.Clear();
                    tbxUpdateQuantityPerUnit.Clear();
                    tbxUpdateUnitPrice.Clear();
                    tbxUpdateUnitsInStock.Clear();
                    cbxAddCategoryId.SelectedIndex = 0;
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxUpdateProductName.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            cbxUpdateCategoryId.SelectedValue = dgwProducts.CurrentRow.Cells[2].Value;
            tbxUpdateUnitPrice.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
            tbxUpdateQuantityPerUnit.Text = dgwProducts.CurrentRow.Cells[4].Value.ToString();
            tbxUpdateUnitsInStock.Text = dgwProducts.CurrentRow.Cells[5].Value.ToString();

            tbxDeleteProductName.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            tbxDeleteCategoryId.Text = _categoryName(Convert.ToInt32(dgwProducts.CurrentRow.Cells[2].Value));
            tbxDeleteUnitPrice.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
            tbxDeleteQuantityPerUnit.Text = dgwProducts.CurrentRow.Cells[4].Value.ToString();
            tbxDeleteUnitsInStock.Text = dgwProducts.CurrentRow.Cells[5].Value.ToString();
        }

        private string _categoryName(int categoryId)
        {
            return _categoryService.GetCategoryName(Convert.ToInt32(categoryId));
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _productService.Delete(new Product
            {
                ProductId = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value)
            });
            LoadProducts();
            MessageBox.Show("Product Deleted!");

            tbxDeleteProductName.Clear();
            tbxDeleteCategoryId.Clear();
            tbxDeleteUnitPrice.Clear();
            tbxDeleteQuantityPerUnit.Clear();
            tbxDeleteUnitsInStock.Clear();
        }
    }
}