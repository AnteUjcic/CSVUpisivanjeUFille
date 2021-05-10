
namespace CSV
{
    partial class csvPocetna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(csvPocetna));
            this.btnPocetnaUnos = new System.Windows.Forms.Button();
            this.btnPocetnaPregled = new System.Windows.Forms.Button();
            this.picbxPocetnaSlika = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbxPocetnaSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPocetnaUnos
            // 
            this.btnPocetnaUnos.Location = new System.Drawing.Point(12, 255);
            this.btnPocetnaUnos.Name = "btnPocetnaUnos";
            this.btnPocetnaUnos.Size = new System.Drawing.Size(201, 40);
            this.btnPocetnaUnos.TabIndex = 0;
            this.btnPocetnaUnos.Text = "Unos";
            this.btnPocetnaUnos.UseVisualStyleBackColor = true;
            this.btnPocetnaUnos.Click += new System.EventHandler(this.btnPocetnaUnos_Click);
            // 
            // btnPocetnaPregled
            // 
            this.btnPocetnaPregled.Location = new System.Drawing.Point(12, 301);
            this.btnPocetnaPregled.Name = "btnPocetnaPregled";
            this.btnPocetnaPregled.Size = new System.Drawing.Size(201, 36);
            this.btnPocetnaPregled.TabIndex = 1;
            this.btnPocetnaPregled.Text = "Pregled";
            this.btnPocetnaPregled.UseVisualStyleBackColor = true;
            this.btnPocetnaPregled.Click += new System.EventHandler(this.btnPocetnaPregled_Click);
            // 
            // picbxPocetnaSlika
            // 
            this.picbxPocetnaSlika.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picbxPocetnaSlika.ErrorImage")));
            this.picbxPocetnaSlika.Image = ((System.Drawing.Image)(resources.GetObject("picbxPocetnaSlika.Image")));
            this.picbxPocetnaSlika.Location = new System.Drawing.Point(12, 24);
            this.picbxPocetnaSlika.Name = "picbxPocetnaSlika";
            this.picbxPocetnaSlika.Size = new System.Drawing.Size(201, 202);
            this.picbxPocetnaSlika.TabIndex = 2;
            this.picbxPocetnaSlika.TabStop = false;
            // 
            // csvPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 352);
            this.Controls.Add(this.picbxPocetnaSlika);
            this.Controls.Add(this.btnPocetnaPregled);
            this.Controls.Add(this.btnPocetnaUnos);
            this.Name = "csvPocetna";
            this.Text = "+";
            ((System.ComponentModel.ISupportInitialize)(this.picbxPocetnaSlika)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPocetnaUnos;
        private System.Windows.Forms.Button btnPocetnaPregled;
        private System.Windows.Forms.PictureBox picbxPocetnaSlika;
    }
}