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
    public partial class Form5 : Form
    {
        Form1 conn = new Form1();
        public Form5()
        {
            InitializeComponent();
    }

        private void label4_Click(object sender, EventArgs e)
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

        private void Form5_Load(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select VID from Vendor where vstatus='Active'", conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["VID"].ToString());
            }
            conn.oleDbConnection1.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select * from Vendor where VID='" + comboBox1.Text + "'", conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                textBox1.Text = dr["VName"].ToString();
                textBox2.Text = dr["VCode"].ToString();
                textBox3.Text = dr["VCity"].ToString();
                textBox4.Text = dr["PH1"].ToString();
                textBox5.Text = dr["PH2"].ToString();
                textBox6.Text = dr["VAddress"].ToString();
                textBox7.Text = dr["CPName"].ToString();
                textBox8.Text = dr["CPPH"].ToString();
                textBox9.Text = dr["VEmail"].ToString();
                textBox10.Text = dr["VFax"].ToString();
                textBox11.Text = dr["VGroup"].ToString();
                textBox12.Text = dr["VStatus"].ToString();

            }
            conn.oleDbConnection1.Close();
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Show();
            f7.button4.Visible = false;
            f7.button5.Visible = false;
            f7.textBox13.Visible = false;

            f7.comboBox1.Text = this.comboBox1.Text;
            f7.textBox1.Text = this.textBox1.Text;
            f7.textBox2.Text = this.textBox2.Text;
            f7.textBox3.Text = this.textBox3.Text;
            f7.textBox4.Text = this.textBox4.Text;
            f7.textBox5.Text = this.textBox5.Text;
            f7.textBox6.Text = this.textBox6.Text;
            f7.textBox7.Text = this.textBox7.Text;
            f7.textBox8.Text = this.textBox8.Text;
            f7.textBox9.Text = this.textBox9.Text;
            f7.textBox10.Text = this.textBox10.Text;
            f7.textBox11.Text = this.textBox11.Text;
            f7.textBox12.Text = this.textBox12.Text;
           
       
            this.Hide();
        }

        
    }
}
