using System;

namespace Week2.Prova
{
    public abstract class Movement
    {
        public decimal Importo { get; set; }
        public DateTime DataMovimento { get; set; }

        public Movement(decimal importo)
        {
            Importo = importo;
            DataMovimento = DateTime.Now;
        }

        public override string ToString()
        {
            return $"Importo: {Importo}, Data del Movimento: {DataMovimento}";
        }
    }
}