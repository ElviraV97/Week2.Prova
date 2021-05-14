using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.Prova
{
    public class TransfertMovement : Movement
    {
        public string BancaOrigine { get; set; }
        public string BancaDestinazione { get; set; }

        public TransfertMovement(decimal importo, string bancaorigine, string bancadestinazione) : base(importo)
        {
            BancaOrigine = bancaorigine;
            BancaDestinazione = bancadestinazione;
        }

        public override string ToString()
        {
            return base.ToString() + $", Banca d'Origine: {BancaOrigine}, Banca Destinazione: {BancaDestinazione}";
        }
    }
}
