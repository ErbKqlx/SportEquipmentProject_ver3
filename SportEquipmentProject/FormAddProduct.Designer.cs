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
            lblProductName = new Label();
            txtProductName = new TextBox();
            txtPrice = new TextBox();
            lblPrice = new Label();
            txtDiscount = new TextBox();
            lblDiscount = new Label();
            txtCount = new TextBox();
            lblCount = new Label();
            cmbCategory = new ComboBox();
            txtDescription = new TextBox();
            lblDescription = new Label();
            lblCategory = new Label();
            lblManufacturer = new Label();
            cmbManufacturer = new ComboBox();
            lblSupplier = new Label();
            cmbSupplier = new ComboBox();
            lblUnit = new Label();
            cmbUnit = new ComboBox();
            flowLayoutPanelButtons.SuspendLayout();
            pnMain.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanelButtons
            // 
            flowLayoutPanelButtons.Controls.Add(btnSave);
            flowLayoutPanelButtons.Controls.Add(btnCancel);
            flowLayoutPanelButtons.Dock = DockStyle.Bottom;
            flowLayoutPanelButtons.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanelButtons.Location = new Point(9, 415);
            flowLayoutPanelButtons.Name = "flowLayoutPanelButtons";
            flowLayoutPanelButtons.Size = new Size(366, 37);
            flowLayoutPanelButtons.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(67, 97, 238);
            btnSave.DialogResult = DialogResult.OK;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(250, 3);
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
            btnCancel.Location = new Point(131, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(113, 31);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // pnMain
            // 
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
            pnMain.Controls.Add(txtCount);
            pnMain.Controls.Add(lblCount);
            pnMain.Controls.Add(txtDiscount);
            pnMain.Controls.Add(lblDiscount);
            pnMain.Controls.Add(txtPrice);
            pnMain.Controls.Add(lblPrice);
            pnMain.Controls.Add(txtProductName);
            pnMain.Controls.Add(lblProductName);
            pnMain.Dock = DockStyle.Fill;
            pnMain.Location = new Point(9, 9);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(366, 406);
            pnMain.TabIndex = 1;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(33, 39);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(122, 19);
            lblProductName.TabIndex = 0;
            lblProductName.Text = "Название товара";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(33, 66);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(100, 26);
            txtProductName.TabIndex = 1;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(33, 127);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 26);
            txtPrice.TabIndex = 3;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(33, 100);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(43, 19);
            lblPrice.TabIndex = 2;
            lblPrice.Text = "Цена";
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(33, 188);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(100, 26);
            txtDiscount.TabIndex = 5;
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Location = new Point(33, 161);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(58, 19);
            lblDiscount.TabIndex = 4;
            lblDiscount.Text = "Скидка";
            // 
            // txtCount
            // 
            txtCount.Location = new Point(33, 249);
            txtCount.Name = "txtCount";
            txtCount.Size = new Size(100, 26);
            txtCount.TabIndex = 7;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Location = new Point(33, 222);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(57, 19);
            lblCount.TabIndex = 6;
            lblCount.Text = "Кол-во";
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(212, 69);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(121, 27);
            cmbCategory.TabIndex = 8;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(33, 314);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(150, 50);
            txtDescription.TabIndex = 10;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(33, 287);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(78, 19);
            lblDescription.TabIndex = 9;
            lblDescription.Text = "Описание";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(212, 40);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(79, 19);
            lblCategory.TabIndex = 11;
            lblCategory.Text = "Категория";
            // 
            // lblManufacturer
            // 
            lblManufacturer.AutoSize = true;
            lblManufacturer.Location = new Point(212, 106);
            lblManufacturer.Name = "lblManufacturer";
            lblManufacturer.Size = new Size(113, 19);
            lblManufacturer.TabIndex = 13;
            lblManufacturer.Text = "Производитель";
            // 
            // cmbManufacturer
            // 
            cmbManufacturer.FormattingEnabled = true;
            cmbManufacturer.Location = new Point(212, 135);
            cmbManufacturer.Name = "cmbManufacturer";
            cmbManufacturer.Size = new Size(121, 27);
            cmbManufacturer.TabIndex = 12;
            // 
            // lblSupplier
            // 
            lblSupplier.AutoSize = true;
            lblSupplier.Location = new Point(212, 172);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new Size(84, 19);
            lblSupplier.TabIndex = 15;
            lblSupplier.Text = "Поставщик";
            // 
            // cmbSupplier
            // 
            cmbSupplier.FormattingEnabled = true;
            cmbSupplier.Location = new Point(212, 201);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.Size = new Size(121, 27);
            cmbSupplier.TabIndex = 14;
            // 
            // lblUnit
            // 
            lblUnit.AutoSize = true;
            lblUnit.Location = new Point(212, 238);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(106, 19);
            lblUnit.TabIndex = 17;
            lblUnit.Text = "Ед. измерения";
            // 
            // cmbUnit
            // 
            cmbUnit.FormattingEnabled = true;
            cmbUnit.Location = new Point(212, 267);
            cmbUnit.Name = "cmbUnit";
            cmbUnit.Size = new Size(121, 27);
            cmbUnit.TabIndex = 16;
            // 
            // FormAddProduct
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(384, 461);
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
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelButtons;
        private Button btnSave;
        private Button btnCancel;
        private Panel pnMain;
        private TextBox txtProductName;
        private Label lblProductName;
        private TextBox txtCount;
        private Label lblCount;
        private TextBox txtDiscount;
        private Label lblDiscount;
        private TextBox txtPrice;
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
    }
}