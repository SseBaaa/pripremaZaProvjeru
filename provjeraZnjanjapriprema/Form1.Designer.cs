namespace provjeraZnjanjapriprema
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.btnIspisi = new System.Windows.Forms.Button();
            this.cmbVrsta = new System.Windows.Forms.ComboBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.trckSnaga = new System.Windows.Forms.TrackBar();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.dateDatum = new System.Windows.Forms.DateTimePicker();
            this.richIspisi = new System.Windows.Forms.RichTextBox();
            this.labelSnaga = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trckSnaga)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vrsta vozila";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Naziv vozila";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Snaga vozila";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Marka vozila";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Datum proizvodnje";
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(552, 44);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(163, 53);
            this.btnUnesi.TabIndex = 5;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // btnIspisi
            // 
            this.btnIspisi.Location = new System.Drawing.Point(552, 116);
            this.btnIspisi.Name = "btnIspisi";
            this.btnIspisi.Size = new System.Drawing.Size(163, 49);
            this.btnIspisi.TabIndex = 6;
            this.btnIspisi.Text = "ispisi";
            this.btnIspisi.UseVisualStyleBackColor = true;
            this.btnIspisi.Click += new System.EventHandler(this.btnIspisi_Click);
            // 
            // cmbVrsta
            // 
            this.cmbVrsta.FormattingEnabled = true;
            this.cmbVrsta.Items.AddRange(new object[] {
            "Automobil",
            "Zrakoplov",
            "Plovilo"});
            this.cmbVrsta.Location = new System.Drawing.Point(47, 61);
            this.cmbVrsta.Name = "cmbVrsta";
            this.cmbVrsta.Size = new System.Drawing.Size(121, 21);
            this.cmbVrsta.TabIndex = 7;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(47, 115);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(121, 20);
            this.txtNaziv.TabIndex = 8;
            // 
            // trckSnaga
            // 
            this.trckSnaga.LargeChange = 20;
            this.trckSnaga.Location = new System.Drawing.Point(47, 194);
            this.trckSnaga.Maximum = 350;
            this.trckSnaga.Minimum = 45;
            this.trckSnaga.Name = "trckSnaga";
            this.trckSnaga.Size = new System.Drawing.Size(741, 45);
            this.trckSnaga.SmallChange = 5;
            this.trckSnaga.TabIndex = 9;
            this.trckSnaga.Value = 45;
            this.trckSnaga.Scroll += new System.EventHandler(this.trckSnaga_Scroll);
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(229, 62);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(162, 20);
            this.txtMarka.TabIndex = 10;
            // 
            // dateDatum
            // 
            this.dateDatum.Location = new System.Drawing.Point(229, 115);
            this.dateDatum.Name = "dateDatum";
            this.dateDatum.Size = new System.Drawing.Size(162, 20);
            this.dateDatum.TabIndex = 11;
            // 
            // richIspisi
            // 
            this.richIspisi.Location = new System.Drawing.Point(13, 260);
            this.richIspisi.Name = "richIspisi";
            this.richIspisi.Size = new System.Drawing.Size(775, 178);
            this.richIspisi.TabIndex = 12;
            this.richIspisi.Text = "";
            // 
            // labelSnaga
            // 
            this.labelSnaga.AutoSize = true;
            this.labelSnaga.Location = new System.Drawing.Point(149, 178);
            this.labelSnaga.Name = "labelSnaga";
            this.labelSnaga.Size = new System.Drawing.Size(19, 13);
            this.labelSnaga.TabIndex = 13;
            this.labelSnaga.Text = "45";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelSnaga);
            this.Controls.Add(this.richIspisi);
            this.Controls.Add(this.dateDatum);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.trckSnaga);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.cmbVrsta);
            this.Controls.Add(this.btnIspisi);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trckSnaga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.Button btnIspisi;
        private System.Windows.Forms.ComboBox cmbVrsta;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TrackBar trckSnaga;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.DateTimePicker dateDatum;
        private System.Windows.Forms.RichTextBox richIspisi;
        private System.Windows.Forms.Label labelSnaga;
    }
}

