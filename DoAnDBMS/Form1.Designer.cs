namespace DoAnDBMS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            btnViewNV = new Button();
            btnViewPhanCong = new Button();
            btnHoaDonUD = new Button();
            btnViewCLV = new Button();
            btnViewPC = new Button();
            btnViewSP = new Button();
            btnViewHoaDon = new Button();
            btnViewNSX = new Button();
            btnTimNL = new Button();
            btnTimSP = new Button();
            btnProduct = new NewButton();
            btnMenu = new NewButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(909, 215);
            dataGridView1.TabIndex = 2;
            // 
            // btnViewNV
            // 
            btnViewNV.Location = new Point(29, 248);
            btnViewNV.Name = "btnViewNV";
            btnViewNV.Size = new Size(97, 23);
            btnViewNV.TabIndex = 3;
            btnViewNV.Text = "dmNhanVien";
            btnViewNV.UseVisualStyleBackColor = true;
            btnViewNV.Click += btnViewNV_Click;
            // 
            // btnViewPhanCong
            // 
            btnViewPhanCong.Location = new Point(29, 280);
            btnViewPhanCong.Name = "btnViewPhanCong";
            btnViewPhanCong.Size = new Size(97, 23);
            btnViewPhanCong.TabIndex = 4;
            btnViewPhanCong.Text = "dmPhanCong";
            btnViewPhanCong.UseVisualStyleBackColor = true;
            btnViewPhanCong.Click += btnViewPhanCong_Click;
            // 
            // btnHoaDonUD
            // 
            btnHoaDonUD.Location = new Point(158, 318);
            btnHoaDonUD.Name = "btnHoaDonUD";
            btnHoaDonUD.Size = new Size(97, 23);
            btnHoaDonUD.TabIndex = 5;
            btnHoaDonUD.Text = "dmHoaDonUD";
            btnHoaDonUD.UseVisualStyleBackColor = true;
            btnHoaDonUD.Click += btnHoaDonUD_Click;
            // 
            // btnViewCLV
            // 
            btnViewCLV.Location = new Point(29, 318);
            btnViewCLV.Name = "btnViewCLV";
            btnViewCLV.Size = new Size(97, 23);
            btnViewCLV.TabIndex = 6;
            btnViewCLV.Text = "dmCaLamViec";
            btnViewCLV.UseVisualStyleBackColor = true;
            btnViewCLV.Click += btnViewCLV_Click;
            // 
            // btnViewPC
            // 
            btnViewPC.Location = new Point(158, 248);
            btnViewPC.Name = "btnViewPC";
            btnViewPC.Size = new Size(97, 23);
            btnViewPC.TabIndex = 7;
            btnViewPC.Text = "dmPhieuChi";
            btnViewPC.UseVisualStyleBackColor = true;
            btnViewPC.Click += btnViewPC_Click;
            // 
            // btnViewSP
            // 
            btnViewSP.Location = new Point(29, 360);
            btnViewSP.Name = "btnViewSP";
            btnViewSP.Size = new Size(97, 23);
            btnViewSP.TabIndex = 8;
            btnViewSP.Text = "dmSP";
            btnViewSP.UseVisualStyleBackColor = true;
            btnViewSP.Click += btnViewSP_Click;
            // 
            // btnViewHoaDon
            // 
            btnViewHoaDon.Location = new Point(158, 282);
            btnViewHoaDon.Name = "btnViewHoaDon";
            btnViewHoaDon.Size = new Size(97, 23);
            btnViewHoaDon.TabIndex = 9;
            btnViewHoaDon.Text = "dmHoaDon";
            btnViewHoaDon.UseVisualStyleBackColor = true;
            btnViewHoaDon.Click += btnViewHoaDon_Click;
            // 
            // btnViewNSX
            // 
            btnViewNSX.Location = new Point(29, 399);
            btnViewNSX.Name = "btnViewNSX";
            btnViewNSX.Size = new Size(97, 23);
            btnViewNSX.TabIndex = 10;
            btnViewNSX.Text = "dmNSX";
            btnViewNSX.UseVisualStyleBackColor = true;
            btnViewNSX.Click += btnViewNSX_Click;
            // 
            // btnTimNL
            // 
            btnTimNL.Location = new Point(158, 360);
            btnTimNL.Name = "btnTimNL";
            btnTimNL.Size = new Size(97, 23);
            btnTimNL.TabIndex = 11;
            btnTimNL.Text = "timNL";
            btnTimNL.UseVisualStyleBackColor = true;
            btnTimNL.Click += btnTimNL_Click;
            // 
            // btnTimSP
            // 
            btnTimSP.Location = new Point(158, 399);
            btnTimSP.Name = "btnTimSP";
            btnTimSP.Size = new Size(97, 23);
            btnTimSP.TabIndex = 12;
            btnTimSP.Text = "timSP";
            btnTimSP.UseVisualStyleBackColor = true;
            btnTimSP.Click += btnTimSP_Click;
            // 
            // btnProduct
            // 
            btnProduct.BackColor = Color.MediumSlateBlue;
            btnProduct.BackgroundColor = Color.MediumSlateBlue;
            btnProduct.BorderColor = Color.PaleVioletRed;
            btnProduct.BorderRadius = 0;
            btnProduct.BorderSize = 0;
            btnProduct.FlatAppearance.BorderSize = 0;
            btnProduct.FlatStyle = FlatStyle.Flat;
            btnProduct.ForeColor = Color.White;
            btnProduct.Location = new Point(391, 301);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(150, 40);
            btnProduct.TabIndex = 13;
            btnProduct.Text = "Quản lý sản phẩm";
            btnProduct.TextColor = Color.White;
            btnProduct.UseVisualStyleBackColor = false;
            btnProduct.Click += btnProduct_Click;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.MediumSlateBlue;
            btnMenu.BackgroundColor = Color.MediumSlateBlue;
            btnMenu.BorderColor = Color.PaleVioletRed;
            btnMenu.BorderRadius = 0;
            btnMenu.BorderSize = 0;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.ForeColor = Color.White;
            btnMenu.Location = new Point(391, 248);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(150, 40);
            btnMenu.TabIndex = 14;
            btnMenu.Text = "Menu";
            btnMenu.TextColor = Color.White;
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(btnMenu);
            Controls.Add(btnProduct);
            Controls.Add(btnTimSP);
            Controls.Add(btnTimNL);
            Controls.Add(btnViewNSX);
            Controls.Add(btnViewHoaDon);
            Controls.Add(btnViewSP);
            Controls.Add(btnViewPC);
            Controls.Add(btnViewCLV);
            Controls.Add(btnHoaDonUD);
            Controls.Add(btnViewPhanCong);
            Controls.Add(btnViewNV);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnOpenConn;
        private Button btnCloseConn;
        private DataGridView dataGridView1;
        private Button btnViewNV;
        private Button btnViewPhanCong;
        private Button btnHoaDonUD;
        private Button btnViewCLV;
        private Button btnViewPC;
        private Button btnViewSP;
        private Button btnViewHoaDon;
        private Button btnViewNSX;
        private Button btnTimNL;
        private Button btnTimSP;
        private NewButton btnProduct;
        private NewButton btnMenu;
    }
}
