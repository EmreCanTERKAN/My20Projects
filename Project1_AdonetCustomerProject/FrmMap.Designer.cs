﻿namespace Project1_AdonetCustomerProject
{
    partial class FrmMap
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
            this.btnOpenCity = new System.Windows.Forms.Button();
            this.btnOpenCustomer = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenCity
            // 
            this.btnOpenCity.Location = new System.Drawing.Point(78, 36);
            this.btnOpenCity.Name = "btnOpenCity";
            this.btnOpenCity.Size = new System.Drawing.Size(180, 63);
            this.btnOpenCity.TabIndex = 0;
            this.btnOpenCity.Text = "Şehir İşlemleri";
            this.btnOpenCity.UseVisualStyleBackColor = true;
            this.btnOpenCity.Click += new System.EventHandler(this.btnOpenCity_Click);
            // 
            // btnOpenCustomer
            // 
            this.btnOpenCustomer.Location = new System.Drawing.Point(78, 121);
            this.btnOpenCustomer.Name = "btnOpenCustomer";
            this.btnOpenCustomer.Size = new System.Drawing.Size(180, 63);
            this.btnOpenCustomer.TabIndex = 1;
            this.btnOpenCustomer.Text = "Müşteri İşlemleri";
            this.btnOpenCustomer.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(78, 213);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(180, 63);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Çıkış Yap";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // FrmMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 348);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOpenCustomer);
            this.Controls.Add(this.btnOpenCity);
            this.Name = "FrmMap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formlar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenCity;
        private System.Windows.Forms.Button btnOpenCustomer;
        private System.Windows.Forms.Button btnExit;
    }
}