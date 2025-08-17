namespace TiketBioskop
{
    partial class AdminUsers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminUsers));
            this.label1 = new System.Windows.Forms.Label();
            this.txtcari = new System.Windows.Forms.TextBox();
            this.btnhapus = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.dg_users = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtalamat = new System.Windows.Forms.TextBox();
            this.cbojenkel = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnsimpan = new System.Windows.Forms.Button();
            this.cborole = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtnama = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtpasswrd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnproduk = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnuser = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_users)).BeginInit();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(880, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 23);
            this.label1.TabIndex = 77;
            this.label1.Text = "Cari :";
            this.label1.UseWaitCursor = true;
            // 
            // txtcari
            // 
            this.txtcari.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtcari.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcari.Location = new System.Drawing.Point(942, 410);
            this.txtcari.Name = "txtcari";
            this.txtcari.Size = new System.Drawing.Size(267, 27);
            this.txtcari.TabIndex = 76;
            this.txtcari.UseWaitCursor = true;
            this.txtcari.TextChanged += new System.EventHandler(this.txtcari_TextChanged);
            // 
            // btnhapus
            // 
            this.btnhapus.BackColor = System.Drawing.Color.Red;
            this.btnhapus.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnhapus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnhapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhapus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnhapus.Location = new System.Drawing.Point(1030, 270);
            this.btnhapus.Name = "btnhapus";
            this.btnhapus.Size = new System.Drawing.Size(179, 40);
            this.btnhapus.TabIndex = 74;
            this.btnhapus.Text = "Hapus";
            this.btnhapus.UseVisualStyleBackColor = false;
            this.btnhapus.UseWaitCursor = true;
            this.btnhapus.Click += new System.EventHandler(this.btnhapus_Click);
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.Yellow;
            this.btnedit.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnedit.Location = new System.Drawing.Point(1030, 201);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(179, 40);
            this.btnedit.TabIndex = 73;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.UseWaitCursor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // dg_users
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_users.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dg_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_users.DefaultCellStyle = dataGridViewCellStyle5;
            this.dg_users.Location = new System.Drawing.Point(295, 461);
            this.dg_users.Name = "dg_users";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_users.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dg_users.RowHeadersWidth = 51;
            this.dg_users.RowTemplate.Height = 24;
            this.dg_users.Size = new System.Drawing.Size(914, 239);
            this.dg_users.TabIndex = 72;
            this.dg_users.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dg_users_CellMouseClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(644, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 23);
            this.label10.TabIndex = 67;
            this.label10.Text = "Alamat";
            this.label10.UseWaitCursor = true;
            // 
            // txtphone
            // 
            this.txtphone.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphone.Location = new System.Drawing.Point(648, 201);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(274, 27);
            this.txtphone.TabIndex = 70;
            this.txtphone.UseWaitCursor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(644, 175);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 23);
            this.label11.TabIndex = 69;
            this.label11.Text = "No Telepon";
            this.label11.UseWaitCursor = true;
            // 
            // txtalamat
            // 
            this.txtalamat.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtalamat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtalamat.Location = new System.Drawing.Point(648, 130);
            this.txtalamat.Name = "txtalamat";
            this.txtalamat.Size = new System.Drawing.Size(274, 27);
            this.txtalamat.TabIndex = 68;
            this.txtalamat.UseWaitCursor = true;
            // 
            // cbojenkel
            // 
            this.cbojenkel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbojenkel.FormattingEnabled = true;
            this.cbojenkel.Items.AddRange(new object[] {
            "Laki-laki",
            "Perempuan"});
            this.cbojenkel.Location = new System.Drawing.Point(288, 340);
            this.cbojenkel.Name = "cbojenkel";
            this.cbojenkel.Size = new System.Drawing.Size(274, 29);
            this.cbojenkel.TabIndex = 66;
            this.cbojenkel.UseWaitCursor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(284, 314);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 23);
            this.label9.TabIndex = 65;
            this.label9.Text = "Jenis Kelamin";
            this.label9.UseWaitCursor = true;
            // 
            // btnsimpan
            // 
            this.btnsimpan.BackColor = System.Drawing.Color.Blue;
            this.btnsimpan.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnsimpan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsimpan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnsimpan.Location = new System.Drawing.Point(1030, 135);
            this.btnsimpan.Name = "btnsimpan";
            this.btnsimpan.Size = new System.Drawing.Size(179, 40);
            this.btnsimpan.TabIndex = 64;
            this.btnsimpan.Text = "Tambah";
            this.btnsimpan.UseVisualStyleBackColor = false;
            this.btnsimpan.UseWaitCursor = true;
            this.btnsimpan.Click += new System.EventHandler(this.btnsimpan_Click);
            // 
            // cborole
            // 
            this.cborole.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cborole.FormattingEnabled = true;
            this.cborole.Items.AddRange(new object[] {
            "admin",
            "owner",
            "kasir"});
            this.cborole.Location = new System.Drawing.Point(648, 270);
            this.cborole.Name = "cborole";
            this.cborole.Size = new System.Drawing.Size(274, 29);
            this.cborole.TabIndex = 63;
            this.cborole.UseWaitCursor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(644, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 23);
            this.label8.TabIndex = 62;
            this.label8.Text = "Role";
            this.label8.UseWaitCursor = true;
            // 
            // txtnama
            // 
            this.txtnama.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtnama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnama.Location = new System.Drawing.Point(288, 270);
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(274, 27);
            this.txtnama.TabIndex = 61;
            this.txtnama.UseWaitCursor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(284, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 23);
            this.label7.TabIndex = 60;
            this.label7.Text = "Nama";
            this.label7.UseWaitCursor = true;
            // 
            // txtpasswrd
            // 
            this.txtpasswrd.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtpasswrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpasswrd.Location = new System.Drawing.Point(288, 201);
            this.txtpasswrd.Name = "txtpasswrd";
            this.txtpasswrd.Size = new System.Drawing.Size(274, 27);
            this.txtpasswrd.TabIndex = 59;
            this.txtpasswrd.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(284, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 23);
            this.label6.TabIndex = 58;
            this.label6.Text = "Password";
            this.label6.UseWaitCursor = true;
            // 
            // txtuser
            // 
            this.txtuser.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.Location = new System.Drawing.Point(288, 130);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(274, 27);
            this.txtuser.TabIndex = 57;
            this.txtuser.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(284, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 23);
            this.label5.TabIndex = 56;
            this.label5.Text = "Username";
            this.label5.UseWaitCursor = true;
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
            this.panel1.TabIndex = 83;
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
            this.btnproduk.Click += new System.EventHandler(this.btnproduk_Click);
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
            this.btnuser.Size = new System.Drawing.Size(240, 45);
            this.btnuser.TabIndex = 53;
            this.btnuser.Text = "              Data Pengguna";
            this.btnuser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnuser.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1261, 59);
            this.flowLayoutPanel1.TabIndex = 82;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 38);
            this.label2.TabIndex = 86;
            this.label2.Text = "CINESAS";
            // 
            // AdminUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1261, 712);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcari);
            this.Controls.Add(this.btnhapus);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.dg_users);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtalamat);
            this.Controls.Add(this.cbojenkel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnsimpan);
            this.Controls.Add(this.cborole);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtnama);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtpasswrd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.label5);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "AdminUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Pengguna";
            this.Load += new System.EventHandler(this.AdminUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_users)).EndInit();
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcari;
        private System.Windows.Forms.Button btnhapus;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.DataGridView dg_users;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtalamat;
        private System.Windows.Forms.ComboBox cbojenkel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnsimpan;
        private System.Windows.Forms.ComboBox cborole;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtnama;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtpasswrd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnproduk;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnuser;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
    }
}