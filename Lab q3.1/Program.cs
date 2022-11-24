using System;

namespace Lab_13
{
    class MultiBuilding : Building
    {
        string etagnost;
        public MultiBuilding(string adres, int shirina, int dlina, int visota, string etagnost)
        : base(adres, shirina, dlina, visota)
        {
            this.etagnost = etagnost;
        }
        public string Print()
        {
            string result = base.Print();
            result += $"{etagnost}";
            return result;
        }
    }

}