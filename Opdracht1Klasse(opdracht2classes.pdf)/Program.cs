using System;

namespace Opdracht1Klasse_opdracht2classes.pdf_
{
    class Program
    {
        static void Main(string[] args)
        {
            bankrekening rekening = new bankrekening();
            string strAntwoord;
            int intKeuze;

            LimietSet(rekening);



            do
            {

                Console.WriteLine("Wilt u een geldstorting doen of geld afhalen? \n1. Storting \n2. Afhalen");
                intKeuze = Convert.ToInt32(Console.ReadLine());
                if (intKeuze == 1)
                {
                    Storting(rekening);
                    Console.Clear();
                }
                else
                {
                    GeldAfhalen(rekening);
                    Console.Clear();
                }

                //Aantal verrichtingen
                rekening.Verrichting++;

                //Gegevens
                Gegevens(rekening);

                //Vragen voor nog een transactie 
                Console.WriteLine("Wilt u nog een transactie uitvoeren? ");
                strAntwoord = Console.ReadLine().ToUpper();
            } while (strAntwoord == "Y");
        }

        private static void GeldAfhalen(bankrekening rekening)
        {

            Console.Clear();

            //Toon gegevens
            Gegevens(rekening);

            int intGeldAfhalen;

            //Bedrag vragen voor af te halen
            Console.Write("Geef een bedrag dat u wilt afhalen: ");
            intGeldAfhalen = Convert.ToInt32(Console.ReadLine());


            if (rekening.RekeningStand - intGeldAfhalen < rekening.Limiet)
            {

                Console.WriteLine("U zit te ver onder 0!");
                Console.WriteLine($"De limiet is {rekening.Limiet}");

                //Transactie tonen
                transactie(rekening, intGeldAfhalen, "A");
                //Opnieuw 2de keer
                GeldAfhalen(rekening);
            }
            else
            {

                Console.WriteLine("Transactie voltooid!");

                transactie(rekening, intGeldAfhalen, "A");

                //De rekenings variabele van de klasse updaten ADHV get/set functie
                //rekening.RekeningStand -= intGeldAfhalen;
            }
        }


        private static void transactie(bankrekening rekening, int intBedrag, string strType)
        {
            //
            if (strType == "A")
            {
                //Afhalen
                Console.WriteLine($"{rekening.RekeningStand} - {intBedrag} = {rekening.RekeningStand - intBedrag}");
            }
            else if (strType == "S")
            {
                //Storting
                Console.WriteLine($"{rekening.RekeningStand} + {intBedrag} = {rekening.RekeningStand + intBedrag}");
            }
            Console.ReadLine();
        }


        private static void Storting(bankrekening rekening)
        {
            //Console leegmaken van het keuze menu
            Console.Clear();

            //Gegevens
            Gegevens(rekening);

            int intStorting;

            //Bedrag vragen
            Console.Write("Geef het bedrag op dat je wilt storten: ");
            intStorting = Convert.ToInt32(Console.ReadLine());

            //Transactie voltooid
            Console.WriteLine("Transactie voltooid!");

            //De transactie tonen 
            transactie(rekening, intStorting, "S");

            //De rekenings variabele van de klasse updaten ADHV get/set functie
            //rekening.RekeningStand += intStorting;
        }


        private static void Gegevens(bankrekening rekening)
        {
            Console.WriteLine($"Er staat nog {rekening.RekeningStand} euro op uw rekening.");
            Console.WriteLine($"U mag nog {rekening.Limiet} euro onder 0 gaan.");
            Console.WriteLine($"U heeft al {rekening.Verrichting} verrichtingen gedaan.\n");
        }


        private static void LimietSet(bankrekening rekening)
        {
            rekening.Limiet = -1000;
        }
    }
}



