using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace CSV
{
    public partial class csvUnos : Form
    {
        List<Ucenik> listaUcenika = new List<Ucenik>();
        
        String putanja = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "csvTransformer");
        public csvUnos()
        {
            InitializeComponent();
        }

        private void csvUnos_Load(object sender, EventArgs e)
        {
          
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            csvUnos frmUnos = new csvUnos();
            frmUnos.Show();
            try
            {
                if (txtUnosEmail.Text.Contains('@'))
                {
                    Ucenik objUcenik = new Ucenik(txtUnosIme.Text, txtUnosPrezime.Text, txtUnosEmail.Text, cmbUnosRazred.Text);
                    listaUcenika.Add(objUcenik);
                    txtUnosEmail.Clear();
                    txtUnosPrezime.Clear();
                    txtUnosIme.Clear();

                    MessageBox.Show("Podaci su upisani");

                }
                


            }
            catch (Exception ex)
            {

                MessageBox.Show("greska");
            }


        }

        private void btnUnosZavrsi_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(putanja)) {
                Directory.CreateDirectory(putanja);
            }
            StreamWriter sw = new StreamWriter(putanja + "podaci.csv");
            sw.WriteLine("Ime,Prezime,Email,Razred");
            foreach(Ucenik uc in listaUcenika)
            {

                sw.Write(uc.Ispis());
            }

            sw.Close();        
        }

        private void txtUnosEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUnosRazred_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
