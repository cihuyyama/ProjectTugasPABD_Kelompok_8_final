using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TratixPABD
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        private void Form6_Load(object sender, EventArgs e)
        {
            label4.Text = Form4.instance.kotaAsal.Text;
            label9.Text = Form4.instance.kotaTujuan.Text;
            label6.Text = Form4.instance.waktuAwal.Text;
            label5.Text = Form4.instance.waktuAkhir.Text;
            label7.Text = Form2.instance.dtp.Text;
            label8.Text = Form2.instance.dtp.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form5().Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form7().Show();
            this.Hide();
        }

    }
}
