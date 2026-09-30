namespace tugasmodul13
{
    partial class FrmPendaftaran
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
            label1 = new Label();
            txtNIM = new TextBox();
            cboProdi = new ComboBox();
            chkCoding = new CheckBox();
            btnSimpan = new Button();
            btnReset = new Button();
            txtNama = new TextBox();
            chkDesain = new CheckBox();
            chkMusik = new CheckBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 95);
            label1.Name = "label1";
            label1.Size = new Size(46, 25);
            label1.TabIndex = 0;
            label1.Text = "NIM";
            label1.Click += label1_Click;
            // 
            // txtNIM
            // 
            txtNIM.Location = new Point(118, 92);
            txtNIM.Name = "txtNIM";
            txtNIM.Size = new Size(182, 31);
            txtNIM.TabIndex = 1;
            txtNIM.TextChanged += txtNIM_TextChanged;
            txtNIM.KeyPress += txtNIM_KeyPress_1;
            // 
            // cboProdi
            // 
            cboProdi.AllowDrop = true;
            cboProdi.DisplayMember = "informatika";
            cboProdi.FormattingEnabled = true;
            cboProdi.Items.AddRange(new object[] { "Informatika", "Manajemen", "PGSD" });
            cboProdi.Location = new Point(118, 187);
            cboProdi.Name = "cboProdi";
            cboProdi.Size = new Size(182, 33);
            cboProdi.TabIndex = 2;
            cboProdi.SelectedIndexChanged += cboProdi_SelectedIndexChanged;
            // 
            // chkCoding
            // 
            chkCoding.AutoSize = true;
            chkCoding.Location = new Point(153, 238);
            chkCoding.Name = "chkCoding";
            chkCoding.Size = new Size(96, 29);
            chkCoding.TabIndex = 3;
            chkCoding.Text = "Coding";
            chkCoding.UseVisualStyleBackColor = true;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(174, 327);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(112, 34);
            btnSimpan.TabIndex = 4;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(45, 327);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(112, 34);
            btnReset.TabIndex = 5;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(118, 138);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(182, 31);
            txtNama.TabIndex = 6;
            // 
            // chkDesain
            // 
            chkDesain.AutoSize = true;
            chkDesain.Location = new Point(276, 238);
            chkDesain.Name = "chkDesain";
            chkDesain.Size = new Size(91, 29);
            chkDesain.TabIndex = 7;
            chkDesain.Text = "Desain";
            chkDesain.UseVisualStyleBackColor = true;
            // 
            // chkMusik
            // 
            chkMusik.AutoSize = true;
            chkMusik.Location = new Point(45, 238);
            chkMusik.Name = "chkMusik";
            chkMusik.Size = new Size(85, 29);
            chkMusik.TabIndex = 8;
            chkMusik.Text = "Musik";
            chkMusik.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 141);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 9;
            label2.Text = "Nama";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 190);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 10;
            label3.Text = "Prodi";
            // 
            // FrmPendaftaran
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(chkMusik);
            Controls.Add(chkDesain);
            Controls.Add(txtNama);
            Controls.Add(btnReset);
            Controls.Add(btnSimpan);
            Controls.Add(chkCoding);
            Controls.Add(cboProdi);
            Controls.Add(txtNIM);
            Controls.Add(label1);
            Name = "FrmPendaftaran";
            Text = "FrmPendaftaran";
            Load += FrmPendaftaran_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNIM;
        private ComboBox cboProdi;
        private CheckBox chkCoding;
        private Button btnSimpan;
        private Button btnReset;
        private TextBox txtNama;
        private CheckBox chkDesain;
        private CheckBox chkMusik;
        private Label label2;
        private Label label3;
    }
}