namespace tugasmodul13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnsapa_Click(object sender, EventArgs e)
        {
            string nama = txtNama.Text.Trim();
            // Avoid referencing a control that may not exist; assume two-option radio set where not rdoLaki implies female.
            string gender = rdoLaki.Checked ? "Bapak/Saudara" : "Ibu/Saudari";

            if (string.IsNullOrWhiteSpace(nama))
            {
                MessageBox.Show("Silakan masukkan nama Anda terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lblSapaan.Text = $"Halo, Selamat Datang {gender} {nama}!";
        }

        private void txtNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}