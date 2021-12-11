namespace P5_3_1204053
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.lbNIM = new System.Windows.Forms.Label();
            this.lbNama = new System.Windows.Forms.Label();
            this.lbJK = new System.Windows.Forms.Label();
            this.lbAlamat = new System.Windows.Forms.Label();
            this.lbPS = new System.Windows.Forms.Label();
            this.lbTA = new System.Windows.Forms.Label();
            this.lbSms = new System.Windows.Forms.Label();
            this.tbAlamat = new System.Windows.Forms.TextBox();
            this.rbLaki = new System.Windows.Forms.RadioButton();
            this.rbPerempuan = new System.Windows.Forms.RadioButton();
            this.cbProdi = new System.Windows.Forms.ComboBox();
            this.btPilih = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbKurikulum2014 = new System.Windows.Forms.RadioButton();
            this.rbKurikulum2010 = new System.Windows.Forms.RadioButton();
            this.rbKurikulum06 = new System.Windows.Forms.RadioButton();
            this.gbMatkul = new System.Windows.Forms.GroupBox();
            this.cbManagement = new System.Windows.Forms.CheckBox();
            this.cbSO = new System.Windows.Forms.CheckBox();
            this.cbPL = new System.Windows.Forms.CheckBox();
            this.cbJarkom = new System.Windows.Forms.CheckBox();
            this.cbPemrog7 = new System.Windows.Forms.CheckBox();
            this.cbPemrog6 = new System.Windows.Forms.CheckBox();
            this.cbPemrog5 = new System.Windows.Forms.CheckBox();
            this.cbPemrog4 = new System.Windows.Forms.CheckBox();
            this.cbPemrog3 = new System.Windows.Forms.CheckBox();
            this.cbPemrog2 = new System.Windows.Forms.CheckBox();
            this.cbPemrog1 = new System.Windows.Forms.CheckBox();
            this.cbMtk = new System.Windows.Forms.CheckBox();
            this.btSimpan = new System.Windows.Forms.Button();
            this.btBatal = new System.Windows.Forms.Button();
            this.epWrong = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbTA = new System.Windows.Forms.TextBox();
            this.epWarning = new System.Windows.Forms.ErrorProvider(this.components);
            this.Nsemester = new P5_3_1204053.NumericTextBox();
            this.tbNIM = new P5_3_1204053.NumericTextBox();
            this.tbNama = new P5_3_1204053.CharTextBox();
            this.epCorrect = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.gbMatkul.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(420, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "PILIHAN MATA KULIAH MAHASISWA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbNIM
            // 
            this.lbNIM.AutoSize = true;
            this.lbNIM.Location = new System.Drawing.Point(66, 127);
            this.lbNIM.Name = "lbNIM";
            this.lbNIM.Size = new System.Drawing.Size(134, 20);
            this.lbNIM.TabIndex = 1;
            this.lbNIM.Text = "NIM                       :";
            // 
            // lbNama
            // 
            this.lbNama.AutoSize = true;
            this.lbNama.Location = new System.Drawing.Point(61, 180);
            this.lbNama.Name = "lbNama";
            this.lbNama.Size = new System.Drawing.Size(139, 20);
            this.lbNama.TabIndex = 2;
            this.lbNama.Text = "Nama                     :";
            // 
            // lbJK
            // 
            this.lbJK.AutoSize = true;
            this.lbJK.Location = new System.Drawing.Point(61, 228);
            this.lbJK.Name = "lbJK";
            this.lbJK.Size = new System.Drawing.Size(142, 20);
            this.lbJK.TabIndex = 3;
            this.lbJK.Text = "Jenis Kelamin        :";
            // 
            // lbAlamat
            // 
            this.lbAlamat.AutoSize = true;
            this.lbAlamat.Location = new System.Drawing.Point(61, 275);
            this.lbAlamat.Name = "lbAlamat";
            this.lbAlamat.Size = new System.Drawing.Size(159, 20);
            this.lbAlamat.TabIndex = 4;
            this.lbAlamat.Text = "Alamat                    :    ";
            // 
            // lbPS
            // 
            this.lbPS.AutoSize = true;
            this.lbPS.Location = new System.Drawing.Point(591, 127);
            this.lbPS.Name = "lbPS";
            this.lbPS.Size = new System.Drawing.Size(166, 20);
            this.lbPS.TabIndex = 5;
            this.lbPS.Text = "Program Studi             :";
            // 
            // lbTA
            // 
            this.lbTA.AutoSize = true;
            this.lbTA.Location = new System.Drawing.Point(589, 180);
            this.lbTA.Name = "lbTA";
            this.lbTA.Size = new System.Drawing.Size(168, 20);
            this.lbTA.TabIndex = 6;
            this.lbTA.Text = "Tahun Akademik         :";
            // 
            // lbSms
            // 
            this.lbSms.AutoSize = true;
            this.lbSms.Location = new System.Drawing.Point(587, 230);
            this.lbSms.Name = "lbSms";
            this.lbSms.Size = new System.Drawing.Size(170, 20);
            this.lbSms.TabIndex = 7;
            this.lbSms.Text = "Semester                      :";
            // 
            // tbAlamat
            // 
            this.tbAlamat.Location = new System.Drawing.Point(206, 272);
            this.tbAlamat.Multiline = true;
            this.tbAlamat.Name = "tbAlamat";
            this.tbAlamat.Size = new System.Drawing.Size(318, 128);
            this.tbAlamat.TabIndex = 9;
            // 
            // rbLaki
            // 
            this.rbLaki.AutoSize = true;
            this.rbLaki.Location = new System.Drawing.Point(210, 228);
            this.rbLaki.Name = "rbLaki";
            this.rbLaki.Size = new System.Drawing.Size(105, 24);
            this.rbLaki.TabIndex = 10;
            this.rbLaki.TabStop = true;
            this.rbLaki.Text = "Laki - Laki";
            this.rbLaki.UseVisualStyleBackColor = true;
            // 
            // rbPerempuan
            // 
            this.rbPerempuan.AutoSize = true;
            this.rbPerempuan.Location = new System.Drawing.Point(359, 228);
            this.rbPerempuan.Name = "rbPerempuan";
            this.rbPerempuan.Size = new System.Drawing.Size(116, 24);
            this.rbPerempuan.TabIndex = 11;
            this.rbPerempuan.TabStop = true;
            this.rbPerempuan.Text = "Perempuan";
            this.rbPerempuan.UseVisualStyleBackColor = true;
            // 
            // cbProdi
            // 
            this.cbProdi.FormattingEnabled = true;
            this.cbProdi.Items.AddRange(new object[] {
            "Teknik Informatika",
            "Sistem Informasi",
            "Ilmu Komputer"});
            this.cbProdi.Location = new System.Drawing.Point(763, 125);
            this.cbProdi.Name = "cbProdi";
            this.cbProdi.Size = new System.Drawing.Size(248, 28);
            this.cbProdi.TabIndex = 12;
            this.cbProdi.Text = "--Pilih Program Studi--";
            // 
            // btPilih
            // 
            this.btPilih.Location = new System.Drawing.Point(857, 311);
            this.btPilih.Name = "btPilih";
            this.btPilih.Size = new System.Drawing.Size(163, 36);
            this.btPilih.TabIndex = 13;
            this.btPilih.Text = "Pilih Mata Kuliah";
            this.btPilih.UseVisualStyleBackColor = true;
            this.btPilih.Click += new System.EventHandler(this.btPilih_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbKurikulum2014);
            this.groupBox1.Controls.Add(this.rbKurikulum2010);
            this.groupBox1.Controls.Add(this.rbKurikulum06);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(70, 469);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 335);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kurikulum Pilihan";
            // 
            // rbKurikulum2014
            // 
            this.rbKurikulum2014.AutoSize = true;
            this.rbKurikulum2014.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbKurikulum2014.Location = new System.Drawing.Point(54, 250);
            this.rbKurikulum2014.Name = "rbKurikulum2014";
            this.rbKurikulum2014.Size = new System.Drawing.Size(165, 28);
            this.rbKurikulum2014.TabIndex = 2;
            this.rbKurikulum2014.TabStop = true;
            this.rbKurikulum2014.Text = "Kurikulum 2014";
            this.rbKurikulum2014.UseVisualStyleBackColor = true;
            this.rbKurikulum2014.CheckedChanged += new System.EventHandler(this.rbKurikulum2014_CheckedChanged);
            // 
            // rbKurikulum2010
            // 
            this.rbKurikulum2010.AutoSize = true;
            this.rbKurikulum2010.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbKurikulum2010.Location = new System.Drawing.Point(54, 162);
            this.rbKurikulum2010.Name = "rbKurikulum2010";
            this.rbKurikulum2010.Size = new System.Drawing.Size(165, 28);
            this.rbKurikulum2010.TabIndex = 1;
            this.rbKurikulum2010.TabStop = true;
            this.rbKurikulum2010.Text = "Kurikulum 2010";
            this.rbKurikulum2010.UseVisualStyleBackColor = true;
            this.rbKurikulum2010.CheckedChanged += new System.EventHandler(this.rbKurikulum2010_CheckedChanged);
            // 
            // rbKurikulum06
            // 
            this.rbKurikulum06.AutoSize = true;
            this.rbKurikulum06.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbKurikulum06.Location = new System.Drawing.Point(54, 75);
            this.rbKurikulum06.Name = "rbKurikulum06";
            this.rbKurikulum06.Size = new System.Drawing.Size(165, 28);
            this.rbKurikulum06.TabIndex = 0;
            this.rbKurikulum06.TabStop = true;
            this.rbKurikulum06.Text = "Kurikulum 2006";
            this.rbKurikulum06.UseVisualStyleBackColor = true;
            this.rbKurikulum06.CheckedChanged += new System.EventHandler(this.rbKurikulum06_CheckedChanged);
            // 
            // gbMatkul
            // 
            this.gbMatkul.Controls.Add(this.cbManagement);
            this.gbMatkul.Controls.Add(this.cbSO);
            this.gbMatkul.Controls.Add(this.cbPL);
            this.gbMatkul.Controls.Add(this.cbJarkom);
            this.gbMatkul.Controls.Add(this.cbPemrog7);
            this.gbMatkul.Controls.Add(this.cbPemrog6);
            this.gbMatkul.Controls.Add(this.cbPemrog5);
            this.gbMatkul.Controls.Add(this.cbPemrog4);
            this.gbMatkul.Controls.Add(this.cbPemrog3);
            this.gbMatkul.Controls.Add(this.cbPemrog2);
            this.gbMatkul.Controls.Add(this.cbPemrog1);
            this.gbMatkul.Controls.Add(this.cbMtk);
            this.gbMatkul.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMatkul.Location = new System.Drawing.Point(439, 469);
            this.gbMatkul.Name = "gbMatkul";
            this.gbMatkul.Size = new System.Drawing.Size(799, 335);
            this.gbMatkul.TabIndex = 19;
            this.gbMatkul.TabStop = false;
            this.gbMatkul.Text = "Mata Kuliah Pilihan";
            // 
            // cbManagement
            // 
            this.cbManagement.AutoSize = true;
            this.cbManagement.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbManagement.Location = new System.Drawing.Point(534, 225);
            this.cbManagement.Name = "cbManagement";
            this.cbManagement.Size = new System.Drawing.Size(259, 28);
            this.cbManagement.TabIndex = 11;
            this.cbManagement.Text = "Management Rantai Pasok";
            this.cbManagement.UseVisualStyleBackColor = true;
            // 
            // cbSO
            // 
            this.cbSO.AutoSize = true;
            this.cbSO.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSO.Location = new System.Drawing.Point(534, 162);
            this.cbSO.Name = "cbSO";
            this.cbSO.Size = new System.Drawing.Size(160, 28);
            this.cbSO.TabIndex = 10;
            this.cbSO.Text = "Sistem Operasi";
            this.cbSO.UseVisualStyleBackColor = true;
            // 
            // cbPL
            // 
            this.cbPL.AutoSize = true;
            this.cbPL.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPL.Location = new System.Drawing.Point(534, 55);
            this.cbPL.Name = "cbPL";
            this.cbPL.Size = new System.Drawing.Size(187, 28);
            this.cbPL.TabIndex = 9;
            this.cbPL.Text = "Pengantar Logistik";
            this.cbPL.UseVisualStyleBackColor = true;
            // 
            // cbJarkom
            // 
            this.cbJarkom.AutoSize = true;
            this.cbJarkom.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbJarkom.Location = new System.Drawing.Point(534, 113);
            this.cbJarkom.Name = "cbJarkom";
            this.cbJarkom.Size = new System.Drawing.Size(193, 28);
            this.cbJarkom.TabIndex = 8;
            this.cbJarkom.Text = "Jaringan Komputer";
            this.cbJarkom.UseVisualStyleBackColor = true;
            this.cbJarkom.CheckedChanged += new System.EventHandler(this.cbJarkom_CheckedChanged);
            // 
            // cbPemrog7
            // 
            this.cbPemrog7.AutoSize = true;
            this.cbPemrog7.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPemrog7.Location = new System.Drawing.Point(283, 225);
            this.cbPemrog7.Name = "cbPemrog7";
            this.cbPemrog7.Size = new System.Drawing.Size(168, 28);
            this.cbPemrog7.TabIndex = 7;
            this.cbPemrog7.Text = "Pemrograman 7";
            this.cbPemrog7.UseVisualStyleBackColor = true;
            // 
            // cbPemrog6
            // 
            this.cbPemrog6.AutoSize = true;
            this.cbPemrog6.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPemrog6.Location = new System.Drawing.Point(283, 162);
            this.cbPemrog6.Name = "cbPemrog6";
            this.cbPemrog6.Size = new System.Drawing.Size(168, 28);
            this.cbPemrog6.TabIndex = 6;
            this.cbPemrog6.Text = "Pemrograman 6";
            this.cbPemrog6.UseVisualStyleBackColor = true;
            // 
            // cbPemrog5
            // 
            this.cbPemrog5.AutoSize = true;
            this.cbPemrog5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPemrog5.Location = new System.Drawing.Point(283, 114);
            this.cbPemrog5.Name = "cbPemrog5";
            this.cbPemrog5.Size = new System.Drawing.Size(168, 28);
            this.cbPemrog5.TabIndex = 5;
            this.cbPemrog5.Text = "Pemrograman 5";
            this.cbPemrog5.UseVisualStyleBackColor = true;
            // 
            // cbPemrog4
            // 
            this.cbPemrog4.AutoSize = true;
            this.cbPemrog4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPemrog4.Location = new System.Drawing.Point(283, 55);
            this.cbPemrog4.Name = "cbPemrog4";
            this.cbPemrog4.Size = new System.Drawing.Size(168, 28);
            this.cbPemrog4.TabIndex = 4;
            this.cbPemrog4.Text = "Pemrograman 4";
            this.cbPemrog4.UseVisualStyleBackColor = true;
            // 
            // cbPemrog3
            // 
            this.cbPemrog3.AutoSize = true;
            this.cbPemrog3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPemrog3.Location = new System.Drawing.Point(21, 214);
            this.cbPemrog3.Name = "cbPemrog3";
            this.cbPemrog3.Size = new System.Drawing.Size(168, 28);
            this.cbPemrog3.TabIndex = 3;
            this.cbPemrog3.Text = "Pemrograman 3";
            this.cbPemrog3.UseVisualStyleBackColor = true;
            // 
            // cbPemrog2
            // 
            this.cbPemrog2.AutoSize = true;
            this.cbPemrog2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPemrog2.Location = new System.Drawing.Point(21, 162);
            this.cbPemrog2.Name = "cbPemrog2";
            this.cbPemrog2.Size = new System.Drawing.Size(168, 28);
            this.cbPemrog2.TabIndex = 2;
            this.cbPemrog2.Text = "Pemrograman 2";
            this.cbPemrog2.UseVisualStyleBackColor = true;
            // 
            // cbPemrog1
            // 
            this.cbPemrog1.AutoSize = true;
            this.cbPemrog1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPemrog1.Location = new System.Drawing.Point(21, 114);
            this.cbPemrog1.Name = "cbPemrog1";
            this.cbPemrog1.Size = new System.Drawing.Size(168, 28);
            this.cbPemrog1.TabIndex = 1;
            this.cbPemrog1.Text = "Pemrograman 1";
            this.cbPemrog1.UseVisualStyleBackColor = true;
            // 
            // cbMtk
            // 
            this.cbMtk.AutoSize = true;
            this.cbMtk.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMtk.Location = new System.Drawing.Point(21, 55);
            this.cbMtk.Name = "cbMtk";
            this.cbMtk.Size = new System.Drawing.Size(136, 28);
            this.cbMtk.TabIndex = 0;
            this.cbMtk.Text = "Matematika";
            this.cbMtk.UseVisualStyleBackColor = true;
            // 
            // btSimpan
            // 
            this.btSimpan.Location = new System.Drawing.Point(493, 883);
            this.btSimpan.Name = "btSimpan";
            this.btSimpan.Size = new System.Drawing.Size(113, 43);
            this.btSimpan.TabIndex = 20;
            this.btSimpan.Text = "Simpan";
            this.btSimpan.UseVisualStyleBackColor = true;
            this.btSimpan.Click += new System.EventHandler(this.btSimpan_Click);
            // 
            // btBatal
            // 
            this.btBatal.Location = new System.Drawing.Point(651, 883);
            this.btBatal.Name = "btBatal";
            this.btBatal.Size = new System.Drawing.Size(106, 43);
            this.btBatal.TabIndex = 21;
            this.btBatal.Text = "Batal";
            this.btBatal.UseVisualStyleBackColor = true;
            this.btBatal.Click += new System.EventHandler(this.btBatal_Click);
            // 
            // epWrong
            // 
            this.epWrong.ContainerControl = this;
            this.epWrong.Icon = ((System.Drawing.Icon)(resources.GetObject("epWrong.Icon")));
            // 
            // tbTA
            // 
            this.tbTA.Location = new System.Drawing.Point(764, 179);
            this.tbTA.Name = "tbTA";
            this.tbTA.Size = new System.Drawing.Size(247, 26);
            this.tbTA.TabIndex = 25;
            this.tbTA.Leave += new System.EventHandler(this.tbTA_Leave);
            // 
            // epWarning
            // 
            this.epWarning.ContainerControl = this;
            this.epWarning.Icon = ((System.Drawing.Icon)(resources.GetObject("epWarning.Icon")));
            // 
            // Nsemester
            // 
            this.Nsemester.Location = new System.Drawing.Point(763, 230);
            this.Nsemester.Name = "Nsemester";
            this.Nsemester.Size = new System.Drawing.Size(248, 26);
            this.Nsemester.TabIndex = 24;
            // 
            // tbNIM
            // 
            this.tbNIM.Location = new System.Drawing.Point(206, 126);
            this.tbNIM.Name = "tbNIM";
            this.tbNIM.Size = new System.Drawing.Size(282, 26);
            this.tbNIM.TabIndex = 23;
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(210, 180);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(278, 26);
            this.tbNama.TabIndex = 22;
            // 
            // epCorrect
            // 
            this.epCorrect.ContainerControl = this;
            this.epCorrect.Icon = ((System.Drawing.Icon)(resources.GetObject("epCorrect.Icon")));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 435);
            this.Controls.Add(this.tbTA);
            this.Controls.Add(this.Nsemester);
            this.Controls.Add(this.tbNIM);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.btBatal);
            this.Controls.Add(this.btSimpan);
            this.Controls.Add(this.gbMatkul);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btPilih);
            this.Controls.Add(this.cbProdi);
            this.Controls.Add(this.rbPerempuan);
            this.Controls.Add(this.rbLaki);
            this.Controls.Add(this.tbAlamat);
            this.Controls.Add(this.lbSms);
            this.Controls.Add(this.lbTA);
            this.Controls.Add(this.lbPS);
            this.Controls.Add(this.lbAlamat);
            this.Controls.Add(this.lbJK);
            this.Controls.Add(this.lbNama);
            this.Controls.Add(this.lbNIM);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form Pilihan Mata Kuliah Mahasiswa";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbMatkul.ResumeLayout(false);
            this.gbMatkul.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNIM;
        private System.Windows.Forms.Label lbNama;
        private System.Windows.Forms.Label lbJK;
        private System.Windows.Forms.Label lbAlamat;
        private System.Windows.Forms.Label lbPS;
        private System.Windows.Forms.Label lbTA;
        private System.Windows.Forms.Label lbSms;
        private System.Windows.Forms.TextBox tbAlamat;
        private System.Windows.Forms.RadioButton rbLaki;
        private System.Windows.Forms.RadioButton rbPerempuan;
        private System.Windows.Forms.ComboBox cbProdi;
        private System.Windows.Forms.Button btPilih;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbKurikulum2014;
        private System.Windows.Forms.RadioButton rbKurikulum2010;
        private System.Windows.Forms.RadioButton rbKurikulum06;
        private System.Windows.Forms.GroupBox gbMatkul;
        private System.Windows.Forms.CheckBox cbManagement;
        private System.Windows.Forms.CheckBox cbSO;
        private System.Windows.Forms.CheckBox cbPL;
        private System.Windows.Forms.CheckBox cbJarkom;
        private System.Windows.Forms.CheckBox cbPemrog7;
        private System.Windows.Forms.CheckBox cbPemrog6;
        private System.Windows.Forms.CheckBox cbPemrog5;
        private System.Windows.Forms.CheckBox cbPemrog4;
        private System.Windows.Forms.CheckBox cbPemrog3;
        private System.Windows.Forms.CheckBox cbPemrog2;
        private System.Windows.Forms.CheckBox cbPemrog1;
        private System.Windows.Forms.CheckBox cbMtk;
        private System.Windows.Forms.Button btSimpan;
        private System.Windows.Forms.Button btBatal;
        private CharTextBox tbNama;
        private NumericTextBox tbNIM;
        private NumericTextBox Nsemester;
        private System.Windows.Forms.ErrorProvider epWrong;
        private System.Windows.Forms.TextBox tbTA;
        private System.Windows.Forms.ErrorProvider epWarning;
        private System.Windows.Forms.ErrorProvider epCorrect;
    }
}

