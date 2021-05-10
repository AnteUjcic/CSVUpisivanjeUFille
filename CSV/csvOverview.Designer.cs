
namespace CSV
{
    partial class csvOverview
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
            this.rtbOverviewPrikaz = new System.Windows.Forms.RichTextBox();
            this.btnOverviewUcitaj = new System.Windows.Forms.Button();
            this.btnOverviewFiltriraj = new System.Windows.Forms.Button();
            this.btnOverviewOdustani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbOverviewPrikaz
            // 
            this.rtbOverviewPrikaz.Location = new System.Drawing.Point(12, 71);
            this.rtbOverviewPrikaz.Name = "rtbOverviewPrikaz";
            this.rtbOverviewPrikaz.Size = new System.Drawing.Size(399, 367);
            this.rtbOverviewPrikaz.TabIndex = 0;
            this.rtbOverviewPrikaz.Text = "";
            // 
            // btnOverviewUcitaj
            // 
            this.btnOverviewUcitaj.Location = new System.Drawing.Point(36, 42);
            this.btnOverviewUcitaj.Name = "btnOverviewUcitaj";
            this.btnOverviewUcitaj.Size = new System.Drawing.Size(112, 23);
            this.btnOverviewUcitaj.TabIndex = 1;
            this.btnOverviewUcitaj.Text = "Ucitaj";
            this.btnOverviewUcitaj.UseVisualStyleBackColor = true;
            this.btnOverviewUcitaj.Click += new System.EventHandler(this.btnOverviewUcitaj_Click);
            // 
            // btnOverviewFiltriraj
            // 
            this.btnOverviewFiltriraj.Location = new System.Drawing.Point(154, 42);
            this.btnOverviewFiltriraj.Name = "btnOverviewFiltriraj";
            this.btnOverviewFiltriraj.Size = new System.Drawing.Size(118, 23);
            this.btnOverviewFiltriraj.TabIndex = 2;
            this.btnOverviewFiltriraj.Text = "Filtriraj";
            this.btnOverviewFiltriraj.UseVisualStyleBackColor = true;
            // 
            // btnOverviewOdustani
            // 
            this.btnOverviewOdustani.Location = new System.Drawing.Point(278, 42);
            this.btnOverviewOdustani.Name = "btnOverviewOdustani";
            this.btnOverviewOdustani.Size = new System.Drawing.Size(103, 23);
            this.btnOverviewOdustani.TabIndex = 3;
            this.btnOverviewOdustani.Text = "Odustani";
            this.btnOverviewOdustani.UseVisualStyleBackColor = true;
            // 
            // csvOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 457);
            this.Controls.Add(this.btnOverviewOdustani);
            this.Controls.Add(this.btnOverviewFiltriraj);
            this.Controls.Add(this.btnOverviewUcitaj);
            this.Controls.Add(this.rtbOverviewPrikaz);
            this.Name = "csvOverview";
            this.Text = "csvOverview";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbOverviewPrikaz;
        private System.Windows.Forms.Button btnOverviewUcitaj;
        private System.Windows.Forms.Button btnOverviewFiltriraj;
        private System.Windows.Forms.Button btnOverviewOdustani;
    }
}