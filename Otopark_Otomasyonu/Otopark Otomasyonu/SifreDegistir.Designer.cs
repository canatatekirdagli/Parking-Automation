﻿namespace Otopark_Otomasyonu
{
    partial class SifreDegistir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SifreDegistir));
            this.geri_don = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.yeni_sifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.kullanici_adi = new System.Windows.Forms.ComboBox();
            this.sifre_degistir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // geri_don
            // 
            this.geri_don.BackColor = System.Drawing.Color.Navy;
            this.geri_don.Font = new System.Drawing.Font("Cascadia Mono", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.geri_don.ForeColor = System.Drawing.SystemColors.Control;
            this.geri_don.Location = new System.Drawing.Point(1044, 472);
            this.geri_don.Name = "geri_don";
            this.geri_don.Size = new System.Drawing.Size(213, 69);
            this.geri_don.TabIndex = 4;
            this.geri_don.Text = "Geri Dön";
            this.geri_don.UseVisualStyleBackColor = false;
            this.geri_don.Click += new System.EventHandler(this.button8_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Navy;
            this.groupBox1.Controls.Add(this.yeni_sifre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.kullanici_adi);
            this.groupBox1.Controls.Add(this.sifre_degistir);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Cascadia Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(375, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(617, 350);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Şifre Değiştir";
            // 
            // yeni_sifre
            // 
            this.yeni_sifre.Font = new System.Drawing.Font("Cascadia Mono", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yeni_sifre.Location = new System.Drawing.Point(322, 138);
            this.yeni_sifre.Name = "yeni_sifre";
            this.yeni_sifre.Size = new System.Drawing.Size(212, 34);
            this.yeni_sifre.TabIndex = 2;
            this.yeni_sifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yeni_sifre_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Mono", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(113, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 30);
            this.label3.TabIndex = 17;
            this.label3.Text = "Yeni Şifre :";
            // 
            // kullanici_adi
            // 
            this.kullanici_adi.Font = new System.Drawing.Font("Cascadia Mono", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullanici_adi.FormattingEnabled = true;
            this.kullanici_adi.Location = new System.Drawing.Point(322, 76);
            this.kullanici_adi.Name = "kullanici_adi";
            this.kullanici_adi.Size = new System.Drawing.Size(212, 38);
            this.kullanici_adi.TabIndex = 0;
            // 
            // sifre_degistir
            // 
            this.sifre_degistir.BackColor = System.Drawing.Color.Navy;
            this.sifre_degistir.Font = new System.Drawing.Font("Cascadia Mono", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifre_degistir.ForeColor = System.Drawing.SystemColors.Control;
            this.sifre_degistir.Location = new System.Drawing.Point(322, 193);
            this.sifre_degistir.Name = "sifre_degistir";
            this.sifre_degistir.Size = new System.Drawing.Size(212, 73);
            this.sifre_degistir.TabIndex = 3;
            this.sifre_degistir.Text = "Şifre Değiştir";
            this.sifre_degistir.UseVisualStyleBackColor = false;
            this.sifre_degistir.Click += new System.EventHandler(this.button10_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(74, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // SifreDegistir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1323, 600);
            this.ControlBox = false;
            this.Controls.Add(this.geri_don);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "SifreDegistir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ŞİFRE DEĞİŞTİR";
            this.Load += new System.EventHandler(this.SifreDegistir_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button geri_don;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox kullanici_adi;
        private System.Windows.Forms.Button sifre_degistir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox yeni_sifre;
    }
}