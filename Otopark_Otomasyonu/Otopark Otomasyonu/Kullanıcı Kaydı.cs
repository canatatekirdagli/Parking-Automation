﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otopark_Otomasyonu
{
    public partial class Kullanıcı_Kaydı : Form
    {
        

        public Kullanıcı_Kaydı()
        {
            InitializeComponent();
        }
      

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            DatabaseConnection connection = new DatabaseConnection();
            
            try
            {
                if (plaka.Text==""|| renk.Text == "" || park_yeri.Text == "" || marka.Text == "" || tc.Text == "" ||
                    ad.Text == "" || soyad.Text == "" || telefon.Text == "" || email.Text == "")
                {
                    MessageBox.Show("Lütfen boş kısımları doldurunuz!!");
                }else if (tc.TextLength < 11|| tc.TextLength>11)
                {
                    MessageBox.Show("Lütfen TC Kimlik numaranızı 11 haneli olarak giriniz!!");
                }else if (telefon.TextLength < 10||telefon.TextLength>10)
                {
                    MessageBox.Show("Lütfen telefon numaranızı başında 0 olmadan 10 haneli olarak giriniz.");
                }
                else
                {
                    connection.SqlProcess("insert into araba(plaka,renk,park_yeri,marka,giris_saati) values ('" + plaka.Text + "','" + renk.Text + "','" + park_yeri.Text + "'," +
    "'" + marka.Text.ToString() + "','" + DateTime.Now.ToString() + "')");
                    connection.SqlProcess("insert into musteri(tc_kimlik_no,ad,soyad,telefon,email,plaka) values ('" + tc.Text + "','" + ad.Text + "','" + soyad.Text + "'," +
        "'" + telefon.Text.ToString() + "','" + email.Text + "','" + plaka.Text + "')");
                    connection.SqlProcess(("update otopark set otopark_durumu='true' where park_yeri='" + park_yeri.Text + "'"));
                    MessageBox.Show("Müşteri Kayıt İşlemi Gerçekleşti.");

                    OtoparkDurumu otoparkDurumu = new OtoparkDurumu();
                    otoparkDurumu.Show();
                    Hide();
                }
                
            }
            catch (Exception hata)
            {

                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            Hide();
        }
       
        private void Kullanıcı_Kaydı_Load(object sender, EventArgs e)
        {
            DatabaseConnection connection = new DatabaseConnection();
            SqlDataReader reader = connection.DataReader(string.Format("SELECT * FROM otopark",connection));
            while (reader.Read())
            {
                if ((bool)reader["otopark_durumu"]==false)
                {
                    park_yeri.Items.Add(reader["park_yeri"]);
                }
            }
            connection.CloseConnection();
            SqlDataReader reader1 = connection.DataReader(string.Format("SELECT * FROM marka", connection));
            while (reader1.Read())
            {
                marka.Items.Add(reader1["marka"]);
            }
            connection.CloseConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatabaseConnection connection = new DatabaseConnection();
            if (marka.Text == "")
            {
                MessageBox.Show("Lütfen markayı giriniz!!");
            }
            else
            {
                connection.SqlProcess("insert into marka(marka) values ('" + marka.Text.ToString() + "')");
                MessageBox.Show("Marka eklendi!!");
                marka.Items.Add(marka.Text.ToString());
            }
        }

        private void marka_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tc_TextChanged(object sender, EventArgs e)
        {

        }

        private void tc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void telefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void ad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void soyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void marka_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void renk_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }
    }
    
}
