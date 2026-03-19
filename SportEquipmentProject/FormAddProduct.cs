using SportEquipmentProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportEquipmentProject
{
    public partial class FormAddProduct : Form
    {
        //private long _selectedId;

        public FormAddProduct()
        {
            InitializeComponent();
        }

        public FormAddProduct(long selectedId)
        {
            InitializeComponent();
            //_selectedId = selectedId;

            LoadProductInfo(selectedId);
        }

        private void LoadProductInfo(long selectedId)
        {
            using (var db = new DemDbContext())
            {
                var product = db.Products.FirstOrDefault(v => v.Id == selectedId);
                txtProductName.Text = product.ProductName;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            //var product = new Product();
            //product.IdProductCategoryNavigation.CategoryName = cmbCategory.SelectedValue;

            using (var db = new DemDbContext())
            {

            }
        }
    }
}
