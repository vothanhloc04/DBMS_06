namespace DoAnDBMS
{
    partial class MenuSP
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
            flpMenu = new FlowLayoutPanel();
            btnAllPro = new NewButton();
            btnNoodles = new NewButton();
            btnHotpot = new NewButton();
            btnDinks = new NewButton();
            SuspendLayout();
            // 
            // flpMenu
            // 
            flpMenu.AutoScroll = true;
            flpMenu.BackColor = Color.Gainsboro;
            flpMenu.Location = new Point(170, 0);
            flpMenu.Name = "flpMenu";
            flpMenu.Size = new Size(529, 614);
            flpMenu.TabIndex = 0;
            // 
            // btnAllPro
            // 
            btnAllPro.BackColor = Color.Maroon;
            btnAllPro.BackgroundColor = Color.Maroon;
            btnAllPro.BorderColor = Color.PaleVioletRed;
            btnAllPro.BorderRadius = 0;
            btnAllPro.BorderSize = 0;
            btnAllPro.FlatAppearance.BorderSize = 0;
            btnAllPro.FlatStyle = FlatStyle.Flat;
            btnAllPro.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAllPro.ForeColor = Color.White;
            btnAllPro.Location = new Point(3, 66);
            btnAllPro.Name = "btnAllPro";
            btnAllPro.Size = new Size(164, 40);
            btnAllPro.TabIndex = 1;
            btnAllPro.Text = "Tất cả";
            btnAllPro.TextColor = Color.White;
            btnAllPro.UseVisualStyleBackColor = false;
            btnAllPro.Click += btnAllPro_Click;
            // 
            // btnNoodles
            // 
            btnNoodles.BackColor = Color.Firebrick;
            btnNoodles.BackgroundColor = Color.Firebrick;
            btnNoodles.BorderColor = Color.PaleVioletRed;
            btnNoodles.BorderRadius = 0;
            btnNoodles.BorderSize = 0;
            btnNoodles.FlatAppearance.BorderSize = 0;
            btnNoodles.FlatStyle = FlatStyle.Flat;
            btnNoodles.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnNoodles.ForeColor = Color.White;
            btnNoodles.Location = new Point(3, 112);
            btnNoodles.Name = "btnNoodles";
            btnNoodles.Size = new Size(164, 40);
            btnNoodles.TabIndex = 2;
            btnNoodles.Text = "Mì cay";
            btnNoodles.TextColor = Color.White;
            btnNoodles.UseVisualStyleBackColor = false;
            btnNoodles.Click += btnNoodles_Click;
            // 
            // btnHotpot
            // 
            btnHotpot.BackColor = Color.Firebrick;
            btnHotpot.BackgroundColor = Color.Firebrick;
            btnHotpot.BorderColor = Color.PaleVioletRed;
            btnHotpot.BorderRadius = 0;
            btnHotpot.BorderSize = 0;
            btnHotpot.FlatAppearance.BorderSize = 0;
            btnHotpot.FlatStyle = FlatStyle.Flat;
            btnHotpot.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnHotpot.ForeColor = Color.White;
            btnHotpot.Location = new Point(3, 158);
            btnHotpot.Name = "btnHotpot";
            btnHotpot.Size = new Size(164, 40);
            btnHotpot.TabIndex = 3;
            btnHotpot.Text = "Lẩu";
            btnHotpot.TextColor = Color.White;
            btnHotpot.UseVisualStyleBackColor = false;
            btnHotpot.Click += btnHotpot_Click;
            // 
            // btnDinks
            // 
            btnDinks.BackColor = Color.Firebrick;
            btnDinks.BackgroundColor = Color.Firebrick;
            btnDinks.BorderColor = Color.PaleVioletRed;
            btnDinks.BorderRadius = 0;
            btnDinks.BorderSize = 0;
            btnDinks.FlatAppearance.BorderSize = 0;
            btnDinks.FlatStyle = FlatStyle.Flat;
            btnDinks.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDinks.ForeColor = Color.White;
            btnDinks.Location = new Point(3, 204);
            btnDinks.Name = "btnDinks";
            btnDinks.Size = new Size(164, 40);
            btnDinks.TabIndex = 4;
            btnDinks.Text = "Đồ uống";
            btnDinks.TextColor = Color.White;
            btnDinks.UseVisualStyleBackColor = false;
            btnDinks.Click += btnDinks_Click;
            // 
            // MenuSP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Firebrick;
            Controls.Add(btnDinks);
            Controls.Add(btnHotpot);
            Controls.Add(btnNoodles);
            Controls.Add(btnAllPro);
            Controls.Add(flpMenu);
            Name = "MenuSP";
            Size = new Size(698, 614);
            Load += MenuSP_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpMenu;
        private NewButton btnAllPro;
        private NewButton btnNoodles;
        private NewButton btnHotpot;
        private NewButton btnDinks;
    }
}
