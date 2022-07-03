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

namespace TratixPABD
{
    public partial class Form4 : Form
    {
        public Label harga;
        public Label gerbong;
        public Label kelas;
        public Label kotaAsal;
        public Label kotaTujuan;
        public Label waktuAwal;
        public Label waktuAkhir;
        public Label waktuTempuh;
        public static Form4 instance;
        public Form4()
        {
            InitializeComponent();
            instance = this;
            harga = label21;
            gerbong = label1;
            kelas = label2;
            kotaAsal = label8;
            kotaTujuan = label3;
            waktuAwal = label7;
            waktuAkhir = label6;
            waktuTempuh = label9;

            label10.Text = Form2.instance.dtp.Text;
            label5.Text = Form2.instance.dtp.Text;

        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-UP691C2\IQBAL;Initial Catalog=tratix;Integrated Security=True");

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tratixDataSet1.list' table. You can move, or remove it, as needed.
            this.listTableAdapter.Fill(this.tratixDataSet1.list);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new Form5().Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
