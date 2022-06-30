using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UASPABD
{
    public partial class DataObat : Form
    {
        public DataObat()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("data source= LAPTOP-NNJOPBIC\\SQLEXPRESS;database=Kesehatanmu;User ID=sa;Password=gmgm872wc0");

        private void DataObat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kesehatanmuDataSet3.DataObat' table. You can move, or remove it, as needed.
            this.dataObatTableAdapter.Fill(this.kesehatanmuDataSet3.DataObat);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new AddDataObat().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new AddDataObat().Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
