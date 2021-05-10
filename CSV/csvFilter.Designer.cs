
namespace CSV
{
    partial class csvFilter
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
            this.txtFilterIme = new System.Windows.Forms.TextBox();
            this.txtFilterPrezime = new System.Windows.Forms.TextBox();
            this.txtFilterEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Razred = new System.Windows.Forms.Label();
            this.cmbFilterRazred = new System.Windows.Forms.ComboBox();
            this.btnFilterFiltriraj = new System.Windows.Forms.Button();
            this.btnFilterOdustani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFilterIme
            // 
            this.txtFilterIme.Location = new System.Drawing.Point(13, 44);
            this.txtFilterIme.Name = "txtFilterIme";
            this.txtFilterIme.Size = new System.Drawing.Size(219, 23);
            this.txtFilterIme.TabIndex = 0;
            // 
            // txtFilterPrezime
            // 
            this.txtFilterPrezime.Location = new System.Drawing.Point(13, 88);
            this.txtFilterPrezime.Name = "txtFilterPrezime";
            this.txtFilterPrezime.Size = new System.Drawing.Size(219, 23);
            this.txtFilterPrezime.TabIndex = 1;
            // 
            // txtFilterEmail
            // 
            this.txtFilterEmail.Location = new System.Drawing.Point(12, 132);
            this.txtFilterEmail.Name = "txtFilterEmail";
            this.txtFilterEmail.Size = new System.Drawing.Size(219, 23);
            this.txtFilterEmail.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ime";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "E-Mail";
            // 
            // Razred
            // 
            this.Razred.AutoSize = true;
            this.Razred.Location = new System.Drawing.Point(11, 158);
            this.Razred.Name = "Razred";
            this.Razred.Size = new System.Drawing.Size(42, 15);
            this.Razred.TabIndex = 7;
            this.Razred.Text = "Razred";
            // 
            // cmbFilterRazred
            // 
            this.cmbFilterRazred.FormattingEnabled = true;
            this.cmbFilterRazred.Items.AddRange(new object[] {
            "1.a",
            "1.b",
            "1.c",
            "1.d",
            "2.a",
            "2.b",
            "2.c",
            "2.d",
            "3.a",
            "3.b",
            "3.c",
            "3.d",
            "4.a",
            "4.b",
            "4.c",
            "4.d"});
            this.cmbFilterRazred.Location = new System.Drawing.Point(11, 176);
            this.cmbFilterRazred.Name = "cmbFilterRazred";
            this.cmbFilterRazred.Size = new System.Drawing.Size(219, 23);
            this.cmbFilterRazred.TabIndex = 8;
            // 
            // btnFilterFiltriraj
            // 
            this.btnFilterFiltriraj.Location = new System.Drawing.Point(13, 302);
            this.btnFilterFiltriraj.Name = "btnFilterFiltriraj";
            this.btnFilterFiltriraj.Size = new System.Drawing.Size(218, 43);
            this.btnFilterFiltriraj.TabIndex = 9;
            this.btnFilterFiltriraj.Text = "Filtriraj";
            this.btnFilterFiltriraj.UseVisualStyleBackColor = true;
            // 
            // btnFilterOdustani
            // 
            this.btnFilterOdustani.Location = new System.Drawing.Point(12, 351);
            this.btnFilterOdustani.Name = "btnFilterOdustani";
            this.btnFilterOdustani.Size = new System.Drawing.Size(219, 45);
            this.btnFilterOdustani.TabIndex = 10;
            this.btnFilterOdustani.Text = "Odustani";
            this.btnFilterOdustani.UseVisualStyleBackColor = true;
            // 
            // csvFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 408);
            this.Controls.Add(this.btnFilterOdustani);
            this.Controls.Add(this.btnFilterFiltriraj);
            this.Controls.Add(this.cmbFilterRazred);
            this.Controls.Add(this.Razred);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFilterEmail);
            this.Controls.Add(this.txtFilterPrezime);
            this.Controls.Add(this.txtFilterIme);
            this.Name = "csvFilter";
            this.Text = "+";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFilterIme;
        private System.Windows.Forms.TextBox txtFilterPrezime;
        private System.Windows.Forms.TextBox txtFilterEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Razred;
        private System.Windows.Forms.ComboBox cmbFilterRazred;
        private System.Windows.Forms.Button btnFilterFiltriraj;
        private System.Windows.Forms.Button btnFilterOdustani;
    }
}