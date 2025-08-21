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
using System.Reflection;

namespace MesajForm
{
    public partial class Form2: Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=ABDULLAH;Initial Catalog=DbMesajlaşma;Integrated Security=True;Encrypt=False;");
        public Form2()
        {
            InitializeComponent();
        }
        public string numara;
        
        void gelenKutusu()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT TBL_KISILER.AD,TBL_KISILER.SOYAD,TBL_MESAJLAR.BASLIK,TBL_MESAJLAR.ICERIK FROM TBL_MESAJLAR " +
                "INNER JOIN TBL_KISILER ON TBL_KISILER.NUMARA = TBL_MESAJLAR.ALICI WHERE ALICI=@P1", conn);
            cmd.Parameters.AddWithValue("@P1", numara);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            dataGridView1.DataSource = dt;
        }

        void gidenKutusu()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT TBL_KISILER.AD,TBL_KISILER.SOYAD,TBL_MESAJLAR.BASLIK,TBL_MESAJLAR.ICERIK FROM TBL_MESAJLAR " +
    "INNER JOIN TBL_KISILER ON TBL_KISILER.NUMARA = TBL_MESAJLAR.GÖNDEREN WHERE GÖNDEREN=@P1", conn);

            cmd.Parameters.AddWithValue("@P1", numara);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            conn.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            gelenKutusu();
            gidenKutusu();
            lblNo.Text = numara;

            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM TBL_MESAJLAR WHERE GÖNDEREN=@P1", conn);
            cmd.Parameters.AddWithValue("@P1", numara);
            conn.Close();

            lblAdSoyad.Text = numara;
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO TBL_MESAJLAR (GÖNDEREN, ALICI, BASLIK, ICERIK) VALUES (@P1, @P2, @P3,@P4)", conn);
            cmd.Parameters.AddWithValue("@P1", lblNo.Text);
            cmd.Parameters.AddWithValue("@P2", mskAlici.Text);
            cmd.Parameters.AddWithValue("@P3", txtKonu.Text);
            cmd.Parameters.AddWithValue("@P4", rchMesaj.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Mesajınız Gönderilmiştir.");
            gelenKutusu();
            gidenKutusu();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
