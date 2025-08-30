using CSharpEgitimKampi301.BusinessLayer.Abstract;
using CSharpEgitimKampi301.BusinessLayer.Concrete;
using CSharpEgitimKampi301.DataAccessLayer.EntityFramework;
using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.PresentationLayer
{
    public partial class FrmCategory : Form
    {
        private readonly ICategoryService categoryService;

        public FrmCategory()
        {
            categoryService = new CategoryManager(new EfCategoryDal());
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmCategory_Load(object sender, EventArgs e)
        {
           
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var categoryValues = categoryService.TGetAll();
            dataGridView1.DataSource = categoryValues;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryName = txtCategoryName.Text;
            category.CategoryStatus = true;
            categoryService.TInsert(category);
            MessageBox.Show("Kategori Eklendi");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoryId.Text);
            var deletedValue = categoryService.TGetById(id);
            categoryService.TDelete(deletedValue);
            MessageBox.Show("Kategori Silindi");

        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoryId.Text);
            var value = categoryService.TGetById(id);
            txtCategoryName.Text = value.CategoryName;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            int uptadeId = int.Parse(txtCategoryId.Text);
            var updatedValue = categoryService.TGetById(uptadeId);
            updatedValue.CategoryName = txtCategoryName.Text;
            updatedValue.CategoryStatus = true;
            categoryService.TUpdate(updatedValue);
            MessageBox.Show("Kategori Güncellendi");

        }
    }
}
