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

namespace MesajForm
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=ABDULLAH;Initial Catalog=DbMesajlaşma;Integrated Security=True;Encrypt=False;");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from TBL_KISILER WHERE NUMARA=@P1 AND SIFRE=@P2", conn);
            cmd.Parameters.AddWithValue("@P1", mskNumara.Text);
            cmd.Parameters.AddWithValue("@P2", txtSifre.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Form2 frm2 = new Form2();
                frm2.numara = mskNumara.Text;
                frm2.Show();
                
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız!");
            }
            conn.Close();
        }
    }
}
