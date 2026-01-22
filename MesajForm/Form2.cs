using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MesajForm
{
    public partial class Form2 : Form
    {
        // Database connection for messaging system
        SqlConnection conn = new SqlConnection(@"Data Source=ABDULLAH;Initial Catalog=DbMesajlaşma;Integrated Security=True;Encrypt=False;");

        public Form2()
        {
            InitializeComponent();
        }

        public string numara; // User number/ID passed from login form

        // Load inbox messages for current user
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
            dataGridView1.DataSource = dt; // Bind to inbox DataGridView
        }

        // Load sent messages for current user
        void gidenKutusu()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT TBL_KISILER.AD,TBL_KISILER.SOYAD,TBL_MESAJLAR.BASLIK,TBL_MESAJLAR.ICERIK FROM TBL_MESAJLAR " +
    "INNER JOIN TBL_KISILER ON TBL_KISILER.NUMARA = TBL_MESAJLAR.GÖNDEREN WHERE GÖNDEREN=@P1", conn);

            cmd.Parameters.AddWithValue("@P1", numara);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt; // Bind to sent items DataGridView
            conn.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Load both inbox and sent messages on form load
            gelenKutusu();
            gidenKutusu();

            // Display user number
            lblNo.Text = numara;

            // Query sent messages (currently unused variable)
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM TBL_MESAJLAR WHERE GÖNDEREN=@P1", conn);
            cmd.Parameters.AddWithValue("@P1", numara);
            conn.Close();

            lblAdSoyad.Text = numara; // Note: Should display name, not number
        }

        // Send message button click event
        private void btnGonder_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO TBL_MESAJLAR (GÖNDEREN, ALICI, BASLIK, ICERIK) VALUES (@P1, @P2, @P3,@P4)", conn);
            cmd.Parameters.AddWithValue("@P1", lblNo.Text); // Sender
            cmd.Parameters.AddWithValue("@P2", mskAlici.Text); // Receiver
            cmd.Parameters.AddWithValue("@P3", txtKonu.Text); // Subject
            cmd.Parameters.AddWithValue("@P4", rchMesaj.Text); // Message content
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Mesajınız Gönderilmiştir."); // Success message

            // Refresh message lists after sending
            gelenKutusu();
            gidenKutusu();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
            // Group box enter event handler
        }
    }
}