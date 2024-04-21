namespace DoAnDBMS
{
    partial class FThemCaLam
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
            label1 = new Label();
            txtMaCa = new TextBox();
            btnConfirm = new Button();
            label2 = new Label();
            label3 = new Label();
            txtMaNV = new TextBox();
            dtpDayofWeek = new DateTimePicker();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(145, 63);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 0;
            label1.Text = "Ma ca lam";
            // 
            // txtMaCa
            // 
            txtMaCa.Location = new Point(271, 63);
            txtMaCa.Name = "txtMaCa";
            txtMaCa.Size = new Size(250, 27);
            txtMaCa.TabIndex = 1;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.Violet;
            btnConfirm.Location = new Point(145, 320);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(114, 45);
            btnConfirm.TabIndex = 2;
            btnConfirm.Text = "Thêm";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(145, 123);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 3;
            label2.Text = "Ma nhan vien";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(150, 198);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 4;
            label3.Text = "Ngay lam";
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(271, 123);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(250, 27);
            txtMaNV.TabIndex = 5;
            // 
            // dtpDayofWeek
            // 
            dtpDayofWeek.Location = new Point(271, 198);
            dtpDayofWeek.Name = "dtpDayofWeek";
            dtpDayofWeek.Size = new Size(250, 27);
            dtpDayofWeek.TabIndex = 6;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Violet;
            btnDelete.Location = new Point(443, 320);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(114, 45);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // FThemCaLam
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(dtpDayofWeek);
            Controls.Add(txtMaNV);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnConfirm);
            Controls.Add(txtMaCa);
            Controls.Add(label1);
            Name = "FThemCaLam";
            Text = "FThemCaLam";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMaCa;
        private Button btnConfirm;
        private Label label2;
        private Label label3;
        private TextBox txtMaNV;
        private DateTimePicker dtpDayofWeek;
        private Button btnDelete;
    }
}