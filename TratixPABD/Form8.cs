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
    public partial class Form8 : Form
    {
        public string cb;
        public Form8()
        {
            InitializeComponent();
        }
        private void Form8_Load(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("Select gerbong from list", con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable table = new DataTable();
            da.Fill(table);

            DataRow itemrow = table.NewRow();
            itemrow[0] = "Pilih gerbong";
            table.Rows.InsertAt(itemrow, 0);

            comboBox1.DataSource = table;
            comboBox1.DisplayMember = "gerbong";
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-UP691C2\IQBAL;Initial Catalog=tratix;Integrated Security=True");

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form7().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UPDATE detailP SET nama = @nama, id = @id, gerbong = @gerbong, tanggal = @tanggal", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@nama", textBox1.Text);
            cmd.Parameters.AddWithValue("@id", textBox2.Text);
            cmd.Parameters.AddWithValue("@gerbong", cb);
            cmd.Parameters.AddWithValue("@tanggal", this.dateTimePicker1.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Data telah diperbarui", "Diperbarui", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cb = comboBox1.GetItemText(comboBox1.SelectedItem);
        }
    }
}
