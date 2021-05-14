using System;
using static Week2.Prova.CreditCardMovement;

namespace Week2.Prova
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account()
            {
                NumeroConto = 1,
                NomeBanca = "BPM",
                Saldo = 1000
            };

            do
            {
                Console.WriteLine("Inserisci operazione: ");
                Console.WriteLine("1. Prelievo attraverso CashMovement");
                Console.WriteLine("2. Prelievo attraverso TransfertMovement");
                Console.WriteLine("3. Prelievo attraverso CreditCardMovement");
                Console.WriteLine("4. Versamento attraverso CashMovement");
                Console.WriteLine("5. Versamento attraverso TransfertMovement");
                Console.WriteLine("6. Versamento attraverso CreditCardMovement");
                Console.WriteLine("7. Stampa dati conto e movimenti");
                Console.WriteLine("0. Esci");

                switch (Console.ReadKey().KeyChar)
                {
                    case '1':
                        Console.WriteLine("\nInserisci nome esecutore: ");
                        string esecutore = Console.ReadLine();

                        acc1 -= new CashMovement(InserimentoImporto(), esecutore);
                        break;
                    case '2':
                        Console.WriteLine("\nInserisci banca destinazione: ");
                        string dest = Console.ReadLine();

                        acc1 -= new TransfertMovement(InserimentoImporto(), acc1.NomeBanca, dest);
                        break;
                    case '3':
                        acc1 -= new CreditCardMovement(InserimentoImporto(), InserisciTipo(), InserisciNCarta());
                        break;
                    case '4':
                        Console.WriteLine("\nInserisci nome esecutore: ");
                        string esecutore2 = Console.ReadLine();

                        acc1 += new CashMovement(InserimentoImporto(), esecutore2);
                        break;
                    case '5':
                        Console.WriteLine("\nInserisci banca origine: ");
                        string origine = Console.ReadLine();

                        acc1 += new TransfertMovement(InserimentoImporto(), origine, acc1.NomeBanca);
                        break;
                    case '6':
                        acc1 += new CreditCardMovement(InserimentoImporto(), InserisciTipo(), InserisciNCarta());
                        break;
                    case '7':
                        acc1.Statement();
                        break;
                    case '0':
                        return;
                    default:
                        Console.WriteLine("Scelta non valida");
                        break;
                }
                    
            } while (true);

        }

        private static int InserisciNCarta()
        {
            int num;
            do
                Console.Write("Inserisci numero di carta: ");
            while (!int.TryParse(Console.ReadLine(), out num));

            return num;
        }

        public static decimal InserimentoImporto()
        {
            decimal importo;
            do
                Console.Write("Inserisci importo: ");
            while (!decimal.TryParse(Console.ReadLine(), out importo));

            return importo;
        }

        public static TipoCarta InserisciTipo()
        {
            TipoCarta tipo;
            Console.WriteLine("Inserisci tipo carta: (AMEX, VISA, MASTERCARD, OTHER)");
            if (Console.ReadLine() == "AMEX")
                tipo = TipoCarta.AMEX;
            else if (Console.ReadLine() == "VISA")
                tipo = TipoCarta.VISA;
            else if (Console.ReadLine() == "MASTERCARD")
                tipo = TipoCarta.MASTERCARD;
            else
                tipo = TipoCarta.OTHER;

            return tipo;
        }
    }
}
