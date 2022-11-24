using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_13
{
    class Building
    {
        string adres;
        int shirina;
        int dlina;
        int visota;

        int Shirina
        {
            get
            {
                return shirina;
            }
            set
            {
                if (value < 0)
                    shirina = 10;
                else
                    shirina = value;
            }
        }
        int Dlina
        {
            get
            {
                return dlina;
            }
            set
            {
                if (value < 0)
                    dlina = 10;
                else
                    dlina = value;
            }
           public Building(string adres, int shirina, int dlina, int visota)
        {
            this.adres = adres;
            this.shirina = shirina;
            this.dlina = dlina;
            this.visota = visota;
        }
        public string Print()
        {
            return $"{adres}, {shirina}, {dlina}"
        }
    }
}
}
