namespace Meshur_Sehirler_CF
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
            cboSehirler = new ComboBox();
            lstOzellikler = new ListBox();
            label1 = new Label();
            label2 = new Label();
            btnSehirEkle = new Button();
            btnOzellikEkle = new Button();
            txtOzellik = new TextBox();
            txtSehir = new TextBox();
            label3 = new Label();
            nudPlaka = new NumericUpDown();
            btnOzellikKaldır = new Button();
            ((System.ComponentModel.ISupportInitialize)nudPlaka).BeginInit();
            SuspendLayout();
            // 
            // cboSehirler
            // 
            cboSehirler.DisplayMember = "Ad";
            cboSehirler.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSehirler.FormattingEnabled = true;
            cboSehirler.Location = new Point(25, 79);
            cboSehirler.Name = "cboSehirler";
            cboSehirler.Size = new Size(315, 23);
            cboSehirler.TabIndex = 0;
            cboSehirler.SelectedIndexChanged += cboSehirler_SelectedIndexChanged;
            // 
            // lstOzellikler
            // 
            lstOzellikler.DisplayMember = "Ad";
            lstOzellikler.FormattingEnabled = true;
            lstOzellikler.ItemHeight = 15;
            lstOzellikler.Location = new Point(25, 198);
            lstOzellikler.Name = "lstOzellikler";
            lstOzellikler.Size = new Size(315, 259);
            lstOzellikler.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 22);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 2;
            label1.Text = "Plaka";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 131);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 3;
            label2.Text = "Ozellik";
            // 
            // btnSehirEkle
            // 
            btnSehirEkle.Location = new Point(263, 42);
            btnSehirEkle.Name = "btnSehirEkle";
            btnSehirEkle.Size = new Size(77, 23);
            btnSehirEkle.TabIndex = 5;
            btnSehirEkle.Text = "Sehir Ekle";
            btnSehirEkle.UseVisualStyleBackColor = true;
            btnSehirEkle.Click += btnSehirEkle_Click;
            // 
            // btnOzellikEkle
            // 
            btnOzellikEkle.Location = new Point(263, 157);
            btnOzellikEkle.Name = "btnOzellikEkle";
            btnOzellikEkle.Size = new Size(77, 24);
            btnOzellikEkle.TabIndex = 7;
            btnOzellikEkle.Text = "Ozellik Ekle";
            btnOzellikEkle.UseVisualStyleBackColor = true;
            btnOzellikEkle.Click += btnOzellikEkle_Click;
            // 
            // txtOzellik
            // 
            txtOzellik.Location = new Point(26, 158);
            txtOzellik.Name = "txtOzellik";
            txtOzellik.Size = new Size(220, 23);
            txtOzellik.TabIndex = 6;
            // 
            // txtSehir
            // 
            txtSehir.Location = new Point(127, 43);
            txtSehir.Name = "txtSehir";
            txtSehir.Size = new Size(119, 23);
            txtSehir.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(127, 22);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 8;
            label3.Text = "Sehir";
            // 
            // nudPlaka
            // 
            nudPlaka.Location = new Point(30, 43);
            nudPlaka.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudPlaka.Name = "nudPlaka";
            nudPlaka.Size = new Size(75, 23);
            nudPlaka.TabIndex = 10;
            nudPlaka.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnOzellikKaldır
            // 
            btnOzellikKaldır.Location = new Point(201, 477);
            btnOzellikKaldır.Name = "btnOzellikKaldır";
            btnOzellikKaldır.Size = new Size(137, 23);
            btnOzellikKaldır.TabIndex = 11;
            btnOzellikKaldır.Text = "Secili Ozelligi Kaldır";
            btnOzellikKaldır.UseVisualStyleBackColor = true;
            btnOzellikKaldır.Click += btnOzellikKaldır_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 519);
            Controls.Add(btnOzellikKaldır);
            Controls.Add(nudPlaka);
            Controls.Add(txtSehir);
            Controls.Add(label3);
            Controls.Add(btnOzellikEkle);
            Controls.Add(txtOzellik);
            Controls.Add(btnSehirEkle);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstOzellikler);
            Controls.Add(cboSehirler);
            Name = "Form1";
            Text = "Meshur Urunler";
            ((System.ComponentModel.ISupportInitialize)nudPlaka).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboSehirler;
        private ListBox lstOzellikler;
        private Label label1;
        private Label label2;
        private Button btnSehirEkle;
        private Button btnOzellikEkle;
        private TextBox txtOzellik;
        private TextBox txtSehir;
        private Label label3;
        private NumericUpDown nudPlaka;
        private Button btnOzellikKaldır;
    }
}