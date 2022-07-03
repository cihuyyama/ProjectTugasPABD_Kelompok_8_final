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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-UP691C2\IQBAL;Initial Catalog=tratix;Integrated Security=True");

        private void Form7_Load(object sender, EventArgs e)
        {
            label24.Text = Form5.instance.id.Text;
            label5.Text = Form5.instance.name.Text;

            label4.Text = Form4.instance.gerbong.Text;
            label7.Text = Form4.instance.kelas.Text;
            label19.Text = Form4.instance.harga.Text;
            label8.Text = Form4.instance.kotaAsal.Text;
            label9.Text = Form4.instance.kotaTujuan.Text;
            label11.Text = Form4.instance.waktuAwal.Text;
            label13.Text = Form4.instance.waktuAkhir.Text;
            label10.Text = Form2.instance.dtp.Text;
            label12.Text = Form2.instance.dtp.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form6().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form8().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("DELETE from detailP", con);
            cmd.CommandType = CommandType.Text;


            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Data telah dihapus", "dihapus", MessageBoxButtons.OK, MessageBoxIcon.Information);

            new Form2().Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Form9().Show();
            this.Hide();
        }
    }
}
