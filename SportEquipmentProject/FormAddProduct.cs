using Microsoft.EntityFrameworkCore;
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
                numPrice.Value = product.Price;
                numDiscount.Value = product.Discount;
                numCount.Value = product.Count;
                txtDescription.Text = product.Description;

                db.ProductCategories.Load();
                db.Manufacturers.Load();
                db.Suppliers.Load();
                db.UnitsOfMeasurements.Load();

                cmbCategory.DataSource = db.ProductCategories.Local.ToBindingList();
                cmbCategory.DisplayMember = "CategoryName";
                cmbCategory.ValueMember = "Id";
                cmbCategory.SelectedValue = product.IdProductCategory;

                cmbManufacturer.DataSource = db.Manufacturers.Local.ToBindingList();
                cmbManufacturer.DisplayMember = "ManufacturerName";
                cmbManufacturer.ValueMember = "Id";
                cmbManufacturer.SelectedValue = product.IdManufacturer;

                cmbSupplier.DataSource = db.Suppliers.Local.ToBindingList();
                cmbSupplier.DisplayMember = "SupplierName";
                cmbSupplier.ValueMember = "Id";
                cmbSupplier.SelectedValue = product.IdSupplier;

                cmbUnit.DataSource = db.UnitsOfMeasurements.Local.ToBindingList();
                cmbUnit.DisplayMember = "UnitName";
                cmbUnit.ValueMember = "Id";
                cmbUnit.SelectedValue = product.IdUnitOfMeasurement;

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
