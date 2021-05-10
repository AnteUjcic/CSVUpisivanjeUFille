
namespace CSV
{
    partial class csvUnos
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
            this.txtUnosIme = new System.Windows.Forms.TextBox();
            this.txtUnosPrezime = new System.Windows.Forms.TextBox();
            this.txtUnosEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnUnosZavrsi = new System.Windows.Forms.Button();
            this.cmbUnosRazred = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtUnosIme
            // 
            this.txtUnosIme.Location = new System.Drawing.Point(43, 39);
            this.txtUnosIme.Name = "txtUnosIme";
            this.txtUnosIme.Size = new System.Drawing.Size(165, 23);
            this.txtUnosIme.TabIndex = 4;
            // 
            // txtUnosPrezime
            // 
            this.txtUnosPrezime.Location = new System.Drawing.Point(42, 83);
            this.txtUnosPrezime.Name = "txtUnosPrezime";
            this.txtUnosPrezime.Size = new System.Drawing.Size(165, 23);
            this.txtUnosPrezime.TabIndex = 3;
            // 
            // txtUnosEmail
            // 
            this.txtUnosEmail.Location = new System.Drawing.Point(42, 127);
            this.txtUnosEmail.Name = "txtUnosEmail";
            this.txtUnosEmail.Size = new System.Drawing.Size(165, 23);
            this.txtUnosEmail.TabIndex = 2;
            this.txtUnosEmail.TextChanged += new System.EventHandler(this.txtUnosEmail_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "E-Mail";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Razred";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(43, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 43);
            this.button1.TabIndex = 8;
            this.button1.Text = "Unos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUnosZavrsi
            // 
            this.btnUnosZavrsi.Location = new System.Drawing.Point(43, 262);
            this.btnUnosZavrsi.Name = "btnUnosZavrsi";
            this.btnUnosZavrsi.Size = new System.Drawing.Size(164, 47);
            this.btnUnosZavrsi.TabIndex = 9;
            this.btnUnosZavrsi.Text = "Zavrsi";
            this.btnUnosZavrsi.UseVisualStyleBackColor = true;
            this.btnUnosZavrsi.Click += new System.EventHandler(this.btnUnosZavrsi_Click);
            // 
            // cmbUnosRazred
            // 
            this.cmbUnosRazred.FormattingEnabled = true;
            this.cmbUnosRazred.Location = new System.Drawing.Point(42, 172);
            this.cmbUnosRazred.Name = "cmbUnosRazred";
            this.cmbUnosRazred.Size = new System.Drawing.Size(165, 23);
            this.cmbUnosRazred.TabIndex = 1;
            // 
            // csvUnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbUnosRazred);
            this.Controls.Add(this.btnUnosZavrsi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUnosEmail);
            this.Controls.Add(this.txtUnosPrezime);
            this.Controls.Add(this.txtUnosIme);
            this.Name = "csvUnos";
            this.Text = "csvUnos";
            this.Load += new System.EventHandler(this.csvUnos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUnosIme;
        private System.Windows.Forms.TextBox txtUnosPrezime;
        private System.Windows.Forms.TextBox txtUnosEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUnosZavrsi;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.ComboBox cmbUnosRazred;
    }
}