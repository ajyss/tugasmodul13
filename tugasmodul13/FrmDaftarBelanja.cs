using System;
using System.Windows.Forms;

namespace tugasmodul13
{
    public partial class FrmDaftarBelanja : Form
    {
        public FrmDaftarBelanja()
        {
            InitializeComponent();
            UpdateJumlahItem();
        }

        // Method pembantu untuk memperbarui jumlah item otomatis
        private void UpdateJumlahItem()
        {
            lblJumlah.Text = $"Total Item: {lstBelanja.Items.Count}";
        }

        // Event Tambah Item
        private void btnTambah_Click(object sender, EventArgs e)
        {
            string item = txtItem.Text.Trim();
            if (string.IsNullOrWhiteSpace(item))
            {
                MessageBox.Show("Masukkan nama item belanja!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtItem.Focus();
                return;
            }

            lstBelanja.Items.Add(item);
            txtItem.Clear();
            txtItem.Focus();
            UpdateJumlahItem();
        }

        // Event Hapus Item Terpilih
        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (lstBelanja.SelectedIndex != -1)
            {
                lstBelanja.Items.RemoveAt(lstBelanja.SelectedIndex);
                UpdateJumlahItem();
            }
            else
            {
                MessageBox.Show("Pilih item yang ingin dihapus terlebih dahulu.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Event Konfirmasi Saat Form Ditutup
        private void FrmDaftarBelanja_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (lstBelanja.Items.Count > 0)
            {
                var response = MessageBox.Show(
                    "Daftar belanja Anda belum kosong. Yakin ingin keluar?",
                    "Konfirmasi",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (response == DialogResult.No)
                {
                    e.Cancel = true; // Membatalkan penutupan form
                }
            }
        }

        private void FrmDaftarBelanja_Load(object sender, EventArgs e)
        {

        }
    }
}