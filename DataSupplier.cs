using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace UASPABD
{
    public partial class dataSupplier : Form
    {
        public dataSupplier()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("data source= LAPTOP-NNJOPBIC\\SQLEXPRESS;database=Kesehatanmu;User ID=sa;Password=gmgm872wc0");

        private void AddDataSupplier_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kesehatanmuDataSet3.Supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.kesehatanmuDataSet3.Supplier);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new addDataSupplier().Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new addDataSupplier().Show();
            this.Hide();
        }
    }
}
