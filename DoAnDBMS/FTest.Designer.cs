﻿namespace DoAnDBMS
{
    partial class FTest
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
            ucAddsp1 = new UCAddSP();
            SuspendLayout();
            // 
            // ucAddsp1
            // 
            ucAddsp1.BackColor = SystemColors.ControlLightLight;
            ucAddsp1.Location = new Point(-2, 0);
            ucAddsp1.Margin = new Padding(3, 4, 3, 4);
            ucAddsp1.Name = "ucAddsp1";
            ucAddsp1.Size = new Size(1186, 666);
            ucAddsp1.TabIndex = 0;
            // 
            // FTest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1183, 532);
            Controls.Add(ucAddsp1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FTest";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý sản phẩm";
            ResumeLayout(false);
        }

        #endregion

        private UCAddSP ucAddsp1;
    }
}