using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.Prova
{
    public class CreditCardMovement : Movement
    {
        public enum TipoCarta
        {
            AMEX,
            VISA,
            MASTERCARD,
            OTHER
        }

        public TipoCarta Tipo { get; set; }
        public int NumeroCarta { get; set; }

        public CreditCardMovement(decimal importo, TipoCarta tipo, int numeroCarta) : base(importo)
        {
            Tipo = tipo;
            NumeroCarta = numeroCarta;
        }

        public override string ToString()
        {
            return base.ToString() + $", Tipo: {Tipo}, Numero di Carta: {NumeroCarta}";
        }
    }
}
