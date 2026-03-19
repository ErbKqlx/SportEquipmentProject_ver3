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

        public FormAddProduct()
        {
            InitializeComponent();
        }

        public FormAddProduct(long selectedId)
        {
            InitializeComponent();
            _selectedId = selectedId;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
