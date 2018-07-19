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
    public partial class Form4 : Form
    {
        Form1 conn = new Form1();
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
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

        private void Form4_Load(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Select deptname from Dept", conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                comboBox2.Items.Add(dr["deptname"]).ToString();
            }
            conn.oleDbConnection1.Close();
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            {
            OleDbCommand cmd = new OleDbCommand("insert into PO(POID,VContectPerson,VCPPH,DDate,PODate,Approve,TotalAmount,VID,VDept,VName,Status) values(@POID,@VContectPerson,@VCPPH,@DDate,@PODate,@Approve,@TotalAmount,@VID,@VDept,@VName,@Status)", conn.oleDbConnection1);
            cmd.Parameters.AddWithValue("@POID", textBox11.Text);
            cmd.Parameters.AddWithValue("@VContectPerson", textBox8.Text);
            cmd.Parameters.AddWithValue("@VCPPH", textBox9.Text);
            cmd.Parameters.AddWithValue("@DDate", dateTimePicker2.Text);
            cmd.Parameters.AddWithValue("@PODate", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@Approve", textBox4.Text);
            cmd.Parameters.AddWithValue("@TotalAmount", textBox10.Text);
            cmd.Parameters.AddWithValue("@VID", textBox7.Text);
            cmd.Parameters.AddWithValue("@VDept", textBox5.Text);
            cmd.Parameters.AddWithValue("@VName", textBox6.Text);
            cmd.Parameters.AddWithValue("@Status", textBox3.Text);

            cmd.ExecuteNonQuery();
        }
            conn.oleDbConnection1.Close();
            MessageBox.Show(":Your Purchase Order Is Create:");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int c = 0;


            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select count(POID) from PO where VDept='" + comboBox2.Text + "'", conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                c = Convert.ToInt32(dr[0]);
                c++;
            }

            if (comboBox2.Text == "Consumer")
            {
                textBox11.Text = "Con-00" + c.ToString() + "-" + System.DateTime.Today.Year;

            }

            if (comboBox2.Text == "Sales")
            {
                textBox11.Text = "Sal-00" + c.ToString() + "-" + System.DateTime.Today.Year;
            }

            if (comboBox2.Text == "HR")
            {
                textBox11.Text = "HR-00" + c.ToString() + "-" + System.DateTime.Today.Year;
            }

            if (comboBox2.Text == "IT")
            {
                textBox11.Text = "IT-00" + c.ToString() + "-" + System.DateTime.Today.Year;
            }
            conn.oleDbConnection1.Close();

            int i = 0;
            conn.oleDbConnection1.Open();
            OleDbCommand cmm = new OleDbCommand("select count(VID) from PO where VDept='" + comboBox2.Text + "'", conn.oleDbConnection1);
            OleDbDataReader drr = cmm.ExecuteReader();
            if (drr.Read())
            {
                i = Convert.ToInt32(drr[0]);
                i++;
            }

            conn.oleDbConnection1.Close();
        }

        }
    }

