namespace TiketBioskop
{
    partial class KasirDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KasirDashboard));
            this.txtdurasi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtgenre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtfilm = new System.Windows.Forms.TextBox();
            this.txtharga = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtkmbali = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnsimpan = new System.Windows.Forms.Button();
            this.txtbayar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtnomorunik = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtnama = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbostudio = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnuser = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.cbokursi = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtresult = new System.Windows.Forms.RichTextBox();
            this.btncetak = new System.Windows.Forms.Button();
            this.btngenerate = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtdurasi
            // 
            this.txtdurasi.Enabled = false;
            this.txtdurasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdurasi.Location = new System.Drawing.Point(420, 420);
            this.txtdurasi.Name = "txtdurasi";
            this.txtdurasi.Size = new System.Drawing.Size(267, 27);
            this.txtdurasi.TabIndex = 94;
            this.txtdurasi.UseWaitCursor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(259, 420);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 23);
            this.label8.TabIndex = 93;
            this.label8.Text = "Durasi";
            this.label8.UseWaitCursor = true;
            // 
            // txtgenre
            // 
            this.txtgenre.BackColor = System.Drawing.SystemColors.Window;
            this.txtgenre.Enabled = false;
            this.txtgenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgenre.Location = new System.Drawing.Point(420, 365);
            this.txtgenre.Name = "txtgenre";
            this.txtgenre.Size = new System.Drawing.Size(267, 27);
            this.txtgenre.TabIndex = 92;
            this.txtgenre.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(256, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 23);
            this.label3.TabIndex = 91;
            this.label3.Text = "Genre";
            this.label3.UseWaitCursor = true;
            // 
            // txtfilm
            // 
            this.txtfilm.Enabled = false;
            this.txtfilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfilm.Location = new System.Drawing.Point(420, 308);
            this.txtfilm.Name = "txtfilm";
            this.txtfilm.Size = new System.Drawing.Size(174, 27);
            this.txtfilm.TabIndex = 90;
            this.txtfilm.UseWaitCursor = true;
            this.txtfilm.TextChanged += new System.EventHandler(this.txtfilm_TextChanged);
            // 
            // txtharga
            // 
            this.txtharga.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtharga.Enabled = false;
            this.txtharga.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtharga.Location = new System.Drawing.Point(420, 492);
            this.txtharga.Name = "txtharga";
            this.txtharga.Size = new System.Drawing.Size(267, 27);
            this.txtharga.TabIndex = 89;
            this.txtharga.UseWaitCursor = true;
            this.txtharga.TextChanged += new System.EventHandler(this.txtharga_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(259, 492);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 23);
            this.label2.TabIndex = 88;
            this.label2.Text = "Harga";
            this.label2.UseWaitCursor = true;
            // 
            // txttotal
            // 
            this.txttotal.Enabled = false;
            this.txttotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.Location = new System.Drawing.Point(420, 548);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(267, 27);
            this.txttotal.TabIndex = 87;
            this.txttotal.UseWaitCursor = true;
            this.txttotal.TextChanged += new System.EventHandler(this.txttotal_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(259, 548);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 23);
            this.label1.TabIndex = 86;
            this.label1.Text = "Total";
            this.label1.UseWaitCursor = true;
            // 
            // txtkmbali
            // 
            this.txtkmbali.Enabled = false;
            this.txtkmbali.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkmbali.Location = new System.Drawing.Point(420, 655);
            this.txtkmbali.Name = "txtkmbali";
            this.txtkmbali.Size = new System.Drawing.Size(267, 27);
            this.txtkmbali.TabIndex = 85;
            this.txtkmbali.UseWaitCursor = true;
            this.txtkmbali.TextChanged += new System.EventHandler(this.txtkmbali_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(600, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 27);
            this.button1.TabIndex = 84;
            this.button1.Text = "Pilih Film";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(256, 308);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 23);
            this.label10.TabIndex = 83;
            this.label10.Text = "Judul Film";
            this.label10.UseWaitCursor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(256, 655);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 23);
            this.label9.TabIndex = 82;
            this.label9.Text = "Uang Kembali";
            this.label9.UseWaitCursor = true;
            // 
            // btnsimpan
            // 
            this.btnsimpan.BackColor = System.Drawing.Color.Blue;
            this.btnsimpan.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnsimpan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsimpan.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsimpan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnsimpan.Location = new System.Drawing.Point(951, 603);
            this.btnsimpan.Name = "btnsimpan";
            this.btnsimpan.Size = new System.Drawing.Size(164, 40);
            this.btnsimpan.TabIndex = 81;
            this.btnsimpan.Text = "Simpan";
            this.btnsimpan.UseVisualStyleBackColor = false;
            this.btnsimpan.UseWaitCursor = true;
            this.btnsimpan.Click += new System.EventHandler(this.btnsimpan_Click);
            // 
            // txtbayar
            // 
            this.txtbayar.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtbayar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbayar.Location = new System.Drawing.Point(420, 603);
            this.txtbayar.Name = "txtbayar";
            this.txtbayar.Size = new System.Drawing.Size(267, 27);
            this.txtbayar.TabIndex = 80;
            this.txtbayar.UseWaitCursor = true;
            this.txtbayar.TextChanged += new System.EventHandler(this.txtbayar_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(259, 603);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 23);
            this.label7.TabIndex = 79;
            this.label7.Text = "Uang Bayar";
            this.label7.UseWaitCursor = true;
            // 
            // txtnomorunik
            // 
            this.txtnomorunik.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnomorunik.Enabled = false;
            this.txtnomorunik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnomorunik.Location = new System.Drawing.Point(420, 90);
            this.txtnomorunik.Name = "txtnomorunik";
            this.txtnomorunik.Size = new System.Drawing.Size(267, 27);
            this.txtnomorunik.TabIndex = 78;
            this.txtnomorunik.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(256, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 23);
            this.label6.TabIndex = 77;
            this.label6.Text = "Kode Transaksi";
            this.label6.UseWaitCursor = true;
            // 
            // txtnama
            // 
            this.txtnama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnama.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtnama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnama.Location = new System.Drawing.Point(420, 148);
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(267, 27);
            this.txtnama.TabIndex = 76;
            this.txtnama.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(256, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 23);
            this.label5.TabIndex = 75;
            this.label5.Text = "Nama Pembeli";
            this.label5.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(693, 420);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 27);
            this.label4.TabIndex = 97;
            this.label4.Text = "Menit";
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(385, 308);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(29, 27);
            this.txtid.TabIndex = 98;
            this.txtid.UseWaitCursor = true;
            this.txtid.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(256, 201);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 23);
            this.label11.TabIndex = 99;
            this.label11.Text = "Studio";
            this.label11.UseWaitCursor = true;
            // 
            // cbostudio
            // 
            this.cbostudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbostudio.FormattingEnabled = true;
            this.cbostudio.Items.AddRange(new object[] {
            "Cinemax",
            "Cineplex"});
            this.cbostudio.Location = new System.Drawing.Point(420, 201);
            this.cbostudio.Name = "cbostudio";
            this.cbostudio.Size = new System.Drawing.Size(267, 28);
            this.cbostudio.TabIndex = 100;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnlogout);
            this.panel1.Controls.Add(this.btnuser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 653);
            this.panel1.TabIndex = 102;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(243, 116);
            this.panel2.TabIndex = 52;
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.Red;
            this.btnlogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogout.FlatAppearance.BorderSize = 0;
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogout.ForeColor = System.Drawing.Color.White;
            this.btnlogout.Image = ((System.Drawing.Image)(resources.GetObject("btnlogout.Image")));
            this.btnlogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlogout.Location = new System.Drawing.Point(0, 596);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnlogout.Size = new System.Drawing.Size(236, 45);
            this.btnlogout.TabIndex = 54;
            this.btnlogout.Text = "              Keluar";
            this.btnlogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btnuser
            // 
            this.btnuser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnuser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnuser.FlatAppearance.BorderSize = 0;
            this.btnuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnuser.ForeColor = System.Drawing.Color.White;
            this.btnuser.Image = ((System.Drawing.Image)(resources.GetObject("btnuser.Image")));
            this.btnuser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnuser.Location = new System.Drawing.Point(0, 122);
            this.btnuser.Name = "btnuser";
            this.btnuser.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnuser.Size = new System.Drawing.Size(236, 45);
            this.btnuser.TabIndex = 53;
            this.btnuser.Text = "              Transaksi";
            this.btnuser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnuser.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.flowLayoutPanel1.Controls.Add(this.label12);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1261, 59);
            this.flowLayoutPanel1.TabIndex = 101;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 38);
            this.label12.TabIndex = 103;
            this.label12.Text = "CINESAS";
            // 
            // cbokursi
            // 
            this.cbokursi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbokursi.FormattingEnabled = true;
            this.cbokursi.Items.AddRange(new object[] {
            "A1",
            "A2",
            "A3",
            "A4",
            "A5",
            "A6",
            "A7",
            "A8",
            "A9",
            "A10"});
            this.cbokursi.Location = new System.Drawing.Point(420, 254);
            this.cbokursi.Name = "cbokursi";
            this.cbokursi.Size = new System.Drawing.Size(267, 28);
            this.cbokursi.TabIndex = 104;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(256, 254);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 23);
            this.label13.TabIndex = 103;
            this.label13.Text = "Nomor Kursi";
            this.label13.UseWaitCursor = true;
            // 
            // txtresult
            // 
            this.txtresult.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtresult.Location = new System.Drawing.Point(842, 94);
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(380, 437);
            this.txtresult.TabIndex = 105;
            this.txtresult.Text = "";
            this.txtresult.TextChanged += new System.EventHandler(this.txtresult_TextChanged);
            // 
            // btncetak
            // 
            this.btncetak.BackColor = System.Drawing.Color.Red;
            this.btncetak.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btncetak.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncetak.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncetak.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btncetak.Image = ((System.Drawing.Image)(resources.GetObject("btncetak.Image")));
            this.btncetak.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncetak.Location = new System.Drawing.Point(1058, 548);
            this.btncetak.Name = "btncetak";
            this.btncetak.Size = new System.Drawing.Size(164, 40);
            this.btncetak.TabIndex = 106;
            this.btncetak.Text = "Cetak";
            this.btncetak.UseVisualStyleBackColor = false;
            this.btncetak.UseWaitCursor = true;
            this.btncetak.Click += new System.EventHandler(this.btncetak_Click);
            // 
            // btngenerate
            // 
            this.btngenerate.BackColor = System.Drawing.Color.Yellow;
            this.btngenerate.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btngenerate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btngenerate.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngenerate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btngenerate.Location = new System.Drawing.Point(842, 548);
            this.btngenerate.Name = "btngenerate";
            this.btngenerate.Size = new System.Drawing.Size(164, 40);
            this.btngenerate.TabIndex = 107;
            this.btngenerate.Text = "Tampilkan Nota";
            this.btngenerate.UseVisualStyleBackColor = false;
            this.btngenerate.UseWaitCursor = true;
            this.btngenerate.Click += new System.EventHandler(this.btngenerate_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // KasirDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1261, 712);
            this.Controls.Add(this.btngenerate);
            this.Controls.Add(this.btncetak);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.cbokursi);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.cbostudio);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtdurasi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtgenre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtfilm);
            this.Controls.Add(this.txtharga);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtkmbali);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnsimpan);
            this.Controls.Add(this.txtbayar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtnomorunik);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtnama);
            this.Controls.Add(this.label5);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "KasirDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Halaman Transaksi";
            this.Load += new System.EventHandler(this.KasirDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtdurasi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtgenre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtfilm;
        private System.Windows.Forms.TextBox txtharga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtkmbali;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnsimpan;
        private System.Windows.Forms.TextBox txtbayar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtnomorunik;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtnama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbostudio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnuser;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbokursi;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox txtresult;
        private System.Windows.Forms.Button btncetak;
        private System.Windows.Forms.Button btngenerate;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}