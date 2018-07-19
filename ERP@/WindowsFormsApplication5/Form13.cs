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
    public partial class Form13 : Form
    {
        Form1 conn = new Form1();
        public Form13()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            conn.oleDbConnection2.Open();
            OleDbCommand cmd = new OleDbCommand("Select deptname from Dept", conn.oleDbConnection2);
            OleDbDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                comboBox1.Items.Add(dr["deptname"]).ToString();
            }
            conn.oleDbConnection2.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 f1 = new Form1();
            f1.Show();
            f1.textBox1.Visible = false;
            f1.textBox2.Visible = false;
            f1.label1.Visible = false;
            f1.label2.Visible = false;
            f1.button1.Visible = false;
            f1.button2.Visible = false;
            f1.menuStrip1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.oleDbConnection2.Open();
            OleDbCommand cmd = new OleDbCommand("insert into SO(SOID, SODate, DDate, Status, Approve, CDept, CName, CID, CContectPerson, CCPPH, TotalAmount)values(@SOID, @SODate, @DDate, @Status, @Approve, @CDept, @CName, @CID, @CContectPerson, @CCPPH, @TotalAmount);", conn.oleDbConnection2);
            cmd.Parameters.AddWithValue("@SOID", textBox11.Text);
            cmd.Parameters.AddWithValue("@SODate", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@DDate", dateTimePicker2.Text);
            cmd.Parameters.AddWithValue("@Status", textBox3.Text);
            cmd.Parameters.AddWithValue("@Approve", textBox4.Text);
            cmd.Parameters.AddWithValue("@CDept", textBox5.Text);
            cmd.Parameters.AddWithValue("@CName", textBox6.Text);
            cmd.Parameters.AddWithValue("@CID", textBox7.Text);
            cmd.Parameters.AddWithValue("@CContectPerson", textBox8.Text);
            cmd.Parameters.AddWithValue("@CCPPH", textBox9.Text);
            cmd.Parameters.AddWithValue("@TotalAmount", textBox10.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Your data has been inserted");
            conn.oleDbConnection2.Close();
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
                textBox11.Text = "Con-00" + c.ToString() + "-" + System.DateTime.Today.Year;

            }

            if (comboBox1.Text == "Sales")
            {
                textBox11.Text = "Sal-00" + c.ToString() + "-" + System.DateTime.Today.Year;
            }

            if (comboBox1.Text == "HR")
            {
                textBox11.Text = "HR-00" + c.ToString() + "-" + System.DateTime.Today.Year;
            }

            if (comboBox1.Text == "IT")
            {
                textBox11.Text = "IT-00" + c.ToString() + "-" + System.DateTime.Today.Year;
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
        }
    }

