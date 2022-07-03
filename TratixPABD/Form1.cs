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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-UP691C2\IQBAL;Initial Catalog=tratix;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from account where username='" + textusername.Text + "' and password='" + textpass.Text + "'", con);
                cmd.CommandType = CommandType.Text;
                SqlDataReader rd = cmd.ExecuteReader();
                rd.Read();
                if (rd.HasRows)
                {
                    this.Hide();
                    con.Close();
                    Form2 a = new Form2();
                    a.Show();
                    MessageBox.Show("Login Berhasil", "Disimpan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Username atau password salah", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                }
                
            }
        }
        private bool IsValid()
        {
            if (textusername.Text == String.Empty)
            {
                MessageBox.Show("Username kosong", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (textpass.Text == String.Empty)
            {
                MessageBox.Show("password kosong", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 a = new Form3();
            a.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
