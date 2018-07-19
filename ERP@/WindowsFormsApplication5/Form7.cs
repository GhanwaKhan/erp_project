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
    public partial class Form7 : Form
    {
        Form1 conn = new Form1();
        public Form7()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select VID from Vendor where VStatus='Active'", conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["VID"].ToString());
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

      
        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Select * from vendor where vid='" + comboBox1.Text + "'", conn.oleDbConnection1);
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("update Vendor set VStatus='Active' where VID='"+comboBox1.Text+"'", conn.oleDbConnection1);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record has been updated");
            conn.oleDbConnection1.Close();

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("insert into Vendor(VID, VName, VCode, VCity, PH1, PH2, VAddress,CPName,CPPH,VEmail,VFax,VGroup,VStatus)values(@VID, @VName, @VCode, @VCity, @PH1,@PH2,@VAddress,@CPName,@CPPH,@VEmail,@VFax,@VGroup,@VStatus);", conn.oleDbConnection1);
            cmd.Parameters.AddWithValue("@VID", comboBox1.Text);
            cmd.Parameters.AddWithValue("@VName", textBox1.Text);
            cmd.Parameters.AddWithValue("@VCode", textBox2.Text);
            cmd.Parameters.AddWithValue("@VCity", textBox3.Text);
            cmd.Parameters.AddWithValue("@PH1", textBox4.Text);
            cmd.Parameters.AddWithValue("@PH2", textBox5.Text);
            cmd.Parameters.AddWithValue("@VAddress", textBox6.Text);
            cmd.Parameters.AddWithValue("@CPName", textBox7.Text);
            cmd.Parameters.AddWithValue("@CPPH", textBox8.Text);
            cmd.Parameters.AddWithValue("@VEmail", textBox9.Text);
            cmd.Parameters.AddWithValue("@VFax", textBox10.Text);
            cmd.Parameters.AddWithValue("@VGroup", textBox11.Text);
            cmd.Parameters.AddWithValue("@VStatus", textBox12.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Your data has been inserted"); 
            conn.oleDbConnection1.Close();
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
            this.Hide();
        }

        private void button5_Click_2(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
