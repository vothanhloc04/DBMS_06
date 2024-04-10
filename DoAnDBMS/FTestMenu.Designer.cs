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
            menusp1 = new MenuSP();
            SuspendLayout();
            // 
            // menusp1
            // 
            menusp1.BackColor = Color.Firebrick;
            menusp1.Dock = DockStyle.Fill;
            menusp1.Location = new Point(0, 0);
            menusp1.Name = "menusp1";
            menusp1.Size = new Size(697, 614);
            menusp1.TabIndex = 0;
            // 
            // FTestMenucs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 614);
            Controls.Add(menusp1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FTestMenucs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            ResumeLayout(false);
        }

        #endregion

        private MenuSP menusp1;
    }
}