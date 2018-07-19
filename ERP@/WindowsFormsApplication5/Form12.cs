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
    public partial class Form12 : Form
    {
        Form1 conn = new Form1();
        public Form12()
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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Form12_Load(object sender, EventArgs e)
        {
            this.textBox8.ReadOnly = true;
            int c = 0;

            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select count(InvoiceID) from Invoice ", conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                c = Convert.ToInt32(dr[0]);
                c++;
            }

            textBox1.Text = "0" + c.ToString(); 
            OleDbCommand cmdd = new OleDbCommand("Select GRNID from GRN where Status ='Open' ", conn.oleDbConnection1);
            OleDbDataReader drr = cmdd.ExecuteReader();

            while (drr.Read())
            {
                comboBox1.Items.Add(drr["GRNID"]).ToString();
            }



            conn.oleDbConnection1.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("insert into Invoice(InvoiceID,VendorID,VendorName,GRNDate,CDate,AmountPayable,GRNID) values(@InvoiceID,@VendorID,@VendorName,@GRNDate,@CDate,@AmountPayable,@GRNID)", conn.oleDbConnection1);

            cmd.Parameters.AddWithValue("@InvoiceID", textBox1.Text);
            cmd.Parameters.AddWithValue("@VendorID", textBox5.Text);
            cmd.Parameters.AddWithValue("@VendorName", textBox6.Text);
            cmd.Parameters.AddWithValue("@GRNDate", textBox2.Text);
            cmd.Parameters.AddWithValue("@CDate", dateTimePicker1);
            cmd.Parameters.AddWithValue("@AmountPayable", textBox8.Text);
            cmd.Parameters.AddWithValue("@GRNID", comboBox1.Text);

            cmd.ExecuteNonQuery();

            conn.oleDbConnection1.Close();
            MessageBox.Show("Kindly pay the amount");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Select *from GRN where GRNID = '" + comboBox1.Text + "'", conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {

                textBox2.Text = dr["GRDate"].ToString();
                textBox4.Text = dr["POID"].ToString();
                textBox6.Text = dr["VName"].ToString();

            }
            conn.oleDbConnection1.Close();

            conn.oleDbConnection1.Open();
            OleDbCommand cmd1 = new OleDbCommand("Select * from PO where VName = @VName", conn.oleDbConnection1);
            cmd1.Parameters.AddWithValue("VName", textBox6.Text);
            OleDbDataReader dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {
                textBox3.Text = dr1["TotalAmount"].ToString();
                textBox5.Text = dr1["VID"].ToString();

            }
            conn.oleDbConnection1.Close();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {


        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int price = Convert.ToInt32(textBox3.Text);
            int disc = Convert.ToInt32(textBox7.Text);
            int discount = (price * disc) / 100;
            int d = price - discount;
            textBox8.Text = d.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Select *from GRNProducts where GRNID = '" + comboBox1.Text + "'", conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {

                textBox9.Text = dr["PModel"].ToString();
                textBox10.Text = dr["PQty"].ToString();
            }

                conn.oleDbConnection1.Close();
           
        }
    }
}
