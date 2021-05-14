using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.Prova
{
    public class Account
    {
        public int NumeroConto { get; set; }
        public string NomeBanca { get; set; }
        public decimal Saldo { get; set; }
        public DateTime DataUltimaOperazione { get; set; }
        public List<Movement> ListaMovimenti { get; set; } = new List<Movement>();

        public static Account operator +(Account account, Movement movimento)
        {
            account.ListaMovimenti.Add(movimento);
            account.Saldo += movimento.Importo;
            account.DataUltimaOperazione = DateTime.Now; ;
            return account;
        }

        public static Account operator -(Account account, Movement movimento)
        {
            account.ListaMovimenti.Add(movimento);
            account.Saldo -= movimento.Importo;
            account.DataUltimaOperazione = DateTime.Now; ;
            return account;
        }

        public void Statement()
        {
            string ListaMovimentiString= "";

            foreach (var m in ListaMovimenti)
                ListaMovimentiString += ("\n" + m.ToString());

            Console.WriteLine($"Conto: {NumeroConto}, Banca: {NomeBanca}, Saldo: {Saldo}, " +
                $"Data ultima operazione: {DataUltimaOperazione}, Lista movimenti: {ListaMovimentiString}");
        }

        public void Versa(Movement movimento)
        {
            ListaMovimenti.Add(movimento);
            Saldo += movimento.Importo;
            DataUltimaOperazione = DateTime.Now;
        }

        public void Preleva(Movement movimento)
        {
            ListaMovimenti.Add(movimento);
            Saldo -= movimento.Importo;
            DataUltimaOperazione = DateTime.Now;
        }

    }
}
