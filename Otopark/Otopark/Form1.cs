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

namespace Otopark
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\aytun\Documents\ArabaParkDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void fill()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select AracSahibi,Plaka from ArabaKayitTbl", baglanti);
            SqlDataReader rdr;
            rdr = komut.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("AracSahibi,Plaka", typeof(string));
            dt.Load(rdr);
            AracSahibiCb.ValueMember = "AracSahibi";
            PlakaCb.ValueMember = "Plaka";
            AracSahibiCb.DataSource = dt;
            PlakaCb.DataSource = dt;
            baglanti.Close();
        }
        private void uyeler()
        {
            baglanti.Open();
            string query = "select * from ArabaKayitTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            var ds = new DataSet();
            sda.Fill(ds);
            KayitDgv.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            if(guna2CircleButton1.FillColor==Color.LawnGreen)
            {
                guna2CircleButton1.FillColor = Color.Red;
                pictureBox1.Visible = true;
            }
            else
            {
                guna2CircleButton1.FillColor = Color.LawnGreen;
                pictureBox1.Visible = false;
            }
        }
        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            if (guna2CircleButton2.FillColor == Color.LawnGreen)
            {
                guna2CircleButton2.FillColor = Color.Red;
                pictureBox1.Visible = true;
            }
            else
            {
                guna2CircleButton2.FillColor = Color.LawnGreen;
                pictureBox1.Visible = false;
            }
        }
        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
            if (guna2CircleButton3.FillColor == Color.LawnGreen)
            {
                guna2CircleButton3.FillColor = Color.Red;
                pictureBox1.Visible = true;
            }
            else
            {
                guna2CircleButton3.FillColor = Color.LawnGreen;
                pictureBox1.Visible = false;
            }
        }
        private void guna2CircleButton4_Click(object sender, EventArgs e)
        {
            if (guna2CircleButton4.FillColor == Color.LawnGreen)
            {
                guna2CircleButton4.FillColor = Color.Red;
                pictureBox1.Visible = true;
            }
            else
            {
                guna2CircleButton4.FillColor = Color.LawnGreen;
                pictureBox1.Visible = false;
            }
        }
        private void guna2CircleButton5_Click(object sender, EventArgs e)
        {
            if (guna2CircleButton5.FillColor == Color.LawnGreen)
            {
                guna2CircleButton5.FillColor = Color.Red;
                pictureBox1.Visible = true;
            }
            else
            {
                guna2CircleButton5.FillColor = Color.LawnGreen;
                pictureBox1.Visible = false;
            }
        }
        private void guna2CircleButton6_Click(object sender, EventArgs e)
        {
            if (guna2CircleButton6.FillColor == Color.LawnGreen)
            {
                guna2CircleButton6.FillColor = Color.Red;
                pictureBox1.Visible = true;
            }
            else
            {
                guna2CircleButton6.FillColor = Color.LawnGreen;
                pictureBox1.Visible = false;
            }
        }
        private void guna2CircleButton7_Click(object sender, EventArgs e)
        {
            if (guna2CircleButton7.FillColor == Color.LawnGreen)
            {
                guna2CircleButton7.FillColor = Color.Red;
                pictureBox1.Visible = true;
            }
            else
            {
                guna2CircleButton7.FillColor = Color.LawnGreen;
                pictureBox1.Visible = false;
            }
        }
        private void guna2CircleButton8_Click(object sender, EventArgs e)
        {
            if (guna2CircleButton8.FillColor == Color.LawnGreen)
            {
                guna2CircleButton8.FillColor = Color.Red;
                pictureBox1.Visible = true;
            }
            else
            {
                guna2CircleButton8.FillColor = Color.LawnGreen;
                pictureBox1.Visible = false;
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(AracSahibiTb.Text==""|| TelefonTb.Text==""|| TarihDtb.Text==""|| PlakaTb.Text==""|| GirisTb.Text=="")
            {
                MessageBox.Show("Eksik Bilgi");
            }
            else
            {
                try
                {
                    baglanti.Open();
                    string query = "insert into ArabaKayitTbl values('"+AracSahibiTb.Text+"','"+TelefonTb.Text+"','"+TarihDtb.Text+"','"+PlakaTb.Text+"','"+GirisTb.Text+"')";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Araç Kaydı Başarıyla Eklenmiştir");
                    baglanti.Close();
                    uyeler();
                    fill();
                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            uyeler();
            fill();
            if (guna2CircleButton1.FillColor == Color.LawnGreen || guna2CircleButton2.FillColor == Color.LawnGreen || guna2CircleButton3.FillColor == Color.LawnGreen || guna2CircleButton4.FillColor == Color.LawnGreen || guna2CircleButton5.FillColor == Color.LawnGreen || guna2CircleButton6.FillColor == Color.LawnGreen || guna2CircleButton7.FillColor == Color.LawnGreen || guna2CircleButton8.FillColor == Color.LawnGreen)
            {
                label9.Text = "Boş Yer Mevcut";
            }
            else
            {
                label9.Text = "Otopark Dolu";
            }
        }
        int AracKey;
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (AracSahibiTb.Text == "" || TelefonTb.Text == "" || TarihDtb.Text == "" || PlakaTb.Text == "" || GirisTb.Text == "")
            {
                MessageBox.Show("Silinecek Kaydı Seçiniz");
            }
            else
            {
                AracKey = Convert.ToInt32(KayitDgv.SelectedRows[0].Cells[0].Value.ToString());
                try
                {
                    baglanti.Open();
                    string query = "delete from ArabaKayitTbl where AKayitId="+AracKey+"";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Araç Kaydı Başarıyla Silinmiştir");
                    baglanti.Close();
                    uyeler();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void KayitDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AracKey = Convert.ToInt32(KayitDgv.SelectedRows[0].Cells[0].Value.ToString());
            AracSahibiTb.Text = KayitDgv.SelectedRows[0].Cells[1].Value.ToString();
            TelefonTb.Text = KayitDgv.SelectedRows[0].Cells[2].Value.ToString();
            TarihDtb.Text = KayitDgv.SelectedRows[0].Cells[3].Value.ToString();
            PlakaTb.Text = KayitDgv.SelectedRows[0].Cells[4].Value.ToString();
            GirisTb.Text = KayitDgv.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (AracSahibiTb.Text == "" || TelefonTb.Text == "" || TarihDtb.Text == "" || PlakaTb.Text == "" || GirisTb.Text == "")
            {
                MessageBox.Show("Eksik Bilgi");
            }
            else
            {
                try
                {
                    baglanti.Open();
                    string query = "update ArabaKayitTbl set AracSahibi='" + AracSahibiTb.Text + "',Telefon='" + TelefonTb.Text + "',Tarih='" + TarihDtb.Text + "',Plaka='" + PlakaTb.Text + "',Giriş='" + GirisTb.Text + "' where AKayitId="+AracKey+";";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Araç Kaydı Başarıyla Güncellenmiştir");
                    baglanti.Close();
                    uyeler();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            AracSahibiTb.Text = "";
            TelefonTb.Text = "";
            TarihDtb.Text = "";
            PlakaTb.Text = "";
            GirisTb.Text = "";
        }
        private void guna2Button5_Click(object sender, EventArgs e)
        {
        }
    }
}
