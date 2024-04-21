namespace DoAnDBMS
{
    partial class FChiPhi
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
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            lblChiPhi = new Label();
            label4 = new Label();
            btnConfirm = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cbbSelectionOption
            // 
            cbbSelectionOption.FormattingEnabled = true;
            cbbSelectionOption.Items.AddRange(new object[] { "Theo thang", "Theo nam" });
            cbbSelectionOption.Location = new Point(96, 25);
            cbbSelectionOption.Name = "cbbSelectionOption";
            cbbSelectionOption.Size = new Size(151, 28);
            cbbSelectionOption.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(201, 96);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(560, 99);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(130, 95);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 5;
            label2.Text = "Thang";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(513, 99);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 6;
            label3.Text = "Nam";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblChiPhi);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(271, 206);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 209);
            panel1.TabIndex = 7;
            // 
            // lblChiPhi
            // 
            lblChiPhi.AutoSize = true;
            lblChiPhi.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblChiPhi.Location = new Point(93, 105);
            lblChiPhi.Name = "lblChiPhi";
            lblChiPhi.Size = new Size(42, 25);
            lblChiPhi.TabIndex = 10;
            lblChiPhi.Text = "999";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(66, 15);
            label4.Name = "label4";
            label4.Size = new Size(103, 23);
            label4.TabIndex = 9;
            label4.Text = "Tong chi phi";
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.Violet;
            btnConfirm.Location = new Point(337, 154);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(112, 33);
            btnConfirm.TabIndex = 8;
            btnConfirm.Text = "Xac nhan";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // FChiPhi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConfirm);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(cbbSelectionOption);
            Name = "FChiPhi";
            Text = "FChiPhi";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbbSelectionOption;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Label lblChiPhi;
        private Label label4;
        private Button btnConfirm;
    }
}