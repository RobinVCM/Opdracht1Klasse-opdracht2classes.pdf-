using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht1Klasse_opdracht2classes.pdf_
{
    class bankrekening
    {
        //Beschermde variabelen
        private int intRekeningenStand;
        private int intLimiet;
        private int intVerrichtingen;

        //Alle get set functies voor deze variabelen
        public int RekeningStand
        {
            get { return intRekeningenStand; }
            set { intRekeningenStand = value; }
        }
        public int Limiet
        {
            get { return intLimiet; }
            set { intLimiet = value; }
        }
        public int Verrichting
        {
            get { return intVerrichtingen; }
            set { intVerrichtingen = value; }
        }

        //De constructor die alle variabelen op 0 zet ADHV de get/set functie
        public bankrekening()
        {
            RekeningStand = 0;
            Limiet = 0;
            Verrichting = 0;
        }
    }
}