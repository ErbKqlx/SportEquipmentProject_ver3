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
        private long _selectedId;

        public FormAddProduct(long selectedId = -1)
        {
            InitializeComponent();
            _selectedId = selectedId;

            LoadProductInfo();
        }

        private void LoadProductInfo()
        {
            using (var db = new DemDbContext())
            {
                var product = db.Products.FirstOrDefault(v => v.Id == _selectedId);

                db.ProductCategories.Load();
                db.Manufacturers.Load();
                db.Suppliers.Load();
                db.UnitsOfMeasurements.Load();

                cmbCategory.DataSource = db.ProductCategories.Local.ToBindingList();
                cmbCategory.DisplayMember = "CategoryName";
                cmbCategory.ValueMember = "Id";
                
                cmbManufacturer.DataSource = db.Manufacturers.Local.ToBindingList();
                cmbManufacturer.DisplayMember = "ManufacturerName";
                cmbManufacturer.ValueMember = "Id";

                cmbSupplier.DataSource = db.Suppliers.Local.ToBindingList();
                cmbSupplier.DisplayMember = "SupplierName";
                cmbSupplier.ValueMember = "Id";
                
                cmbUnit.DataSource = db.UnitsOfMeasurements.Local.ToBindingList();
                cmbUnit.DisplayMember = "UnitName";
                cmbUnit.ValueMember = "Id";

                if (_selectedId != -1)
                {
                    txtProductName.Text = product.ProductName;
                    numPrice.Value = product.Price;
                    numDiscount.Value = product.Discount;
                    numCount.Value = product.Count;
                    txtDescription.Text = product.Description;

                    cmbCategory.SelectedValue = product.IdProductCategory;
                    cmbManufacturer.SelectedValue = product.IdManufacturer;
                    cmbSupplier.SelectedValue = product.IdSupplier;
                    cmbUnit.SelectedValue = product.IdUnitOfMeasurement;
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            using (var db = new DemDbContext())
            {
                var product = db.Products.FirstOrDefault(v => v.Id == _selectedId);

                if (product == null)
                {
                    product = new Product();
                }

                //var product = new Product();

                product.ProductName = txtProductName.Text;
                product.Price = numPrice.Value;
                product.Discount = (short)numDiscount.Value;
                product.Count = (short)numCount.Value;
                product.Description = txtDescription.Text;
                product.IdProductCategory = (short)cmbCategory.SelectedValue;
                product.IdManufacturer = (int)cmbManufacturer.SelectedValue;
                product.IdSupplier = (int)cmbSupplier.SelectedValue;
                product.IdUnitOfMeasurement = (short)cmbUnit.SelectedValue;

                if (_selectedId == -1)
                {
                    db.Add(product);
                }
                else
                {
                    db.Update(product);
                }
                db.SaveChanges();
            }
        }
    }
}
