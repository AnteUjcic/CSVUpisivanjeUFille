﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSV
{
   public class Ucenik
    {
        private string ime, prezime, email, razred;

        public Ucenik(string ime, string prezime, string email, string razred)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.email = email;
            this.razred = razred;
        }

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Email { get => email; set => email = value; }
        public string Razred { get => razred; set => razred = value; }
        public string Ispis()
        {
            string ispis = ime + ", " + prezime + ", " + email + "," + razred;
            return ispis;
        }
    }
                                                                                                                                                                                        

}
