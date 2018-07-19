using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace WindowsFormsApplication5
{
    public partial class Form6 : Form
    {

        Form1 conn = new Form1();
        public Form6()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
        private void button6_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Show();
            f7.button2.Visible = false;
            f7.button3.Visible = false;
            f7.comboBox1.Visible = false;
            
            this.Hide();

            f7.textBox13.Text = this.textBox1.Text;
            f7.textBox1.Text = this.textBox2.Text;
            f7.textBox2.Text = this.textBox3.Text;
            f7.textBox3.Text = this.textBox4.Text;
            f7.textBox4.Text = this.textBox5.Text;
            f7.textBox5.Text = this.textBox6.Text;
            f7.textBox6.Text = this.textBox7.Text;
            f7.textBox7.Text = this.textBox8.Text;
            f7.textBox8.Text = this.textBox9.Text;
            f7.textBox9.Text = this.textBox10.Text;
            f7.textBox10.Text = this.textBox11.Text;
            f7.textBox11.Text = this.textBox12.Text;
            f7.textBox12.Text = this.textBox13.Text;
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            f1.textBox1.Visible = false;
            f1.textBox2.Visible = false;
            f1.label1.Visible = false;
            f1.label2.Visible = false;
            f1.button1.Visible = false;
            f1.button2.Visible = false;
            f1.menuStrip1.Enabled = true;

            this.Hide();
        }

    }
}

