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
            btnSearchInvoice = new Button();
            dateTimePicker1 = new DateTimePicker();
            txtTableID = new TextBox();
            txtProdID = new TextBox();
            label1 = new Label();
            lblQuantity = new Label();
            btnPlus = new Button();
            btnMinus = new Button();
            btnAddProd = new Button();
            btnExportInvoice = new Button();
            button1 = new Button();
            btnExptAppInvoice = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 16);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1039, 287);
            dataGridView1.TabIndex = 2;
            // 
            // btnViewNV
            // 
            btnViewNV.Location = new Point(33, 331);
            btnViewNV.Margin = new Padding(3, 4, 3, 4);
            btnViewNV.Name = "btnViewNV";
            btnViewNV.Size = new Size(111, 31);
            btnViewNV.TabIndex = 3;
            btnViewNV.Text = "dmNhanVien";
            btnViewNV.UseVisualStyleBackColor = true;
            btnViewNV.Click += btnViewNV_Click;
            // 
            // btnViewPhanCong
            // 
            btnViewPhanCong.Location = new Point(33, 373);
            btnViewPhanCong.Margin = new Padding(3, 4, 3, 4);
            btnViewPhanCong.Name = "btnViewPhanCong";
            btnViewPhanCong.Size = new Size(111, 31);
            btnViewPhanCong.TabIndex = 4;
            btnViewPhanCong.Text = "dmPhanCong";
            btnViewPhanCong.UseVisualStyleBackColor = true;
            btnViewPhanCong.Click += btnViewPhanCong_Click;
            // 
            // btnHoaDonUD
            // 
            btnHoaDonUD.Location = new Point(181, 424);
            btnHoaDonUD.Margin = new Padding(3, 4, 3, 4);
            btnHoaDonUD.Name = "btnHoaDonUD";
            btnHoaDonUD.Size = new Size(111, 31);
            btnHoaDonUD.TabIndex = 5;
            btnHoaDonUD.Text = "dmHoaDonUD";
            btnHoaDonUD.UseVisualStyleBackColor = true;
            btnHoaDonUD.Click += btnHoaDonUD_Click;
            // 
            // btnViewCLV
            // 
            btnViewCLV.Location = new Point(33, 424);
            btnViewCLV.Margin = new Padding(3, 4, 3, 4);
            btnViewCLV.Name = "btnViewCLV";
            btnViewCLV.Size = new Size(111, 31);
            btnViewCLV.TabIndex = 6;
            btnViewCLV.Text = "dmCaLamViec";
            btnViewCLV.UseVisualStyleBackColor = true;
            btnViewCLV.Click += btnViewCLV_Click;
            // 
            // btnViewPC
            // 
            btnViewPC.Location = new Point(181, 331);
            btnViewPC.Margin = new Padding(3, 4, 3, 4);
            btnViewPC.Name = "btnViewPC";
            btnViewPC.Size = new Size(111, 31);
            btnViewPC.TabIndex = 7;
            btnViewPC.Text = "dmPhieuChi";
            btnViewPC.UseVisualStyleBackColor = true;
            btnViewPC.Click += btnViewPC_Click;
            // 
            // btnViewSP
            // 
            btnViewSP.Location = new Point(33, 480);
            btnViewSP.Margin = new Padding(3, 4, 3, 4);
            btnViewSP.Name = "btnViewSP";
            btnViewSP.Size = new Size(111, 31);
            btnViewSP.TabIndex = 8;
            btnViewSP.Text = "dmSP";
            btnViewSP.UseVisualStyleBackColor = true;
            btnViewSP.Click += btnViewSP_Click;
            // 
            // btnViewHoaDon
            // 
            btnViewHoaDon.Location = new Point(181, 376);
            btnViewHoaDon.Margin = new Padding(3, 4, 3, 4);
            btnViewHoaDon.Name = "btnViewHoaDon";
            btnViewHoaDon.Size = new Size(111, 31);
            btnViewHoaDon.TabIndex = 9;
            btnViewHoaDon.Text = "dmHoaDon";
            btnViewHoaDon.UseVisualStyleBackColor = true;
            btnViewHoaDon.Click += btnViewHoaDon_Click;
            // 
            // btnViewNSX
            // 
            btnViewNSX.Location = new Point(33, 532);
            btnViewNSX.Margin = new Padding(3, 4, 3, 4);
            btnViewNSX.Name = "btnViewNSX";
            btnViewNSX.Size = new Size(111, 31);
            btnViewNSX.TabIndex = 10;
            btnViewNSX.Text = "dmNSX";
            btnViewNSX.UseVisualStyleBackColor = true;
            btnViewNSX.Click += btnViewNSX_Click;
            // 
            // btnTimNL
            // 
            btnTimNL.Location = new Point(181, 480);
            btnTimNL.Margin = new Padding(3, 4, 3, 4);
            btnTimNL.Name = "btnTimNL";
            btnTimNL.Size = new Size(111, 31);
            btnTimNL.TabIndex = 11;
            btnTimNL.Text = "timNL";
            btnTimNL.UseVisualStyleBackColor = true;
            btnTimNL.Click += btnTimNL_Click;
            // 
            // btnTimSP
            // 
            btnTimSP.Location = new Point(181, 532);
            btnTimSP.Margin = new Padding(3, 4, 3, 4);
            btnTimSP.Name = "btnTimSP";
            btnTimSP.Size = new Size(111, 31);
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
            btnProduct.Location = new Point(447, 401);
            btnProduct.Margin = new Padding(3, 4, 3, 4);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(171, 53);
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
            btnMenu.Location = new Point(447, 331);
            btnMenu.Margin = new Padding(3, 4, 3, 4);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(171, 53);
            btnMenu.TabIndex = 14;
            btnMenu.Text = "Menu";
            btnMenu.TextColor = Color.White;
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnSearchInvoice
            // 
            btnSearchInvoice.Location = new Point(33, 584);
            btnSearchInvoice.Name = "btnSearchInvoice";
            btnSearchInvoice.Size = new Size(111, 29);
            btnSearchInvoice.TabIndex = 15;
            btnSearchInvoice.Text = "TimHD";
            btnSearchInvoice.UseVisualStyleBackColor = true;
            btnSearchInvoice.Click += btnSearchInvoice_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(698, 331);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 16;
            // 
            // txtTableID
            // 
            txtTableID.Location = new Point(698, 379);
            txtTableID.Name = "txtTableID";
            txtTableID.Size = new Size(250, 27);
            txtTableID.TabIndex = 17;
            txtTableID.Text = "TableID";
            // 
            // txtProdID
            // 
            txtProdID.Location = new Point(698, 427);
            txtProdID.Name = "txtProdID";
            txtProdID.Size = new Size(250, 27);
            txtProdID.TabIndex = 18;
            txtProdID.Text = "ProdID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(698, 480);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 19;
            label1.Text = "Số lượng: ";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(766, 480);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(17, 20);
            lblQuantity.TabIndex = 20;
            lblQuantity.Text = "1";
            // 
            // btnPlus
            // 
            btnPlus.Location = new Point(780, 476);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(39, 29);
            btnPlus.TabIndex = 21;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnMinus
            // 
            btnMinus.Location = new Point(825, 476);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(39, 29);
            btnMinus.TabIndex = 22;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnAddProd
            // 
            btnAddProd.Location = new Point(310, 333);
            btnAddProd.Name = "btnAddProd";
            btnAddProd.Size = new Size(109, 29);
            btnAddProd.TabIndex = 23;
            btnAddProd.Text = "ThemMon";
            btnAddProd.UseVisualStyleBackColor = true;
            btnAddProd.Click += btnAddProd_Click;
            // 
            // btnExportInvoice
            // 
            btnExportInvoice.Location = new Point(182, 589);
            btnExportInvoice.Name = "btnExportInvoice";
            btnExportInvoice.Size = new Size(110, 29);
            btnExportInvoice.TabIndex = 24;
            btnExportInvoice.Text = "XuatHD";
            btnExportInvoice.UseVisualStyleBackColor = true;
            btnExportInvoice.Click += btnExportInvoice_Click;
            // 
            // button1
            // 
            button1.Location = new Point(392, 516);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 25;
            button1.Text = "App Prod";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // btnExptAppInvoice
            // 
            btnExptAppInvoice.Location = new Point(310, 376);
            btnExptAppInvoice.Name = "btnExptAppInvoice";
            btnExptAppInvoice.Size = new Size(109, 29);
            btnExptAppInvoice.TabIndex = 26;
            btnExptAppInvoice.Text = "XuatHDUD";
            btnExptAppInvoice.UseVisualStyleBackColor = true;
            btnExptAppInvoice.Click += btnExptAppInvoice_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 692);
            Controls.Add(btnExptAppInvoice);
            Controls.Add(button1);
            Controls.Add(btnExportInvoice);
            Controls.Add(btnAddProd);
            Controls.Add(btnMinus);
            Controls.Add(btnPlus);
            Controls.Add(lblQuantity);
            Controls.Add(label1);
            Controls.Add(txtProdID);
            Controls.Add(txtTableID);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnSearchInvoice);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Button btnSearchInvoice;
        private DateTimePicker dateTimePicker1;
        private TextBox txtTableID;
        private TextBox txtProdID;
        private Label label1;
        private Label lblQuantity;
        private Button btnPlus;
        private Button btnMinus;
        private Button btnAddProd;
        private Button btnExportInvoice;
        private Button button1;
        private Button btnExptAppInvoice;
    }
}
