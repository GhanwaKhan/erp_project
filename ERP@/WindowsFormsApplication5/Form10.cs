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
    public partial class Form10 : Form
    {
        Form1 conn = new Form1();
        public Form10()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("insert into GRNProducts(GRNID, PModel, PQty)values(@GRNID, @PModel, @PQty);",conn.oleDbConnection1);
            cmd.Parameters.AddWithValue("@GRNID", comboBox1.Text);
            cmd.Parameters.AddWithValue("@PModel", textBox1.Text);
            cmd.Parameters.AddWithValue("@PQty", textBox2.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Your data has been inserted");
            conn.oleDbConnection1.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.Show();
            this.Hide();
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

        private void button4_Click(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("update GRNProducts set PModel=@PModel, PQty=@PQty where GRNID=@GRNID", conn.oleDbConnection1);
            cmd.Parameters.AddWithValue("@PModel", this.textBox1.Text);
            cmd.Parameters.AddWithValue("@PQty", this.textBox2.Text);
            cmd.Parameters.AddWithValue("@GRNID", this.comboBox1.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record has been updated");
            conn.oleDbConnection1.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }
    }
}
