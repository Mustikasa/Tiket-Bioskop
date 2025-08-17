namespace TiketBioskop
{
    partial class AdminProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminProduct));
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnuser = new System.Windows.Forms.Button();
            this.btnproduk = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdurasi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtgenre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnhapus = new System.Windows.Forms.Button();
            this.btnubah = new System.Windows.Forms.Button();
            this.btntambah = new System.Windows.Forms.Button();
            this.dg_produk = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txtfilm = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtharga = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcari = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BukaFile = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dg_produk)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.Red;
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
            this.btnuser.Size = new System.Drawing.Size(240, 45);
            this.btnuser.TabIndex = 53;
            this.btnuser.Text = "              Data Pengguna";
            this.btnuser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnuser.UseVisualStyleBackColor = false;
            this.btnuser.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnproduk
            // 
            this.btnproduk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnproduk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnproduk.FlatAppearance.BorderSize = 0;
            this.btnproduk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnproduk.ForeColor = System.Drawing.Color.White;
            this.btnproduk.Image = ((System.Drawing.Image)(resources.GetObject("btnproduk.Image")));
            this.btnproduk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnproduk.Location = new System.Drawing.Point(3, 167);
            this.btnproduk.Name = "btnproduk";
            this.btnproduk.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnproduk.Size = new System.Drawing.Size(237, 45);
            this.btnproduk.TabIndex = 20;
            this.btnproduk.Text = "              Data Film";
            this.btnproduk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnproduk.UseVisualStyleBackColor = false;
            this.btnproduk.Click += new System.EventHandler(this.button7_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(657, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 23);
            this.label3.TabIndex = 70;
            this.label3.Text = "Menit";
            this.label3.UseWaitCursor = true;
            // 
            // txtdurasi
            // 
            this.txtdurasi.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtdurasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdurasi.Location = new System.Drawing.Point(384, 313);
            this.txtdurasi.Name = "txtdurasi";
            this.txtdurasi.Size = new System.Drawing.Size(267, 27);
            this.txtdurasi.TabIndex = 69;
            this.txtdurasi.UseWaitCursor = true;
            this.txtdurasi.TextChanged += new System.EventHandler(this.txtdurasi_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(380, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 23);
            this.label2.TabIndex = 68;
            this.label2.Text = "Durasi";
            this.label2.UseWaitCursor = true;
            // 
            // txtgenre
            // 
            this.txtgenre.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtgenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgenre.Location = new System.Drawing.Point(384, 237);
            this.txtgenre.Name = "txtgenre";
            this.txtgenre.Size = new System.Drawing.Size(267, 27);
            this.txtgenre.TabIndex = 67;
            this.txtgenre.UseWaitCursor = true;
            this.txtgenre.TextChanged += new System.EventHandler(this.txtgenre_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(380, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 23);
            this.label1.TabIndex = 66;
            this.label1.Text = "Genre";
            this.label1.UseWaitCursor = true;
            // 
            // btnhapus
            // 
            this.btnhapus.BackColor = System.Drawing.Color.Red;
            this.btnhapus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnhapus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnhapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhapus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnhapus.Location = new System.Drawing.Point(1036, 297);
            this.btnhapus.Name = "btnhapus";
            this.btnhapus.Size = new System.Drawing.Size(172, 40);
            this.btnhapus.TabIndex = 64;
            this.btnhapus.Text = "Hapus";
            this.btnhapus.UseVisualStyleBackColor = false;
            this.btnhapus.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnubah
            // 
            this.btnubah.BackColor = System.Drawing.Color.Yellow;
            this.btnubah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnubah.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnubah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnubah.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnubah.Location = new System.Drawing.Point(1036, 228);
            this.btnubah.Name = "btnubah";
            this.btnubah.Size = new System.Drawing.Size(172, 40);
            this.btnubah.TabIndex = 63;
            this.btnubah.Text = "Ubah";
            this.btnubah.UseVisualStyleBackColor = false;
            this.btnubah.Click += new System.EventHandler(this.button2_Click);
            // 
            // btntambah
            // 
            this.btntambah.BackColor = System.Drawing.Color.Blue;
            this.btntambah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btntambah.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btntambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntambah.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btntambah.Location = new System.Drawing.Point(1036, 162);
            this.btntambah.Name = "btntambah";
            this.btntambah.Size = new System.Drawing.Size(172, 40);
            this.btntambah.TabIndex = 62;
            this.btntambah.Text = "Tambah";
            this.btntambah.UseVisualStyleBackColor = false;
            this.btntambah.Click += new System.EventHandler(this.button1_Click);
            // 
            // dg_produk
            // 
            this.dg_produk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_produk.Location = new System.Drawing.Point(294, 514);
            this.dg_produk.Name = "dg_produk";
            this.dg_produk.RowHeadersWidth = 51;
            this.dg_produk.RowTemplate.Height = 24;
            this.dg_produk.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_produk.Size = new System.Drawing.Size(914, 214);
            this.dg_produk.TabIndex = 61;
            this.dg_produk.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_produk_CellClick);
            this.dg_produk.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dg_produk_CellMouseClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(381, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 23);
            this.label6.TabIndex = 59;
            this.label6.Text = "Harga Tiket";
            this.label6.UseWaitCursor = true;
            // 
            // txtfilm
            // 
            this.txtfilm.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtfilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfilm.Location = new System.Drawing.Point(385, 162);
            this.txtfilm.Name = "txtfilm";
            this.txtfilm.Size = new System.Drawing.Size(267, 27);
            this.txtfilm.TabIndex = 58;
            this.txtfilm.UseWaitCursor = true;
            this.txtfilm.TextChanged += new System.EventHandler(this.txtfilm_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(381, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 23);
            this.label5.TabIndex = 57;
            this.label5.Text = "Judul Film";
            this.label5.UseWaitCursor = true;
            // 
            // txtharga
            // 
            this.txtharga.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtharga.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtharga.Location = new System.Drawing.Point(385, 388);
            this.txtharga.Name = "txtharga";
            this.txtharga.Size = new System.Drawing.Size(267, 27);
            this.txtharga.TabIndex = 60;
            this.txtharga.UseWaitCursor = true;
            this.txtharga.TextChanged += new System.EventHandler(this.txtharga_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(877, 454);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 23);
            this.label7.TabIndex = 79;
            this.label7.Text = "Cari :";
            this.label7.UseWaitCursor = true;
            // 
            // txtcari
            // 
            this.txtcari.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtcari.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcari.Location = new System.Drawing.Point(941, 453);
            this.txtcari.Name = "txtcari";
            this.txtcari.Size = new System.Drawing.Size(267, 27);
            this.txtcari.TabIndex = 78;
            this.txtcari.UseWaitCursor = true;
            this.txtcari.TextChanged += new System.EventHandler(this.txtcari_TextChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1261, 59);
            this.flowLayoutPanel1.TabIndex = 80;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 38);
            this.label4.TabIndex = 85;
            this.label4.Text = "CINESAS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.btnproduk);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnlogout);
            this.panel1.Controls.Add(this.btnuser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 653);
            this.panel1.TabIndex = 81;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(243, 116);
            this.panel2.TabIndex = 52;
            // 
            // BukaFile
            // 
            this.BukaFile.FileName = "openFileDialog1";
            // 
            // AdminProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1261, 712);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtcari);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtdurasi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtgenre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnhapus);
            this.Controls.Add(this.btnubah);
            this.Controls.Add(this.btntambah);
            this.Controls.Add(this.dg_produk);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtfilm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtharga);
            this.Name = "AdminProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Film";
            this.Load += new System.EventHandler(this.AdminProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_produk)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnuser;
        private System.Windows.Forms.Button btnproduk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdurasi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtgenre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnhapus;
        private System.Windows.Forms.Button btnubah;
        private System.Windows.Forms.Button btntambah;
        private System.Windows.Forms.DataGridView dg_produk;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtfilm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtharga;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtcari;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.OpenFileDialog BukaFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
    }
}