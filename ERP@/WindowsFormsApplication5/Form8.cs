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
    public partial class Form8 : Form
    {
        string[] prds = new string[50];
        int[] qty = new int[50];
        int counter = 0;

        Form1 conn = new Form1();
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            int c = 0;

            conn.oleDbConnection1.Open();
            OleDbCommand cmd1 = new OleDbCommand("select count(POID) from PO ", conn.oleDbConnection1);
            OleDbDataReader dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {
                c = Convert.ToInt32(dr1[0]);
                c++;
            }

            textBox1.Text = "0" + c.ToString();


            OleDbCommand cmd = new OleDbCommand("Select deptname from Dept", conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                comboBox1.Items.Add(dr["deptname"]).ToString();
            }


            OleDbCommand cmmd = new OleDbCommand("Select Pid from Products", conn.oleDbConnection1);
            OleDbDataReader drr = cmmd.ExecuteReader();

            while (drr.Read())
            {
                comboBox2.Items.Add(drr["Pid"]).ToString();
            }
            
            conn.oleDbConnection1.Close();
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int c=0;
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select count(POID) from PO where VDept='" + comboBox1.Text + "'", conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
            c = Convert.ToInt32(dr[0]);
                c++;
            }
            conn.oleDbConnection1.Close();

            conn.oleDbConnection1.Open();
            if (comboBox1.Text == "Consumer")
            {
            textBox1.Text = "Con-00" + c.ToString()+"-"+ System.DateTime.Today.Year;
            }
            conn.oleDbConnection1.Close();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmmd = new OleDbCommand("select * from Products where Pid='" + comboBox2.Text + "'", conn.oleDbConnection1);
            OleDbDataReader drr = cmmd.ExecuteReader();

            if (drr.Read())
            {
                textBox2.Text = drr["PName"].ToString();
            }
            conn.oleDbConnection1.Close();
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
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            for (int i = 0; i < counter; i++)
            {
                OleDbCommand cmd = new OleDbCommand("insert into poproducts (POID,Pid,PQty) values(@POID,@Pid,@PQty)", conn.oleDbConnection1);
                cmd.Parameters.AddWithValue("@POID", textBox1.Text);
                cmd.Parameters.AddWithValue("@Pid", comboBox2.Text);
                cmd.Parameters.AddWithValue("@PQty", textBox3.Text);
                cmd.ExecuteNonQuery();
            }
            conn.oleDbConnection1.Close();
            MessageBox.Show("Transaction has been done"); 
        }
    }
}

