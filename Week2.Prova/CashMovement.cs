using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.Prova
{
    public class CashMovement : Movement
    {
        public string Esecutore { get; set; }
        public CashMovement(decimal importo, string esecutore) : base(importo)
        {
            Esecutore = esecutore;
        }

        public override string ToString()
        {
            return base.ToString() + $", Esecutore: {Esecutore}";
        }
    }
}
