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
using DGVPrinterHelper;

namespace UASPABD
{
    public partial class DataTransaksi : Form
    {
        public DataTransaksi()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("data source= LAPTOP-NNJOPBIC\\SQLEXPRESS;database=Kesehatanmu;User ID=sa;Password=gmgm872wc0");

        private void DataTransaksi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kesehatanmuDataSet3.Transaksi' table. You can move, or remove it, as needed.
            this.transaksiTableAdapter.Fill(this.kesehatanmuDataSet3.Transaksi);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Laporan Data Transaksi";
            printer.SubTitle = string.Format("Tanggal {0}", DateTime.Now.Date.ToString("dd-MM-yyyy"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.FooterSpacing = 15;
            printer.PrintPreviewDataGridView(dataGridView1);

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }
    }
}