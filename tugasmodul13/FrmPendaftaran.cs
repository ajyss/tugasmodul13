using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace tugasmodul13
{
    public partial class FrmPendaftaran : Form
    {
        public FrmPendaftaran()
        {
            InitializeComponent();
        }

        private void FrmPendaftaran_Load(object sender, EventArgs e)
        {
            // Mengisi pilihan di ComboBox Program Studi
            cboProdi.Items.AddRange(new object[] {
                "Teknik Informatika",
                "Sistem Informasi",
                "Teknik Industri",
                "Manajemen"
            });
            cboProdi.SelectedIndex = -1;
        }

        // Membatasi input NIM hanya angka dan backspace
        private void txtNIM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Tolak karakter selain angka
            }
        }

        // Event saat tombol Simpan diklik
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNIM.Text))
            {
                MessageBox.Show("NIM wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNIM.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNama.Text))
            {
                MessageBox.Show("Nama wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNama.Focus();
                return;
            }

            if (cboProdi.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih Program Studi terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboProdi.Focus();
                return;
            }

            List<string> minat = new List<string>();
            if (chkCoding.Checked) minat.Add("Coding");
            if (chkDesain.Checked) minat.Add("Desain");
            if (chkMusik.Checked) minat.Add("Musik");

            string daftarMinat = minat.Count > 0 ? string.Join(", ", minat) : "Tidak ada";

            MessageBox.Show($"Pendaftaran Berhasil!\n\n" +
                            $"NIM: {txtNIM.Text}\n" +
                            $"Nama: {txtNama.Text}\n" +
                            $"Prodi: {cboProdi.SelectedItem}\n" +
                            $"Minat: {daftarMinat}",
                            "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Event saat tombol Reset diklik
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtNIM.Clear();
            txtNama.Clear();
            cboProdi.SelectedIndex = -1;
            chkCoding.Checked = false;
            chkDesain.Checked = false;
            chkMusik.Checked = false;
            txtNIM.Focus();
        }

        private void FrmPendaftaran_Load_1(object sender, EventArgs e)
        {

        }

        private void txtNIM_KeyPress_1(object sender, KeyPressEventArgs e)
        {

        }

        private void cboProdi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNIM_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}