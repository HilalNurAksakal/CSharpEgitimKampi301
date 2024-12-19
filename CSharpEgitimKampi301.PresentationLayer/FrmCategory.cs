using CSharpEgitimKampi301.BusinessLayer.Abstract;
using CSharpEgitimKampi301.BusinessLayer.Concrete;
using CSharpEgitimKampi301.DataAccessLayer.EntityFramework;
using CSharpEgitimKampi301.EntityLayer.Concreate;
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
        private readonly ICategoryService _categoryService;

        public FrmCategory()
        {
            this._categoryService = new CategoryManager(new EfCategoryDal());
            InitializeComponent();
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var categoryvalues = _categoryService.TGetAll();
            dataGridView1.DataSource= categoryvalues;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryName=txtCategoryName.Text;
            category.CategoryStatus = true;
            _categoryService.TInsert(category);
            MessageBox.Show("Ekleme Başarılı");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategortId.Text);
            var deletedValues=_categoryService.TGetById(id);
            _categoryService.TDelete(deletedValues);
            MessageBox.Show("Silme Başarılı");
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id=int.Parse(txtCategortId.Text);
            var values= _categoryService.TGetById(id);
            dataGridView1.DataSource = values;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int updatedId=int.Parse(txtCategortId.Text);
            var updatedValue = _categoryService.TGetById(updatedId);
            updatedValue.CategoryName=txtCategoryName.Text;
            updatedValue.CategoryStatus = true;
            _categoryService.TUpdate(updatedValue);
        }
    }
}
