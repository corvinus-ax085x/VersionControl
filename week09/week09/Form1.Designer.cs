﻿
namespace week09
{
    partial class Form1
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
            this.nudyear = new System.Windows.Forms.NumericUpDown();
            this.txtpath = new System.Windows.Forms.TextBox();
            this.buttonbrowse = new System.Windows.Forms.Button();
            this.buttonstart = new System.Windows.Forms.Button();
            this.txtmain = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudyear)).BeginInit();
            this.SuspendLayout();
            // 
            // nudyear
            // 
            this.nudyear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nudyear.Location = new System.Drawing.Point(12, 12);
            this.nudyear.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudyear.Minimum = new decimal(new int[] {
            2005,
            0,
            0,
            0});
            this.nudyear.Name = "nudyear";
            this.nudyear.Size = new System.Drawing.Size(120, 30);
            this.nudyear.TabIndex = 0;
            this.nudyear.Value = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            // 
            // txtpath
            // 
            this.txtpath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtpath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtpath.Location = new System.Drawing.Point(139, 12);
            this.txtpath.Name = "txtpath";
            this.txtpath.Size = new System.Drawing.Size(712, 30);
            this.txtpath.TabIndex = 1;
            this.txtpath.Text = "C:\\TempQnép-teszt.csv";
            // 
            // buttonbrowse
            // 
            this.buttonbrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonbrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonbrowse.Location = new System.Drawing.Point(857, 12);
            this.buttonbrowse.Name = "buttonbrowse";
            this.buttonbrowse.Size = new System.Drawing.Size(117, 30);
            this.buttonbrowse.TabIndex = 2;
            this.buttonbrowse.Text = "Browse";
            this.buttonbrowse.UseVisualStyleBackColor = true;
            this.buttonbrowse.Click += new System.EventHandler(this.buttonbrowse_Click);
            // 
            // buttonstart
            // 
            this.buttonstart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonstart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonstart.Location = new System.Drawing.Point(980, 12);
            this.buttonstart.Name = "buttonstart";
            this.buttonstart.Size = new System.Drawing.Size(110, 32);
            this.buttonstart.TabIndex = 3;
            this.buttonstart.Text = "Start";
            this.buttonstart.UseVisualStyleBackColor = true;
            this.buttonstart.Click += new System.EventHandler(this.buttonstart_Click);
            // 
            // txtmain
            // 
            this.txtmain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtmain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtmain.Location = new System.Drawing.Point(12, 80);
            this.txtmain.Name = "txtmain";
            this.txtmain.Size = new System.Drawing.Size(1124, 532);
            this.txtmain.TabIndex = 4;
            this.txtmain.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 624);
            this.Controls.Add(this.txtmain);
            this.Controls.Add(this.buttonstart);
            this.Controls.Add(this.buttonbrowse);
            this.Controls.Add(this.txtpath);
            this.Controls.Add(this.nudyear);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudyear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudyear;
        private System.Windows.Forms.TextBox txtpath;
        private System.Windows.Forms.Button buttonbrowse;
        private System.Windows.Forms.Button buttonstart;
        private System.Windows.Forms.RichTextBox txtmain;
    }
}

