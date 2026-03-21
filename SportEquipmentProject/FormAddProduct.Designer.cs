namespace SportEquipmentProject
{
    partial class FormAddProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddProduct));
            flowLayoutPanelButtons = new FlowLayoutPanel();
            btnSave = new Button();
            btnCancel = new Button();
            pnMain = new Panel();
            numDiscount = new NumericUpDown();
            numPrice = new NumericUpDown();
            numCount = new NumericUpDown();
            lblUnit = new Label();
            cmbUnit = new ComboBox();
            lblSupplier = new Label();
            cmbSupplier = new ComboBox();
            lblManufacturer = new Label();
            cmbManufacturer = new ComboBox();
            lblCategory = new Label();
            txtDescription = new TextBox();
            lblDescription = new Label();
            cmbCategory = new ComboBox();
            lblCount = new Label();
            lblDiscount = new Label();
            lblPrice = new Label();
            txtProductName = new TextBox();
            lblProductName = new Label();
            flowLayoutPanelButtons.SuspendLayout();
            pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDiscount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCount).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanelButtons
            // 
            flowLayoutPanelButtons.Controls.Add(btnSave);
            flowLayoutPanelButtons.Controls.Add(btnCancel);
            flowLayoutPanelButtons.Dock = DockStyle.Bottom;
            flowLayoutPanelButtons.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanelButtons.Location = new Point(9, 530);
            flowLayoutPanelButtons.Name = "flowLayoutPanelButtons";
            flowLayoutPanelButtons.Size = new Size(671, 37);
            flowLayoutPanelButtons.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(67, 97, 238);
            btnSave.DialogResult = DialogResult.OK;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(555, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(113, 31);
            btnSave.TabIndex = 2;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += BtnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(67, 97, 238);
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(436, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(113, 31);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // pnMain
            // 
            pnMain.Controls.Add(numDiscount);
            pnMain.Controls.Add(numPrice);
            pnMain.Controls.Add(numCount);
            pnMain.Controls.Add(lblUnit);
            pnMain.Controls.Add(cmbUnit);
            pnMain.Controls.Add(lblSupplier);
            pnMain.Controls.Add(cmbSupplier);
            pnMain.Controls.Add(lblManufacturer);
            pnMain.Controls.Add(cmbManufacturer);
            pnMain.Controls.Add(lblCategory);
            pnMain.Controls.Add(txtDescription);
            pnMain.Controls.Add(lblDescription);
            pnMain.Controls.Add(cmbCategory);
            pnMain.Controls.Add(lblCount);
            pnMain.Controls.Add(lblDiscount);
            pnMain.Controls.Add(lblPrice);
            pnMain.Controls.Add(txtProductName);
            pnMain.Controls.Add(lblProductName);
            pnMain.Dock = DockStyle.Fill;
            pnMain.Location = new Point(9, 9);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(671, 521);
            pnMain.TabIndex = 1;
            // 
            // numDiscount
            // 
            numDiscount.Location = new Point(23, 189);
            numDiscount.Name = "numDiscount";
            numDiscount.Size = new Size(120, 26);
            numDiscount.TabIndex = 20;
            // 
            // numPrice
            // 
            numPrice.Location = new Point(23, 128);
            numPrice.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(120, 26);
            numPrice.TabIndex = 19;
            // 
            // numCount
            // 
            numCount.Location = new Point(23, 250);
            numCount.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numCount.Name = "numCount";
            numCount.Size = new Size(120, 26);
            numCount.TabIndex = 18;
            // 
            // lblUnit
            // 
            lblUnit.AutoSize = true;
            lblUnit.Location = new Point(444, 226);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(106, 19);
            lblUnit.TabIndex = 17;
            lblUnit.Text = "Ед. измерения";
            // 
            // cmbUnit
            // 
            cmbUnit.FormattingEnabled = true;
            cmbUnit.Location = new Point(444, 255);
            cmbUnit.Name = "cmbUnit";
            cmbUnit.Size = new Size(201, 27);
            cmbUnit.TabIndex = 16;
            // 
            // lblSupplier
            // 
            lblSupplier.AutoSize = true;
            lblSupplier.Location = new Point(444, 160);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new Size(84, 19);
            lblSupplier.TabIndex = 15;
            lblSupplier.Text = "Поставщик";
            // 
            // cmbSupplier
            // 
            cmbSupplier.FormattingEnabled = true;
            cmbSupplier.Location = new Point(444, 189);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.Size = new Size(201, 27);
            cmbSupplier.TabIndex = 14;
            // 
            // lblManufacturer
            // 
            lblManufacturer.AutoSize = true;
            lblManufacturer.Location = new Point(444, 94);
            lblManufacturer.Name = "lblManufacturer";
            lblManufacturer.Size = new Size(113, 19);
            lblManufacturer.TabIndex = 13;
            lblManufacturer.Text = "Производитель";
            // 
            // cmbManufacturer
            // 
            cmbManufacturer.FormattingEnabled = true;
            cmbManufacturer.Location = new Point(444, 123);
            cmbManufacturer.Name = "cmbManufacturer";
            cmbManufacturer.Size = new Size(201, 27);
            cmbManufacturer.TabIndex = 12;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(444, 28);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(79, 19);
            lblCategory.TabIndex = 11;
            lblCategory.Text = "Категория";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(23, 311);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(350, 148);
            txtDescription.TabIndex = 10;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(23, 284);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(78, 19);
            lblDescription.TabIndex = 9;
            lblDescription.Text = "Описание";
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(444, 57);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(201, 27);
            cmbCategory.TabIndex = 8;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Location = new Point(23, 223);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(57, 19);
            lblCount.TabIndex = 6;
            lblCount.Text = "Кол-во";
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Location = new Point(23, 162);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(58, 19);
            lblDiscount.TabIndex = 4;
            lblDiscount.Text = "Скидка";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(23, 101);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(43, 19);
            lblPrice.TabIndex = 2;
            lblPrice.Text = "Цена";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(23, 67);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(350, 26);
            txtProductName.TabIndex = 1;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(23, 40);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(122, 19);
            lblProductName.TabIndex = 0;
            lblProductName.Text = "Название товара";
            // 
            // FormAddProduct
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(689, 576);
            Controls.Add(pnMain);
            Controls.Add(flowLayoutPanelButtons);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "FormAddProduct";
            Padding = new Padding(9);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавление/редактирование товара";
            flowLayoutPanelButtons.ResumeLayout(false);
            pnMain.ResumeLayout(false);
            pnMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDiscount).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelButtons;
        private Button btnSave;
        private Button btnCancel;
        private Panel pnMain;
        private TextBox txtProductName;
        private Label lblProductName;
        private Label lblCount;
        private Label lblDiscount;
        private Label lblPrice;
        private ComboBox cmbCategory;
        private Label lblSupplier;
        private ComboBox cmbSupplier;
        private Label lblManufacturer;
        private ComboBox cmbManufacturer;
        private Label lblCategory;
        private TextBox txtDescription;
        private Label lblDescription;
        private Label lblUnit;
        private ComboBox cmbUnit;
        private NumericUpDown numCount;
        private NumericUpDown numPrice;
        private NumericUpDown numDiscount;
    }
}