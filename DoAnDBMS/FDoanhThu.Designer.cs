namespace DoAnDBMS
{
    partial class FDoanhThu
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
            cbbSelectionOption = new ComboBox();
            textBox1 = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            lblProfit = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            btnConfirmDate = new Button();
            label2 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cbbSelectionOption
            // 
            cbbSelectionOption.FormattingEnabled = true;
            cbbSelectionOption.Items.AddRange(new object[] { "Theo ngay", "Theo thang", "Theo nam" });
            cbbSelectionOption.Location = new Point(112, 28);
            cbbSelectionOption.Name = "cbbSelectionOption";
            cbbSelectionOption.Size = new Size(151, 28);
            cbbSelectionOption.TabIndex = 0;
            cbbSelectionOption.Text = "Tinh theo ......";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(138, 96);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(73, 99);
            label1.Name = "label1";
            label1.Size = new Size(50, 23);
            label1.TabIndex = 2;
            label1.Text = "Ngay";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblProfit);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(302, 280);
            panel1.Name = "panel1";
            panel1.Size = new Size(225, 206);
            panel1.TabIndex = 3;
            // 
            // lblProfit
            // 
            lblProfit.AutoSize = true;
            lblProfit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblProfit.Location = new Point(89, 95);
            lblProfit.Name = "lblProfit";
            lblProfit.Size = new Size(45, 28);
            lblProfit.TabIndex = 10;
            lblProfit.Text = "999";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(63, 23);
            label4.Name = "label4";
            label4.Size = new Size(99, 25);
            label4.TabIndex = 9;
            label4.Text = "Doanh Thu";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(402, 96);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(684, 95);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 5;
            // 
            // btnConfirmDate
            // 
            btnConfirmDate.BackColor = Color.Violet;
            btnConfirmDate.Location = new Point(361, 177);
            btnConfirmDate.Name = "btnConfirmDate";
            btnConfirmDate.Size = new Size(128, 42);
            btnConfirmDate.TabIndex = 6;
            btnConfirmDate.Text = "Xac nhan";
            btnConfirmDate.UseVisualStyleBackColor = false;
            btnConfirmDate.Click += btnConfirmDate_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(335, 97);
            label2.Name = "label2";
            label2.Size = new Size(58, 23);
            label2.TabIndex = 7;
            label2.Text = "Thang";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(626, 99);
            label3.Name = "label3";
            label3.Size = new Size(47, 23);
            label3.TabIndex = 8;
            label3.Text = "Nam";
            // 
            // FDoanhThu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 551);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnConfirmDate);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(cbbSelectionOption);
            Name = "FDoanhThu";
            Text = "FDoanhThu";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbbSelectionOption;
        private TextBox textBox1;
        private Label label1;
        private Panel panel1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button btnConfirmDate;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblProfit;
    }
}