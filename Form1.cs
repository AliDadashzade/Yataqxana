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

namespace Yataqxana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=Yataqxana;Integrated Security=True");
        private void verilerimigoster(string veriler)
        {
            textBox1.Clear();
            textBox2.Clear();   
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            SqlDataAdapter da = new SqlDataAdapter(veriler, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void button1_Click(object sender, EventArgs e)
        {
            verilerimigoster("Select *from yataqxanalist");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert into yataqxanalist (ad,soyad,odano,gtarih,ctarih,telefon,hesab) values (@ad,@soyad,@odano,@gtarih,@ctarih,@telefon,@hesab)", baglanti);
            komut.Parameters.AddWithValue("@ad", textBox1.Text);
            komut.Parameters.AddWithValue("@soyad", textBox2.Text);
            komut.Parameters.AddWithValue("@odano", textBox3.Text);
            komut.Parameters.AddWithValue("@gtarih", textBox4.Text);
            komut.Parameters.AddWithValue("@ctarih", textBox5.Text);
            komut.Parameters.AddWithValue("@telefon", textBox6.Text);
            komut.Parameters.AddWithValue("@hesab", textBox7.Text);
            komut.ExecuteNonQuery();
            verilerimigoster("Select *from yataqxanalist");
            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from yataqxanalist where ad=@ad", baglanti);
            komut.Parameters.AddWithValue("@ad", textBox8.Text);
            komut.ExecuteNonQuery();
            verilerimigoster("Select *from yataqxanalist");
            baglanti.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select *from yataqxanalist where ad like '%" + textBox8.Text + "%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secili = dataGridView1.SelectedCells[0].RowIndex;
            string ad = dataGridView1.Rows[secili].Cells[0].Value.ToString();
            string soyad = dataGridView1.Rows[secili].Cells[1].Value.ToString();
            string odano = dataGridView1.Rows[secili].Cells[2].Value.ToString();
            string gtarih = dataGridView1.Rows[secili].Cells[3].Value.ToString();
            string ctarih = dataGridView1.Rows[secili].Cells[4].Value.ToString();
            string telefon = dataGridView1.Rows[secili].Cells[5].Value.ToString();
            string hesab = dataGridView1.Rows[secili].Cells[6].Value.ToString();
            textBox1.Text = ad;
            textBox2.Text = soyad;
            textBox3.Text = odano;
            textBox4.Text = gtarih;
            textBox5.Text = ctarih;
            textBox6.Text = telefon;
            textBox7.Text = hesab;
        }
        

        private void button6_Click(object sender, EventArgs e)
        {
            textBox3.Text = "1";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox3.Text = "2";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox3.Text = "3";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox3.Text = "4";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox3.Text = "5";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox3.Text = "6";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox3.Text = "7";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox3.Text = "8";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox3.Text = "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox3.Text = "10";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox3.Text = "11";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox3.Text = "12";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox3.Text = "13";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox3.Text = "14";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox3.Text = "15";
        }

        private void button25_Click(object sender, EventArgs e)
        {
            textBox3.Text = "16";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBox3.Text = "17";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox3.Text = "18";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox3.Text = "19";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox3.Text = "20";
        }



        private void btnuptade_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("uptade yataqxanalist set soyad='"+textBox2.Text+"'odano='"+textBox3.Text + "'gtarih='" + textBox4.Text + "'ctarih='" + textBox5.Text + "'telefon='" + textBox6.Text + "'hesab='" + textBox7.Text + "'where ad='" + textBox1.Text+"'",baglanti);
       komut.ExecuteNonQuery();
            verilerimigoster("Select *from yataqxanalist");
            baglanti.Close();
        }
    }
}