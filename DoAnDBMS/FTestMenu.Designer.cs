namespace DoAnDBMS
{
    partial class FTestMenu
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
            ucHomenv1 = new UCHomeNV();
            SuspendLayout();
            // 
            // ucHomenv1
            // 
            ucHomenv1.BackColor = Color.WhiteSmoke;
            ucHomenv1.Location = new Point(121, 0);
            ucHomenv1.Name = "ucHomenv1";
            ucHomenv1.Size = new Size(901, 769);
            ucHomenv1.TabIndex = 0;
            // 
            // FTestMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1023, 764);
            Controls.Add(ucHomenv1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FTestMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            ResumeLayout(false);
        }

        #endregion

        private UCHomeNV ucHomenv1;
    }
}