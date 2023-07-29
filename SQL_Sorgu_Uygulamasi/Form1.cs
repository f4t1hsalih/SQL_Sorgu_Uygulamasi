using System.Data;
using System.Data.SqlClient;

namespace SQL_Sorgu_Uygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection BaglantiAdresi(string adres = "master")
        {
            SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=" + adres + ";Integrated Security=True");
            baglanti.Open();
            return baglanti;
        }

        string sorgu;

        void Goruntule()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sorgu, BaglantiAdresi(cmbDatabase.SelectedItem.ToString()));
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Sorgunuzu Kontrol Edin!", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void Islem()
        {
            try
            {
                SqlCommand komut = new SqlCommand(sorgu, BaglantiAdresi(cmbDatabase.SelectedItem.ToString()));
                komut.ExecuteNonQuery();
                BaglantiAdresi().Close();

                MessageBox.Show("Ýþlem Baþarýyla Gerçekleþti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Sorgunuzu Kontrol Edin!", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT name FROM sys.databases where name != 'master' and name != 'tempdb' and name != 'model'  and name != 'msdb'", BaglantiAdresi());
            SqlDataReader dr;
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbDatabase.Items.Add(dr["name"]);
            }
            BaglantiAdresi().Close();
        }

        private void cmbDatabase_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(cmbDatabase.SelectedItem.ToString());
            BaglantiAdresi(cmbDatabase.SelectedItem.ToString());

            SqlCommand komut = new SqlCommand("use " + cmbDatabase.SelectedItem.ToString(), BaglantiAdresi());
            komut.ExecuteNonQuery();
            BaglantiAdresi().Close();
        }

        private void btnGoruntule_Click(object sender, EventArgs e)
        {
            sorgu = rchSorgu.Text;

            //MessageBox.Show(cmbDatabase.SelectedIndex.ToString());
            if (cmbDatabase.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Bir Veri Tabaný Seçin", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Goruntule();
            }

        }

        private void btnIslemler_Click(object sender, EventArgs e)
        {
            sorgu = rchSorgu.Text;

            if (cmbDatabase.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Bir Veri Tabaný Seçin", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Islem();
            }

        }
    }
}