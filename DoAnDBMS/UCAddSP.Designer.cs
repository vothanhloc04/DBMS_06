namespace DoAnDBMS
{
    partial class UCAddSP
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCAddSP));
            tbTenSP = new TextBox();
            tbMaSP = new TextBox();
            tbDonGia = new TextBox();
            ccbTenNhomSP = new ComboBox();
            tbMaNhomSP = new TextBox();
            lblTenNhomSP = new Label();
            lblMaSP = new Label();
            lblTenSP = new Label();
            lblDonGia = new Label();
            lblTinhTrang = new Label();
            lblMaNhomSP = new Label();
            cbbTinhTrang = new ComboBox();
            pbImagePro = new PictureBox();
            lblImagePro = new Label();
            btnAdd = new NewButton();
            btnChange = new NewButton();
            btnDel = new NewButton();
            ((System.ComponentModel.ISupportInitialize)pbImagePro).BeginInit();
            SuspendLayout();
            // 
            // tbTenSP
            // 
            tbTenSP.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbTenSP.Location = new Point(436, 277);
            tbTenSP.Name = "tbTenSP";
            tbTenSP.Size = new Size(189, 27);
            tbTenSP.TabIndex = 0;
            // 
            // tbMaSP
            // 
            tbMaSP.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbMaSP.Location = new Point(436, 207);
            tbMaSP.Name = "tbMaSP";
            tbMaSP.Size = new Size(189, 27);
            tbMaSP.TabIndex = 1;
            // 
            // tbDonGia
            // 
            tbDonGia.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbDonGia.Location = new Point(436, 337);
            tbDonGia.Name = "tbDonGia";
            tbDonGia.Size = new Size(189, 27);
            tbDonGia.TabIndex = 2;
            // 
            // ccbTenNhomSP
            // 
            ccbTenNhomSP.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ccbTenNhomSP.FormattingEnabled = true;
            ccbTenNhomSP.Items.AddRange(new object[] { "Lẩu", "Mì", "Nước uống" });
            ccbTenNhomSP.Location = new Point(436, 66);
            ccbTenNhomSP.Name = "ccbTenNhomSP";
            ccbTenNhomSP.Size = new Size(189, 28);
            ccbTenNhomSP.TabIndex = 4;
            ccbTenNhomSP.SelectedIndexChanged += ccbTenNhomSP_SelectedIndexChanged;
            // 
            // tbMaNhomSP
            // 
            tbMaNhomSP.Enabled = false;
            tbMaNhomSP.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbMaNhomSP.Location = new Point(436, 132);
            tbMaNhomSP.Name = "tbMaNhomSP";
            tbMaNhomSP.Size = new Size(189, 27);
            tbMaNhomSP.TabIndex = 5;
            // 
            // lblTenNhomSP
            // 
            lblTenNhomSP.AutoSize = true;
            lblTenNhomSP.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTenNhomSP.Location = new Point(436, 48);
            lblTenNhomSP.Name = "lblTenNhomSP";
            lblTenNhomSP.Size = new Size(96, 15);
            lblTenNhomSP.TabIndex = 6;
            lblTenNhomSP.Text = "Nhóm sản phẩm";
            // 
            // lblMaSP
            // 
            lblMaSP.AutoSize = true;
            lblMaSP.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMaSP.Location = new Point(436, 189);
            lblMaSP.Name = "lblMaSP";
            lblMaSP.Size = new Size(79, 15);
            lblMaSP.TabIndex = 7;
            lblMaSP.Text = "Mã sản phẩm";
            // 
            // lblTenSP
            // 
            lblTenSP.AutoSize = true;
            lblTenSP.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTenSP.Location = new Point(434, 259);
            lblTenSP.Name = "lblTenSP";
            lblTenSP.Size = new Size(81, 15);
            lblTenSP.TabIndex = 8;
            lblTenSP.Text = "Tên sản phẩm";
            // 
            // lblDonGia
            // 
            lblDonGia.AutoSize = true;
            lblDonGia.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDonGia.Location = new Point(436, 319);
            lblDonGia.Name = "lblDonGia";
            lblDonGia.Size = new Size(49, 15);
            lblDonGia.TabIndex = 9;
            lblDonGia.Text = "Đơn giá";
            // 
            // lblTinhTrang
            // 
            lblTinhTrang.AutoSize = true;
            lblTinhTrang.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTinhTrang.Location = new Point(436, 387);
            lblTinhTrang.Name = "lblTinhTrang";
            lblTinhTrang.Size = new Size(62, 15);
            lblTinhTrang.TabIndex = 10;
            lblTinhTrang.Text = "Tình trạng";
            // 
            // lblMaNhomSP
            // 
            lblMaNhomSP.AutoSize = true;
            lblMaNhomSP.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMaNhomSP.Location = new Point(436, 114);
            lblMaNhomSP.Name = "lblMaNhomSP";
            lblMaNhomSP.Size = new Size(59, 15);
            lblMaNhomSP.TabIndex = 11;
            lblMaNhomSP.Text = "Mã nhóm";
            // 
            // cbbTinhTrang
            // 
            cbbTinhTrang.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbbTinhTrang.FormattingEnabled = true;
            cbbTinhTrang.Items.AddRange(new object[] { "Còn", "Hết" });
            cbbTinhTrang.Location = new Point(436, 405);
            cbbTinhTrang.Name = "cbbTinhTrang";
            cbbTinhTrang.Size = new Size(189, 28);
            cbbTinhTrang.TabIndex = 12;
            // 
            // pbImagePro
            // 
            pbImagePro.BackgroundImage = (Image)resources.GetObject("pbImagePro.BackgroundImage");
            pbImagePro.BackgroundImageLayout = ImageLayout.Stretch;
            pbImagePro.Location = new Point(58, 66);
            pbImagePro.Name = "pbImagePro";
            pbImagePro.Size = new Size(335, 367);
            pbImagePro.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImagePro.TabIndex = 13;
            pbImagePro.TabStop = false;
            pbImagePro.Click += pbImagePro_Click;
            // 
            // lblImagePro
            // 
            lblImagePro.AutoSize = true;
            lblImagePro.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblImagePro.Location = new Point(58, 48);
            lblImagePro.Name = "lblImagePro";
            lblImagePro.Size = new Size(84, 15);
            lblImagePro.TabIndex = 14;
            lblImagePro.Text = "Ảnh sản phẩm";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.MediumSeaGreen;
            btnAdd.BackgroundColor = Color.MediumSeaGreen;
            btnAdd.BorderColor = Color.PaleVioletRed;
            btnAdd.BorderRadius = 0;
            btnAdd.BorderSize = 0;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(117, 461);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 40);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Thêm ";
            btnAdd.TextColor = Color.White;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnChange
            // 
            btnChange.BackColor = Color.Gold;
            btnChange.BackgroundColor = Color.Gold;
            btnChange.BorderColor = Color.PaleVioletRed;
            btnChange.BorderRadius = 0;
            btnChange.BorderSize = 0;
            btnChange.FlatAppearance.BorderSize = 0;
            btnChange.FlatStyle = FlatStyle.Flat;
            btnChange.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnChange.ForeColor = Color.Black;
            btnChange.Location = new Point(290, 461);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(150, 40);
            btnChange.TabIndex = 16;
            btnChange.Text = "Sửa";
            btnChange.TextColor = Color.Black;
            btnChange.UseVisualStyleBackColor = false;
            btnChange.Click += btnChange_Click;
            // 
            // btnDel
            // 
            btnDel.BackColor = Color.OrangeRed;
            btnDel.BackgroundColor = Color.OrangeRed;
            btnDel.BorderColor = Color.PaleVioletRed;
            btnDel.BorderRadius = 0;
            btnDel.BorderSize = 0;
            btnDel.FlatAppearance.BorderSize = 0;
            btnDel.FlatStyle = FlatStyle.Flat;
            btnDel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDel.ForeColor = Color.White;
            btnDel.Location = new Point(466, 461);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(150, 40);
            btnDel.TabIndex = 17;
            btnDel.Text = "Xóa";
            btnDel.TextColor = Color.White;
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Click += btnDel_Click;
            // 
            // UCAddSP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(btnDel);
            Controls.Add(btnChange);
            Controls.Add(btnAdd);
            Controls.Add(lblImagePro);
            Controls.Add(pbImagePro);
            Controls.Add(cbbTinhTrang);
            Controls.Add(lblMaNhomSP);
            Controls.Add(lblTinhTrang);
            Controls.Add(lblDonGia);
            Controls.Add(lblTenSP);
            Controls.Add(lblMaSP);
            Controls.Add(lblTenNhomSP);
            Controls.Add(tbMaNhomSP);
            Controls.Add(ccbTenNhomSP);
            Controls.Add(tbDonGia);
            Controls.Add(tbMaSP);
            Controls.Add(tbTenSP);
            Name = "UCAddSP";
            Size = new Size(698, 528);
            ((System.ComponentModel.ISupportInitialize)pbImagePro).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbTenSP;
        private TextBox tbMaSP;
        private TextBox tbDonGia;
        private ComboBox ccbTenNhomSP;
        private TextBox tbMaNhomSP;
        private Label lblTenNhomSP;
        private Label lblMaSP;
        private Label lblTenSP;
        private Label lblDonGia;
        private Label lblTinhTrang;
        private Label lblMaNhomSP;
        private ComboBox cbbTinhTrang;
        private PictureBox pbImagePro;
        private Label lblImagePro;
        private NewButton btnAdd;
        private NewButton btnChange;
        private NewButton btnDel;
    }
}
