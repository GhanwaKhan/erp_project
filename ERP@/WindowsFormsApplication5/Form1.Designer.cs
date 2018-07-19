namespace WindowsFormsApplication5
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mENUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoicePayableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellingCycleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesOrderProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goodsSellingNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.oleDbConnection2 = new System.Data.OleDb.OleDbConnection();
            this.invoiceReceivableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseOrderProductToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.goodReceivingNoteProductsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.goodReceivingNoteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.invoicePayableToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 384);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Enabled = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mENUToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(200, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mENUToolStripMenuItem
            // 
            this.mENUToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productsToolStripMenuItem,
            this.invoicePayableToolStripMenuItem,
            this.sellingCycleToolStripMenuItem});
            this.mENUToolStripMenuItem.Name = "mENUToolStripMenuItem";
            this.mENUToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.mENUToolStripMenuItem.Text = "MENU";
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.productsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.productsToolStripMenuItem.Text = "Products";
            this.productsToolStripMenuItem.Click += new System.EventHandler(this.productsToolStripMenuItem_Click_1);
            // 
            // invoicePayableToolStripMenuItem
            // 
            this.invoicePayableToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.invoicePayableToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchaseOrderToolStripMenuItem,
            this.vendorToolStripMenuItem1,
            this.purchaseOrderProductToolStripMenuItem2,
            this.goodReceivingNoteProductsToolStripMenuItem1,
            this.goodReceivingNoteToolStripMenuItem1,
            this.invoicePayableToolStripMenuItem1});
            this.invoicePayableToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.invoicePayableToolStripMenuItem.Name = "invoicePayableToolStripMenuItem";
            this.invoicePayableToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.invoicePayableToolStripMenuItem.Text = "Purchase Cycle";
            this.invoicePayableToolStripMenuItem.Click += new System.EventHandler(this.invoicePayableToolStripMenuItem_Click);
            // 
            // sellingCycleToolStripMenuItem
            // 
            this.sellingCycleToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.sellingCycleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerToolStripMenuItem,
            this.salesOrderToolStripMenuItem,
            this.salesOrderProductToolStripMenuItem,
            this.goodsSellingNoteToolStripMenuItem,
            this.invoiceReceivableToolStripMenuItem});
            this.sellingCycleToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.sellingCycleToolStripMenuItem.Name = "sellingCycleToolStripMenuItem";
            this.sellingCycleToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.sellingCycleToolStripMenuItem.Text = "Sales Cycle";
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.customerToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.customerToolStripMenuItem.Text = "Customer";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // salesOrderToolStripMenuItem
            // 
            this.salesOrderToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.salesOrderToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.salesOrderToolStripMenuItem.Name = "salesOrderToolStripMenuItem";
            this.salesOrderToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.salesOrderToolStripMenuItem.Text = "Sales Order";
            this.salesOrderToolStripMenuItem.Click += new System.EventHandler(this.salesOrderToolStripMenuItem_Click);
            // 
            // salesOrderProductToolStripMenuItem
            // 
            this.salesOrderProductToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.salesOrderProductToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.salesOrderProductToolStripMenuItem.Name = "salesOrderProductToolStripMenuItem";
            this.salesOrderProductToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.salesOrderProductToolStripMenuItem.Text = "Sales Order Product";
            this.salesOrderProductToolStripMenuItem.Click += new System.EventHandler(this.salesOrderProductToolStripMenuItem_Click);
            // 
            // goodsSellingNoteToolStripMenuItem
            // 
            this.goodsSellingNoteToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.goodsSellingNoteToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.goodsSellingNoteToolStripMenuItem.Name = "goodsSellingNoteToolStripMenuItem";
            this.goodsSellingNoteToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.goodsSellingNoteToolStripMenuItem.Text = "Delivery Chalan";
            this.goodsSellingNoteToolStripMenuItem.Click += new System.EventHandler(this.goodsSellingNoteToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(361, 151);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(361, 192);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(194, 20);
            this.textBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(288, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "User ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(288, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(263, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(339, 40);
            this.label3.TabIndex = 5;
            this.label3.Text = "WELCOME TO ERP";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(371, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(468, 245);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // oleDbConnection1
            // 
            this.oleDbConnection1.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\khan\\Desktop\\ERP-purchasin" +
    "g.accdb";
            // 
            // oleDbConnection2
            // 
            this.oleDbConnection2.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\khan\\Desktop\\ERp selling " +
    "- Copy.accdb\"";
            // 
            // invoiceReceivableToolStripMenuItem
            // 
            this.invoiceReceivableToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.invoiceReceivableToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.invoiceReceivableToolStripMenuItem.Name = "invoiceReceivableToolStripMenuItem";
            this.invoiceReceivableToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.invoiceReceivableToolStripMenuItem.Text = "Invoice Receivable";
            this.invoiceReceivableToolStripMenuItem.Click += new System.EventHandler(this.invoiceReceivableToolStripMenuItem_Click);
            // 
            // purchaseOrderToolStripMenuItem
            // 
            this.purchaseOrderToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.purchaseOrderToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.purchaseOrderToolStripMenuItem.Name = "purchaseOrderToolStripMenuItem";
            this.purchaseOrderToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.purchaseOrderToolStripMenuItem.Text = "Purchase Order";
            this.purchaseOrderToolStripMenuItem.Click += new System.EventHandler(this.purchaseOrderToolStripMenuItem_Click);
            // 
            // vendorToolStripMenuItem1
            // 
            this.vendorToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.vendorToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem1,
            this.updateToolStripMenuItem1,
            this.insertToolStripMenuItem1});
            this.vendorToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.vendorToolStripMenuItem1.Name = "vendorToolStripMenuItem1";
            this.vendorToolStripMenuItem1.Size = new System.Drawing.Size(236, 22);
            this.vendorToolStripMenuItem1.Text = "Vendor";
            // 
            // searchToolStripMenuItem1
            // 
            this.searchToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.searchToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.searchToolStripMenuItem1.Name = "searchToolStripMenuItem1";
            this.searchToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.searchToolStripMenuItem1.Text = "Search";
            this.searchToolStripMenuItem1.Click += new System.EventHandler(this.searchToolStripMenuItem1_Click);
            // 
            // updateToolStripMenuItem1
            // 
            this.updateToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.updateToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.updateToolStripMenuItem1.Name = "updateToolStripMenuItem1";
            this.updateToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.updateToolStripMenuItem1.Text = "Update";
            this.updateToolStripMenuItem1.Click += new System.EventHandler(this.updateToolStripMenuItem1_Click);
            // 
            // insertToolStripMenuItem1
            // 
            this.insertToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.insertToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.insertToolStripMenuItem1.Name = "insertToolStripMenuItem1";
            this.insertToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.insertToolStripMenuItem1.Text = "Insert";
            this.insertToolStripMenuItem1.Click += new System.EventHandler(this.insertToolStripMenuItem1_Click);
            // 
            // purchaseOrderProductToolStripMenuItem2
            // 
            this.purchaseOrderProductToolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.purchaseOrderProductToolStripMenuItem2.ForeColor = System.Drawing.Color.White;
            this.purchaseOrderProductToolStripMenuItem2.Name = "purchaseOrderProductToolStripMenuItem2";
            this.purchaseOrderProductToolStripMenuItem2.Size = new System.Drawing.Size(236, 22);
            this.purchaseOrderProductToolStripMenuItem2.Text = "Purchase Order Product";
            this.purchaseOrderProductToolStripMenuItem2.Click += new System.EventHandler(this.purchaseOrderProductToolStripMenuItem2_Click);
            // 
            // goodReceivingNoteProductsToolStripMenuItem1
            // 
            this.goodReceivingNoteProductsToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.goodReceivingNoteProductsToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.goodReceivingNoteProductsToolStripMenuItem1.Name = "goodReceivingNoteProductsToolStripMenuItem1";
            this.goodReceivingNoteProductsToolStripMenuItem1.Size = new System.Drawing.Size(236, 22);
            this.goodReceivingNoteProductsToolStripMenuItem1.Text = "Good Receiving Note Products";
            this.goodReceivingNoteProductsToolStripMenuItem1.Click += new System.EventHandler(this.goodReceivingNoteProductsToolStripMenuItem1_Click);
            // 
            // goodReceivingNoteToolStripMenuItem1
            // 
            this.goodReceivingNoteToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.goodReceivingNoteToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.goodReceivingNoteToolStripMenuItem1.Name = "goodReceivingNoteToolStripMenuItem1";
            this.goodReceivingNoteToolStripMenuItem1.Size = new System.Drawing.Size(236, 22);
            this.goodReceivingNoteToolStripMenuItem1.Text = "Good Receiving Note";
            this.goodReceivingNoteToolStripMenuItem1.Click += new System.EventHandler(this.goodReceivingNoteToolStripMenuItem1_Click);
            // 
            // invoicePayableToolStripMenuItem1
            // 
            this.invoicePayableToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.invoicePayableToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.invoicePayableToolStripMenuItem1.Name = "invoicePayableToolStripMenuItem1";
            this.invoicePayableToolStripMenuItem1.Size = new System.Drawing.Size(236, 22);
            this.invoicePayableToolStripMenuItem1.Text = "Invoice Payable";
            this.invoicePayableToolStripMenuItem1.Click += new System.EventHandler(this.invoicePayableToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(690, 384);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.ToolStripMenuItem mENUToolStripMenuItem;
        public System.Data.OleDb.OleDbConnection oleDbConnection1;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invoicePayableToolStripMenuItem;
        public System.Data.OleDb.OleDbConnection oleDbConnection2;
        private System.Windows.Forms.ToolStripMenuItem sellingCycleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesOrderToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesOrderProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goodsSellingNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invoiceReceivableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem purchaseOrderProductToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem goodReceivingNoteProductsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem goodReceivingNoteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem invoicePayableToolStripMenuItem1;
    }
}

