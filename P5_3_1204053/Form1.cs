using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace P5_3_1204053
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string jeniskelamin = "";

        private void tbTA_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(tbTA.Text, @"^\d{4}/\d{4}$"))//Regex Validator
            {
                epCorrect.SetError(tbTA, "CORRECT !");
            }
            else
            {
                epWrong.SetError(tbTA, "Format Tahun Akademik salah!\nContoh:2019/2020");
            }
        }
        private void btPilih_Click(object sender, EventArgs e)
        {

            if (tbNIM.Text == "")
            {
                epWarning.SetError(tbNIM, "Kolom NIM anda harus diisi ! tidak boleh kosong!");
            }
            else
            {
                epCorrect.SetError(tbNIM, "Betul");
            }

            if (tbNama.Text == "")
            {
                epWarning.SetError(tbNama, "Kolom Nama tidak boleh kosong!");
            }
            else
            {
                epCorrect.SetError(tbNama, "Betul!");
            }

            if (rbLaki.Checked)
            {
                jeniskelamin = "Laki - Laki";
            }
            if (rbPerempuan.Checked)
            {
                jeniskelamin = "Perempuan";
            }
            if (jeniskelamin == "")
            {
                MessageBox.Show("Harap diisi jenis kelamin Anda", "Warning !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (tbAlamat.Text == "")
            {
                epWarning.SetError(tbAlamat, "Kolom Alamat Harus diisi, tidak boleh kosong!");
            }
            else
            {
                epCorrect.SetError(tbAlamat, "Betul");
            }


            if (cbProdi.Text == "--Pilih Program Studi--")
            {
                epWarning.SetError(cbProdi, "Pilih Program Studi!"); //Required Validator
            }
            else
            {
                epCorrect.SetError(cbProdi, "Betul");
            }


            if (tbTA.Text == "")
            {
                epWarning.SetError(tbTA, " Kolom Tahun Akademik tidak boleh kosong!"); //Required Validator
            }

            if (tbTA.Text == "")
            {
                epWarning.SetError(tbTA, "Kolom Tahun Akademik tidak boleh kosong!"); 
            }
            if (Nsemester.Text != "")
            {
                epCorrect.SetError(Nsemester, "Benar!");


                MessageBox.Show
                ("Pengisian data Anda sudah lengkap! ", " Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Size = new Size(680, 565);
            }
            else
            {
                epWarning.SetError(Nsemester, "Kolom Semester tidak boleh kosong!");
                MessageBox.Show
                ("Kolom Semester masih kosong, HARAP diisi!",
                " PENDATAAN ",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbJarkom_CheckedChanged(object sender, EventArgs e)
        {

        }



        private void rbKurikulum06_CheckedChanged(object sender, EventArgs e)
        {

            if (rbKurikulum06.Checked)
            {
                cbMtk.Enabled = true; cbMtk.Checked = false;
                cbPemrog1.Enabled = true; cbPemrog1.Checked = false;
                cbPemrog2.Enabled = true; cbPemrog2.Checked = false;
                cbPemrog3.Enabled = true; cbPemrog3.Checked = false;
                cbPemrog4.Enabled = true; cbPemrog4.Checked = false;
                cbPemrog5.Enabled = true; cbPemrog5.Checked = false;
                cbPemrog6.Enabled = true; cbPemrog6.Checked = false;
                cbPemrog7.Enabled = true; cbPemrog7.Checked = false;
                cbPL.Enabled = false; cbPL.Checked = false;
                cbJarkom.Enabled = true; cbJarkom.Checked = false;
                cbSO.Enabled = true; cbSO.Checked = false;
                cbManagement.Enabled = false; cbManagement.Checked = false;
            }
        }

        private void rbKurikulum2010_CheckedChanged(object sender, EventArgs e)
        {

            if (rbKurikulum2010.Checked)
            {
                cbMtk.Enabled = false; cbMtk.Checked = false;
                cbPemrog1.Enabled = true; cbPemrog1.Checked = false;
                cbPemrog2.Enabled = true; cbPemrog2.Checked = false;
                cbPemrog3.Enabled = true; cbPemrog3.Checked = false;
                cbPemrog4.Enabled = true; cbPemrog4.Checked = false;
                cbPemrog5.Enabled = true; cbPemrog5.Checked = false;
                cbPemrog6.Enabled = true; cbPemrog6.Checked = false;
                cbPemrog7.Enabled = true; cbPemrog7.Checked = false;
                cbPL.Enabled = false; cbPL.Checked = false;
                cbJarkom.Enabled = true; cbJarkom.Checked = false;
                cbSO.Enabled = true; cbSO.Checked = false;
                cbManagement.Enabled = true; cbManagement.Checked = false;
            }
        }

        private void rbKurikulum2014_CheckedChanged(object sender, EventArgs e)
        {

            if (rbKurikulum2014.Checked)
            {
                cbMtk.Enabled = false; cbMtk.Checked = false;
                cbPemrog1.Enabled = true; cbPemrog1.Checked = false;
                cbPemrog2.Enabled = true; cbPemrog2.Checked = false;
                cbPemrog3.Enabled = true; cbPemrog3.Checked = false;
                cbPemrog4.Enabled = true; cbPemrog4.Checked = false;
                cbPemrog5.Enabled = true; cbPemrog5.Checked = false;
                cbPemrog6.Enabled = true; cbPemrog6.Checked = false;
                cbPemrog7.Enabled = true; cbPemrog7.Checked = false;
                cbPL.Enabled = true; cbPL.Checked = false;
                cbJarkom.Enabled = true; cbJarkom.Checked = false;
                cbSO.Enabled = true; cbSO.Checked = false;
                cbManagement.Enabled = false; cbManagement.Checked = false;
            }
        }

        private void btSimpan_Click(object sender, EventArgs e)
        {
            string kurikulum = "";
            if (rbKurikulum06.Checked)
            {
                kurikulum = rbKurikulum06.Text;
            }
            else if (rbKurikulum2010.Checked)
            {
                kurikulum = rbKurikulum2010.Text;
            }
            else if (rbKurikulum2014.Checked)
            {
                kurikulum = rbKurikulum2014.Text;
            }

            string matkul = "";
            if (cbMtk.Checked)
            {
                matkul += cbMtk.Text + ",";
            }
            if (cbPemrog1.Checked)
            {
                matkul += cbPemrog1.Text + ",";
            }
            if (cbPemrog2.Checked)
            {
                matkul += cbPemrog2.Text + ",";
            }
            if (cbPemrog3.Checked)
            {
                matkul += cbPemrog3.Text + ",";
            }
            if (cbPemrog4.Checked)
            {
                matkul += cbPemrog4.Text + ",";
            }
            if (cbPemrog5.Checked)
            {
                matkul += cbPemrog5.Text + ",";
            }
            if (cbPemrog6.Checked)
            {
                matkul += cbPemrog6.Text + ",";
            }
            if (cbPemrog7.Checked)
            {
                matkul += cbPemrog7.Text + ",";
            }
            if (cbPL.Checked)
            {
                matkul += cbPL.Text + ",";
            }
            if (cbJarkom.Checked)
            {
                matkul += cbJarkom.Text + ",";
            }
            if (cbSO.Checked)
            {
                matkul += cbSO.Text + ",";
            }
            if (cbManagement.Checked)
            {
                matkul += cbManagement.Text + ",";
            }

            MessageBox.Show
                ("NIM : " + tbNIM.Text +
                "\nNama : " + tbNama.Text +
                "\nJenis Kelamin : " + jeniskelamin +
                "\nAlamat : " + tbAlamat.Text +
                "\nProgram Studi :" + cbProdi.Text +
                "\nTahun Akademik :" + tbTA.Text +
                "\nSemester :" + Nsemester.Text +
                "\nKurikulum : " + kurikulum +
                "\nMata Kuliah : " + matkul,
                "Pendataan Mata Kuliah Mahasiswa POLTEKPOS ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btBatal_Click(object sender, EventArgs e)
        {
            tbNIM.Text = null;
            tbNama.Text = null;
            rbLaki.Checked = false;
            rbPerempuan.Checked = false;
            tbAlamat.Text = null;
            cbProdi.Text = null;
            tbTA.Text = null;
            Nsemester.Text = null;

            rbKurikulum06.Checked = false;
            rbKurikulum2010.Checked = false;
            rbKurikulum2014.Checked = false;

            cbMtk.Enabled = false; cbMtk.Checked = false;
            cbPemrog1.Enabled = false; cbPemrog1.Checked = false;
            cbPemrog2.Enabled = false; cbPemrog2.Checked = false;
            cbPemrog3.Enabled = false; cbPemrog3.Checked = false;
            cbPemrog4.Enabled = false; cbPemrog4.Checked = false;
            cbPemrog5.Enabled = false; cbPemrog5.Checked = false;
            cbPemrog6.Enabled = false; cbPemrog6.Checked = false;
            cbPemrog7.Enabled = false; cbPemrog7.Checked = false;
            cbPL.Enabled = false; cbPL.Checked = false;
            cbJarkom.Enabled = false; cbJarkom.Checked = false;
            cbSO.Enabled = false; cbSO.Checked = false;
            cbManagement.Enabled = false; cbManagement.Checked = false;

            this.Size = new Size(887, 376);

            MessageBox.Show
                        ("Semua isi data telah dihapus, Pengisian Form dibatalkan !",
                        "Batal",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    }
