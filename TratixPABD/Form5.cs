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
    public partial class Form5 : Form
    {
        public static Form5 instance;
        public Label harga;
        public Label gerbong;
        public Label kelas;
        public Label kotaAsal;
        public Label kotaTujuan;
        public Label waktuAwal;
        public Label waktuAkhir;
        public Label waktuTempuh;
        public TextBox name;
        public TextBox id;
        public Form5()
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
            label1.Text = Form4.instance.gerbong.Text;
            label2.Text = Form4.instance.kelas.Text;
            label21.Text = Form4.instance.harga.Text;
            label8.Text = Form4.instance.kotaAsal.Text;
            label3.Text = Form4.instance.kotaTujuan.Text;
            label7.Text = Form4.instance.waktuAwal.Text;
            label6.Text = Form4.instance.waktuAkhir.Text;
            label9.Text = Form4.instance.waktuTempuh.Text;
            label10.Text = Form2.instance.dtp.Text;
            label5.Text = Form2.instance.dtp.Text;
            name = textBox1;
            id = textBox2;
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-UP691C2\IQBAL;Initial Catalog=tratix;Integrated Security=True");

        private void Form5_Load(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("Select tipeId from passage", con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable table = new DataTable();
            da.Fill(table);

            DataRow itemrow = table.NewRow();
            itemrow[0] = "Pilih tipe ID";
            table.Rows.InsertAt(itemrow, 0);

            comboBox2.DataSource = table;
            comboBox2.DisplayMember = "tipeId";

            SqlCommand cmd1 = new SqlCommand("Select tipe_penumpang from passage", con);
            SqlDataAdapter da1 = new SqlDataAdapter();
            da1.SelectCommand = cmd1;
            DataTable table1 = new DataTable();
            da1.Fill(table1);

            DataRow itemrow1 = table1.NewRow();
            itemrow1[0] = "Pilih tipe penumpang";
            table1.Rows.InsertAt(itemrow1, 0);

            comboBox3.DataSource = table1;
            comboBox3.DisplayMember = "tipe_penumpang";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form4().Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO detailP VALUES (@nama, @id, @gerbong, @tanggal)", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@nama", textBox1.Text);
            cmd.Parameters.AddWithValue("@id", textBox2.Text);
            cmd.Parameters.AddWithValue("@gerbong", label1.Text);
            cmd.Parameters.AddWithValue("@tanggal", label5.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            new Form6().Show();
            this.Hide();

            MessageBox.Show("Data baru telah ditambahkan", "Disimpan", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
