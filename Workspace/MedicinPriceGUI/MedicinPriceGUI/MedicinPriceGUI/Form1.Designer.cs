﻿namespace MedicinPriceGUI
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ReadDataButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.updateFiles = new System.Windows.Forms.Button();
            this.toCSV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "\r\n";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Newest ZIP file:";
            // 
            // ReadDataButton
            // 
            this.ReadDataButton.Location = new System.Drawing.Point(147, 74);
            this.ReadDataButton.Name = "ReadDataButton";
            this.ReadDataButton.Size = new System.Drawing.Size(125, 23);
            this.ReadDataButton.TabIndex = 3;
            this.ReadDataButton.Text = "Read files";
            this.ReadDataButton.UseVisualStyleBackColor = true;
            this.ReadDataButton.Click += new System.EventHandler(this.ReadDataButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 114);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(259, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(217, 36);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(55, 23);
            this.BrowseButton.TabIndex = 5;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // updateFiles
            // 
            this.updateFiles.Location = new System.Drawing.Point(13, 74);
            this.updateFiles.Name = "updateFiles";
            this.updateFiles.Size = new System.Drawing.Size(125, 23);
            this.updateFiles.TabIndex = 6;
            this.updateFiles.Text = "Update files";
            this.updateFiles.UseVisualStyleBackColor = true;
            // 
            // toCSV
            // 
            this.toCSV.Location = new System.Drawing.Point(196, 174);
            this.toCSV.Name = "toCSV";
            this.toCSV.Size = new System.Drawing.Size(75, 23);
            this.toCSV.TabIndex = 7;
            this.toCSV.Text = "CSV";
            this.toCSV.UseVisualStyleBackColor = true;
            this.toCSV.Click += new System.EventHandler(this.toCSV_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.toCSV);
            this.Controls.Add(this.updateFiles);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.ReadDataButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ReadDataButton;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Button updateFiles;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button toCSV;



    }
}

