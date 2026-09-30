namespace tugasmodul13
{
    partial class FrmDaftarBelanja
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
            txtItem = new TextBox();
            btnTambah = new Button();
            lstBelanja = new ListBox();
            btnHapus = new Button();
            lblJumlah = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtItem
            // 
            txtItem.Location = new Point(154, 35);
            txtItem.Name = "txtItem";
            txtItem.Size = new Size(297, 31);
            txtItem.TabIndex = 0;
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(154, 285);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(112, 34);
            btnTambah.TabIndex = 1;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = true;
            btnTambah.Click += btnTambah_Click;
            // 
            // lstBelanja
            // 
            lstBelanja.FormattingEnabled = true;
            lstBelanja.Location = new Point(154, 92);
            lstBelanja.Name = "lstBelanja";
            lstBelanja.Size = new Size(297, 129);
            lstBelanja.TabIndex = 2;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(283, 285);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(112, 34);
            btnHapus.TabIndex = 3;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = true;
            btnHapus.Click += btnHapus_Click;
            // 
            // lblJumlah
            // 
            lblJumlah.AutoSize = true;
            lblJumlah.Location = new Point(154, 237);
            lblJumlah.Name = "lblJumlah";
            lblJumlah.Size = new Size(114, 25);
            lblJumlah.TabIndex = 4;
            lblJumlah.Text = "Total Item : 0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 35);
            label1.Name = "label1";
            label1.Size = new Size(119, 25);
            label1.TabIndex = 5;
            label1.Text = "Nama Barang";
            // 
            // FrmDaftarBelanja
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(lblJumlah);
            Controls.Add(btnHapus);
            Controls.Add(lstBelanja);
            Controls.Add(btnTambah);
            Controls.Add(txtItem);
            Name = "FrmDaftarBelanja";
            Text = "Aplikasi Daftar Belanja";
            FormClosing += FrmDaftarBelanja_FormClosing;
            Load += FrmDaftarBelanja_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtItem;
        private Button btnTambah;
        private ListBox lstBelanja;
        private Button btnHapus;
        private Label lblJumlah;
        private Label label1;
    }
}