using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UASPABD
{
    public partial class addDataSupplier : Form
    {
        public addDataSupplier()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-NNJOPBIC\\SQLEXPRESS;Initial Catalog=Kesehatanmu;User ID=sa;Password=gmgm872wc0");

        private void DataSupllier_Load(object sender, EventArgs e)
        {
            GetDataSupplier();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new dataSupplier().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void insertData_Click(object sender, EventArgs e)
        {
            //Insert
            string idsupplier = (textBox6.Text);
            string namaperusahaan = (textBox5.Text);
            string asalkota = (textBox1.Text);
            DateTime tanggal = DateTime.Parse(dateTimePicker1.Text);
            string namaobat = (textBox2.Text);
            string kodeobat = (textBox3.Text);
            string jumlah = (textBox4.Text);
            con.Open();
            SqlCommand c = new SqlCommand("exec tambahSupplier '" + idsupplier + "','" + namaperusahaan + "','" + asalkota + "','" + tanggal + "','" + namaobat + "','" + kodeobat + "','" + jumlah + "'", con);
            c.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Baru Berhasil Ditambahkan");
            GetDataSupplier();
        }

        void GetDataSupplier()
        {
            SqlCommand c = new SqlCommand("exec bacaDataSupplier", con);
            SqlDataAdapter sd = new SqlDataAdapter(c);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void updateData_Click(object sender, EventArgs e)
        {
            //Update
            string idsupplier = (textBox6.Text);
            string namaperusahaan = (textBox5.Text);
            string asalkota = (textBox1.Text);
            DateTime tanggal = DateTime.Parse(dateTimePicker1.Text);
            string namaobat = (textBox2.Text);
            string kodeobat = (textBox3.Text);
            string jumlah = (textBox4.Text);
            con.Open();
            SqlCommand c = new SqlCommand("exec updateSupplier '" + idsupplier + "','" + namaperusahaan + "','" + asalkota + "','" + tanggal + "','" + namaobat + "','" + kodeobat + "','" + jumlah + "'", con);
            c.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Baru Berhasil Diupdate");
            GetDataSupplier();
        }

        private void hapusData_Click(object sender, EventArgs e)
        {
            //Delete
            if(MessageBox.Show("Apakah anda yakin ingin menghapus data ini?", "Delete Document", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string idsupplier = (textBox6.Text);
                con.Open();
                SqlCommand c = new SqlCommand("exec hapusDataSupplier '" + idsupplier + "'", con);
                c.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Berhasil Dihapus");
                GetDataSupplier();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
