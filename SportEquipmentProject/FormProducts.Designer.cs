namespace SportEquipmentProject
{
    partial class FormProducts
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
            flowLayoutPanelTop = new FlowLayoutPanel();
            btnLogout = new Button();
            lblUsername = new Label();
            flowLayoutPanelTop.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanelTop
            // 
            flowLayoutPanelTop.Controls.Add(btnLogout);
            flowLayoutPanelTop.Controls.Add(lblUsername);
            flowLayoutPanelTop.Dock = DockStyle.Top;
            flowLayoutPanelTop.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanelTop.Location = new Point(14, 14);
            flowLayoutPanelTop.Margin = new Padding(4);
            flowLayoutPanelTop.Name = "flowLayoutPanelTop";
            flowLayoutPanelTop.Size = new Size(1156, 66);
            flowLayoutPanelTop.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(67, 97, 238);
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Location = new Point(1027, 3);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(126, 41);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "Выход";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += BtnLogout_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(970, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(51, 21);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "ФИО";
            // 
            // FormProducts
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(1184, 761);
            Controls.Add(flowLayoutPanelTop);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "FormProducts";
            Padding = new Padding(14);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Товары";
            flowLayoutPanelTop.ResumeLayout(false);
            flowLayoutPanelTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelTop;
        private Button btnLogout;
        private Label lblUsername;
    }
}