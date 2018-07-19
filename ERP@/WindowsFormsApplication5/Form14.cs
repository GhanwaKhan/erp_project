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
    public partial class Form14 : Form
    {
        string[] prds = new string[50];
        int[] qty = new int[50];
        int counter = 0;

        Form1 conn = new Form1();
        public Form14()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Text += comboBox2.Text + Environment.NewLine;
            textBox5.Text += textBox3.Text + Environment.NewLine;
            prds[counter] = comboBox2.Text;
            qty[counter] = Convert.ToInt32(textBox3.Text);
            counter++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.oleDbConnection2.Open();
            for (int i = 0; i < counter; i++)
            {
                OleDbCommand cmd = new OleDbCommand("insert into SOProducts (SOID,Pid,PQty) values(@SOID,@Pid,@PQty)", conn.oleDbConnection2);
                cmd.Parameters.AddWithValue("@SOID", textBox1.Text);
                cmd.Parameters.AddWithValue("@Pid", comboBox2.Text);
                cmd.Parameters.AddWithValue("@PQty", textBox3.Text);
                cmd.ExecuteNonQuery();
            }
            conn.oleDbConnection2.Close();
            MessageBox.Show("Transaction has been done"); 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int c = 0;


            conn.oleDbConnection2.Open();
            OleDbCommand cmd = new OleDbCommand("select count(SOID) from SO where CDept='" + comboBox1.Text + "'", conn.oleDbConnection2);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                c = Convert.ToInt32(dr[0]);
                c++;
            }

            if (comboBox1.Text == "Consumer")
            {
                textBox1.Text = "Con-00" + c.ToString() + "-" + System.DateTime.Today.Year;

            }

            if (comboBox1.Text == "Sales")
            {
                textBox1.Text = "Sal-00" + c.ToString() + "-" + System.DateTime.Today.Year;
            }

            if (comboBox1.Text == "HR")
            {
                textBox1.Text = "HR-00" + c.ToString() + "-" + System.DateTime.Today.Year;
            }

            if (comboBox1.Text == "IT")
            {
                textBox1.Text = "IT-00" + c.ToString() + "-" + System.DateTime.Today.Year;
            }
            conn.oleDbConnection2.Close();

            int i = 0;
            conn.oleDbConnection2.Open();
            OleDbCommand cmm = new OleDbCommand("select count(CID) from SO where CDept='" + comboBox1.Text + "'", conn.oleDbConnection2);
            OleDbDataReader drr = cmm.ExecuteReader();
            if (drr.Read())
            {
                i = Convert.ToInt32(drr[0]);
                i++;
            }

            conn.oleDbConnection2.Close();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.oleDbConnection2.Open();
            OleDbCommand cmmd = new OleDbCommand("select * from Products where Pid='" + comboBox2.Text + "'", conn.oleDbConnection2);
            OleDbDataReader drr = cmmd.ExecuteReader();

            if (drr.Read())
            {
                textBox2.Text = drr["PName"].ToString();
            }
            conn.oleDbConnection2.Close();
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            int c = 0;

            conn.oleDbConnection2.Open();
            OleDbCommand cmd1 = new OleDbCommand("select count(SOID) from SO ", conn.oleDbConnection2);
            OleDbDataReader dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {
                c = Convert.ToInt32(dr1[0]);
                c++;
            }

            textBox1.Text = "0" + c.ToString();

           
            OleDbCommand cmd = new OleDbCommand("Select deptname from Dept", conn.oleDbConnection2);
            OleDbDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                comboBox1.Items.Add(dr["deptname"]).ToString();
            }
          

            OleDbCommand cmmd = new OleDbCommand("Select Pid from Products", conn.oleDbConnection2);
            OleDbDataReader drr = cmmd.ExecuteReader();

            while (drr.Read())
            {
                comboBox2.Items.Add(drr["Pid"]).ToString();
            }
            conn.oleDbConnection2.Close();
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
