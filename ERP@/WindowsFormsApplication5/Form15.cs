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
    public partial class Form15 : Form
    {
        Form1 conn = new Form1();
        public Form15()
        {
            InitializeComponent();
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            int c = 0;
            conn.oleDbConnection2.Open();
            OleDbCommand cmd = new OleDbCommand("select count(DCID) from DC", conn.oleDbConnection2);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                c = Convert.ToInt32(dr[0]);
                c++;
            }
            textBox1.Text = "DC-0" + c.ToString();

            OleDbCommand cmm = new OleDbCommand("select SOID from SO where status='Open'", conn.oleDbConnection2);
            OleDbDataReader drr = cmm.ExecuteReader();
            while (drr.Read())
            {
                comboBox1.Items.Add(drr["SOID"]).ToString();
            }
            conn.oleDbConnection2.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.oleDbConnection2.Open();
            OleDbCommand cmd = new OleDbCommand("select * from SO where SOID='" + comboBox1.Text + "'", conn.oleDbConnection2);
            OleDbDataReader ddr = cmd.ExecuteReader();

            while (ddr.Read())
            {
                textBox2.Text = ddr["CID"].ToString();
                textBox3.Text = ddr["CName"].ToString();
                dateTimePicker1.Text = ddr["DDate"].ToString();
            }
            conn.oleDbConnection2.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.oleDbConnection2.Open();
            OleDbCommand cmd = new OleDbCommand("Update DC set DCID=@DCID, CName=@CName,  DDate=@DDate, DCDate=@DCDate where SOID=@SOID", conn.oleDbConnection2);
            cmd.Parameters.AddWithValue("@DCID", textBox1.Text);
            cmd.Parameters.AddWithValue("@CName", textBox3.Text);
            cmd.Parameters.AddWithValue("@DDate", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@DCDate", dateTimePicker2.Text);
            cmd.Parameters.AddWithValue("@SOID", comboBox1.Text);


            cmd.ExecuteNonQuery();

            MessageBox.Show("Delivery Chalan has been created");



            OleDbCommand cmm = new OleDbCommand("select * from DCProducts  ", conn.oleDbConnection2);
            OleDbDataReader dr = cmm.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
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
