using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data.Sql;
namespace _54Computer
{
    public partial class Login : Form
    {
        SqlConnection connect = new SqlConnection("Data Source=RIKU;Initial Catalog=54Computer;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework;");

        public bool login(string username, string password)
        {
            connect.Open();
            SqlCommand com = new SqlCommand("Select * from Calisan Where KullaniciAdi=@usr and Sifre=@pass", connect);
            com.Parameters.AddWithValue("@usr", username);
            com.Parameters.AddWithValue("@pass", password);
            SqlDataReader oku = com.ExecuteReader();
            if (oku.Read())
            {
                connect.Close();
                return true;
            }
            else
            {
                connect.Close();
                return false;
            }
        }
        public Login()
        {

            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool giris = login(textBox1.Text, textBox2.Text);
            if (giris==true)
            {
                MessageBox.Show("Başarıyla Giriş Yaptınız !");
                this.Hide();
                new Main_Menu().Show();
            }
            else
            {
                MessageBox.Show("Bilgileriniz Hatalı Lütfen Tekrar Deneyiniz. ");
            }

        }
    }
}


    

