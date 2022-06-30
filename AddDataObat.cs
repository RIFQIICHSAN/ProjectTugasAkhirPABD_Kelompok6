using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UASPABD
{
    public partial class AddDataObat : Form
    {
        public AddDataObat()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("data source= LAPTOP-NNJOPBIC\\SQLEXPRESS;Initial Catalog=Kesehatanmu;User ID=sa;Password=gmgm872wc0");

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Insert
            string kodeobat = (textBox3.Text);
            string namaobat = (textBox1.Text);
            string jenisobat = (comboBox1.Text);
            string stok = (textBox2.Text);
            string harga = (textBox4.Text);
            con.Open();
            SqlCommand c = new SqlCommand("exec tambahObat '" + kodeobat + "','" + namaobat + "','" + jenisobat + "','" + stok + "','" + harga +"'", con);
            c.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data baru berhasil ditambahkan");
            GetDataList();
        }

        void GetDataList()
        {
            SqlCommand c = new SqlCommand("exec bacaDataObat", con);
            SqlDataAdapter sd = new SqlDataAdapter(c);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddDataObat_Load(object sender, EventArgs e)
        {
            GetDataList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Delete
            if (MessageBox.Show("Apakah anda yakin ingin menghapus data ini?", "Delete Document", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string kodeobat = (textBox3.Text);
                con.Open();
                SqlCommand c = new SqlCommand("exec hapusDataObat '" + kodeobat + "'", con);
                c.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data berhasil dihapus");
                GetDataList();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Update
            string kodeobat = (textBox3.Text);
            string namaobat = (textBox1.Text);
            string jenisobat = (comboBox1.Text);
            string stok = (textBox2.Text);
            string harga = (textBox4.Text);
            con.Open();
            SqlCommand c = new SqlCommand("exec updateDataObat '" + kodeobat + "','" + namaobat + "','" + jenisobat + "','" + stok + "','" + harga + "'", con);
            c.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data berhasil diupdate");
            GetDataList();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new DataObat().Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
   
}
