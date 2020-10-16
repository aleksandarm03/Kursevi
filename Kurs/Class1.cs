using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs
{
    class Kurs
    {
        #region atributi
        private string naziv;
        private double cena;
        #endregion

        #region konstruktori
        public Kurs(string naziv,  double cena)
        {
            if (naziv.Equals(string.Empty))
                throw new Exception("Nema naziv!");
           
            else if (cena < 0)
                throw new Exception("Cena<0!");
            else
            {
                this.naziv = naziv;
                this.cena = cena;
            }
        }

        
        #endregion

        #region metode
        public bool JeftinijiOd(Kurs k)
        {
            if (cena < k.cena) return true;
            else return false;
           
        }

       
        public string Prikaz()
        {
            return naziv +  cena + "RSD";
        }
        #endregion
    }

}

