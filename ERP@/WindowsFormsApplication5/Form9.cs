using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace WindowsFormsApplication5
{
    public partial class Form9 : Form
    {
        Form1 conn = new Form1();
        public Form9()
        {
            InitializeComponent();
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

        private void Form9_Load(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Select GRNID from GRNProducts", conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                comboBox1.Items.Add(dr["GRNID"]).ToString();
            }
            conn.oleDbConnection1.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select * from GRNProducts where GRNID='" + comboBox1.Text + "'", conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                textBox1.Text = dr["PModel"].ToString();
                textBox2.Text = dr["PQty"].ToString();
            }
            conn.oleDbConnection1.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10();
            f10.Show();
            f10.button4.Visible = false;
            f10.button5.Visible = false;
            f10.comboBox1.Text = this.comboBox1.Text;
            f10.textBox1.Text = this.textBox1.Text;
            f10.textBox2.Text = this.textBox2.Text;
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10();
            f10.Show();
            f10.button2.Visible = false;
            f10.button3.Visible = false;
            f10.comboBox1.Text = this.comboBox1.Text;
            f10.textBox1.Text = this.textBox1.Text;
            f10.textBox2.Text = this.textBox2.Text;
            this.Hide();
        }
    }
}
