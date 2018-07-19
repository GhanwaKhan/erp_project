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
    public partial class Form2 : Form
    {
        Form1 conn = new Form1();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 f1=new Form1();
            f1.Show();
            f1.textBox1.Visible = false;
            f1.textBox2.Visible = false;
            f1.label1.Visible = false;
            f1.label2.Visible = false;
            f1.button1.Visible = false;
            f1.button2.Visible = false;
            f1.menuStrip1.Enabled = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select CID from Customer where CStatus='Active'", conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["CID"]).ToString();
            }
            conn.oleDbConnection1.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select * from Customer where CID='" + comboBox1.Text + "'", conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read()) 
            {
                textBox1.Text = dr["Cname"].ToString();
                textBox2.Text = dr["CAddress"].ToString();
                textBox3.Text = dr["City"].ToString();
                textBox4.Text = dr["PH1"].ToString();
                textBox5.Text = dr["PH2"].ToString();
                textBox6.Text = dr["ContectPerson"].ToString();
                textBox7.Text = dr["CPPH"].ToString();
                textBox8.Text = dr["CEmail"].ToString();
                textBox9.Text = dr["CreditLimit"].ToString();
                textBox10.Text = dr["CStatus"].ToString();
                textBox11.Text = dr["CGroup"].ToString();
            }
            conn.oleDbConnection1.Close();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Update Customer set CName=@CName, CAddress=@CAddress, City=@City, PH1=@PH1, PH2=@PH2, ContectPerson=@ContectPerson, CPPH=@CPPH, CEmail=@CEmail, CreditLimit=@CreditLimit, CGroup=@CGroup where CID=@CID", conn.oleDbConnection1);
            cmd.Parameters.AddWithValue("@CName", textBox1.Text);
            cmd.Parameters.AddWithValue("@CAddress", textBox2.Text);
            cmd.Parameters.AddWithValue("@City", textBox3.Text);
            cmd.Parameters.AddWithValue("@PH1", textBox4.Text);
            cmd.Parameters.AddWithValue("@PH2", textBox5.Text);
            cmd.Parameters.AddWithValue("@ContectPerson", textBox6.Text);
            cmd.Parameters.AddWithValue("@CPPH", textBox7.Text);
            cmd.Parameters.AddWithValue("@CEmail", textBox8.Text);
            cmd.Parameters.AddWithValue("@CreditLimit", textBox9.Text);
            cmd.Parameters.AddWithValue("@CGroup", textBox11.Text);
            cmd.Parameters.AddWithValue("@CID", comboBox1.Text);
      
            cmd.ExecuteNonQuery();

            MessageBox.Show("Customer has been updated");
            conn.oleDbConnection1.Close();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select * from Customer", conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            conn.oleDbConnection1.Close();
        }
    }
}
