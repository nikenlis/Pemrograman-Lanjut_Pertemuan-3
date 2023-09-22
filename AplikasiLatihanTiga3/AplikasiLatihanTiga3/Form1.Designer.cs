namespace AplikasiLatihanTiga3
{
    partial class frmLatihanTiga3
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
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstpekerjaan = new System.Windows.Forms.Label();
            this.txtpesan1 = new System.Windows.Forms.TextBox();
            this.txtpesan2 = new System.Windows.Forms.TextBox();
            this.cmbpendidikan = new System.Windows.Forms.ComboBox();
            this.txtpesan3 = new System.Windows.Forms.TextBox();
            this.txtnama = new System.Windows.Forms.TextBox();
            this.btnok = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pendidikan";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "PEDAGANG",
            "PNS",
            "DOSEN",
            "SWASTA",
            "ABRI"});
            this.listBox1.Location = new System.Drawing.Point(118, 75);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(247, 124);
            this.listBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama";
            // 
            // lstpekerjaan
            // 
            this.lstpekerjaan.AutoSize = true;
            this.lstpekerjaan.Location = new System.Drawing.Point(3, 72);
            this.lstpekerjaan.Name = "lstpekerjaan";
            this.lstpekerjaan.Size = new System.Drawing.Size(80, 20);
            this.lstpekerjaan.TabIndex = 2;
            this.lstpekerjaan.Text = "Pekerjaan";
            // 
            // txtpesan1
            // 
            this.txtpesan1.Enabled = false;
            this.txtpesan1.Location = new System.Drawing.Point(118, 214);
            this.txtpesan1.Name = "txtpesan1";
            this.txtpesan1.Size = new System.Drawing.Size(247, 26);
            this.txtpesan1.TabIndex = 6;
            // 
            // txtpesan2
            // 
            this.txtpesan2.Enabled = false;
            this.txtpesan2.Location = new System.Drawing.Point(118, 246);
            this.txtpesan2.Name = "txtpesan2";
            this.txtpesan2.Size = new System.Drawing.Size(247, 26);
            this.txtpesan2.TabIndex = 7;
            // 
            // cmbpendidikan
            // 
            this.cmbpendidikan.FormattingEnabled = true;
            this.cmbpendidikan.Items.AddRange(new object[] {
            "SD",
            "SMP",
            "SMA",
            "DIPLOMA",
            "SARJANA",
            "PASCASARJANA"});
            this.cmbpendidikan.Location = new System.Drawing.Point(118, 40);
            this.cmbpendidikan.Name = "cmbpendidikan";
            this.cmbpendidikan.Size = new System.Drawing.Size(247, 28);
            this.cmbpendidikan.TabIndex = 3;
            // 
            // txtpesan3
            // 
            this.txtpesan3.Enabled = false;
            this.txtpesan3.Location = new System.Drawing.Point(118, 279);
            this.txtpesan3.Name = "txtpesan3";
            this.txtpesan3.Size = new System.Drawing.Size(247, 26);
            this.txtpesan3.TabIndex = 8;
            // 
            // txtnama
            // 
            this.txtnama.Location = new System.Drawing.Point(118, 3);
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(247, 26);
            this.txtnama.TabIndex = 4;
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(118, 320);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(247, 36);
            this.btnok.TabIndex = 9;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.26844F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.73156F));
            this.tableLayoutPanel1.Controls.Add(this.btnok, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtnama, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtpesan3, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.cmbpendidikan, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtpesan2, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtpesan1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lstpekerjaan, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.listBox1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.89286F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.10714F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 139F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(368, 364);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // frmLatihanTiga3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 369);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmLatihanTiga3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Latihan3.3";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lstpekerjaan;
        private System.Windows.Forms.TextBox txtpesan1;
        private System.Windows.Forms.TextBox txtpesan2;
        private System.Windows.Forms.ComboBox cmbpendidikan;
        private System.Windows.Forms.TextBox txtpesan3;
        private System.Windows.Forms.TextBox txtnama;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

