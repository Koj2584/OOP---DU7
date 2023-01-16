using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP___Skola_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Produkt p;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                p = new Produkt(textBox1.Text, int.Parse(textBox2.Text), dateTimePicker1.Value, dateTimePicker2.Value, checkBox1.Checked);
            }
            catch
            {
                MessageBox.Show("Špatný formát!!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(p.ToString());
        }
    }
}
