namespace tugasmodul13
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtNama = new TextBox();
            rdoLaki = new RadioButton();
            btnsapa = new Button();
            rdperempuan = new RadioButton();
            lblSapaan = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 101);
            label1.Name = "label1";
            label1.Size = new Size(56, 25);
            label1.TabIndex = 0;
            label1.Text = "name";
            label1.Click += label1_Click;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(129, 101);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(150, 31);
            txtNama.TabIndex = 1;
            txtNama.TextChanged += txtNama_TextChanged;
            // 
            // rdoLaki
            // 
            rdoLaki.AutoSize = true;
            rdoLaki.Location = new Point(233, 266);
            rdoLaki.Name = "rdoLaki";
            rdoLaki.Size = new Size(96, 29);
            rdoLaki.TabIndex = 2;
            rdoLaki.TabStop = true;
            rdoLaki.Text = "laki-laki";
            rdoLaki.UseVisualStyleBackColor = true;
            rdoLaki.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // btnsapa
            // 
            btnsapa.Location = new Point(129, 154);
            btnsapa.Name = "btnsapa";
            btnsapa.Size = new Size(112, 34);
            btnsapa.TabIndex = 4;
            btnsapa.Text = "Sapa Saya";
            btnsapa.UseVisualStyleBackColor = true;
            btnsapa.Click += btnsapa_Click;
            // 
            // rdperempuan
            // 
            rdperempuan.AutoSize = true;
            rdperempuan.Location = new Point(70, 266);
            rdperempuan.Name = "rdperempuan";
            rdperempuan.Size = new Size(128, 29);
            rdperempuan.TabIndex = 5;
            rdperempuan.TabStop = true;
            rdperempuan.Text = "perempuan";
            rdperempuan.UseVisualStyleBackColor = true;
            rdperempuan.CheckedChanged += radioButton1_CheckedChanged_1;
            // 
            // lblSapaan
            // 
            lblSapaan.AutoSize = true;
            lblSapaan.Location = new Point(143, 200);
            lblSapaan.Name = "lblSapaan";
            lblSapaan.Size = new Size(0, 25);
            lblSapaan.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSapaan);
            Controls.Add(rdperempuan);
            Controls.Add(btnsapa);
            Controls.Add(rdoLaki);
            Controls.Add(txtNama);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNama;
        private RadioButton rdoLaki;
        private Button btnsapa;
        private RadioButton rdperempuan;
        private Label lblSapaan;
    }
}
