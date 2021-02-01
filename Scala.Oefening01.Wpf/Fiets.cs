using System;
using System.Collections.Generic;
using System.Text;

namespace Scala.Oefening01.Wpf
{
    class Fiets
    {
        public string Merk { get; set; }
        public string Serie { get; set; }
        public decimal Verkoopprijs { get; set; }
        public bool IsElektrisch { get; set; }
        public byte AantalWielen { get; set; }

        public Fiets()
        {
        }
        public Fiets(string merk, string serie, decimal verkoopprijs, bool isElektrisch, byte aantalWielen)
        {
            Merk = merk;
            Serie = serie;
            Verkoopprijs = verkoopprijs;
            IsElektrisch = isElektrisch;
            AantalWielen = aantalWielen;
        }
        public override string ToString()
        {
            return $"{Merk} - {Serie}";
        }
    }
}
