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
    public partial class Form2 : Form
    {
        public static Form2 instance;
        public string cb1;
        public string cbd;
        public string seat;
        public DateTimePicker dtp;
        public Form2()
        {
            InitializeComponent();
            instance = this;
            dtp = dateTimePicker1;
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-UP691C2\IQBAL;Initial Catalog=tratix;Integrated Security=True");

        private void Form2_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select kota_asal from data", con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable table = new DataTable();
            da.Fill(table);

            DataRow itemrow = table.NewRow();
            itemrow[0] = "Pilih Asal Kota";
            table.Rows.InsertAt(itemrow, 0);

            cbDepartement.DataSource = table;
            cbDepartement.DisplayMember = "kota_asal";

            SqlCommand cmd1 = new SqlCommand("Select kota_tujuan from data", con);
            SqlDataAdapter da1 = new SqlDataAdapter();
            da.SelectCommand = cmd1;
            DataTable table1 = new DataTable();
            da.Fill(table1);

            DataRow itemrow1 = table1.NewRow();
            itemrow1[0] = "Pilih Tujuan Kota";
            table1.Rows.InsertAt(itemrow1, 0);

            comboBox1.DataSource = table1;
            comboBox1.DisplayMember = "kota_tujuan";

            for (int i = 1; i <= 10; i++)
            {
                this.comboBox2.Items.Add(i.ToString());
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form4().Show();
        }

        private void cbDepartement_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbd = cbDepartement.GetItemText(cbDepartement.SelectedItem);
            label5.Text = cbDepartement.GetItemText(cbDepartement.SelectedItem);
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cb1 = comboBox1.GetItemText(comboBox1.SelectedItem);
            label7.Text = comboBox1.GetItemText(comboBox1.SelectedItem);
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            seat = comboBox2.GetItemText(comboBox2.SelectedItem);
            label8.Text = comboBox2.GetItemText(comboBox2.SelectedItem);
        }

        private void cbDepartement_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
