using System;
using System.Collections.Generic;
using System.Text;

namespace Arv___sak
{
    class Databas
    {
        private List<Sak> saker;

        public Databas()
        {
            saker = new List<Sak>();
            saker.Add(new CD("La la", "Trocadero"));
            saker.Add(new CD("La la land", "Trocadero"));
            saker.Add(new CD("La", "Trocadero"));
            saker.Add(new CD("Lalala lala", "Trocadero"));
            saker.Add(new DVD("Billy", "Trocadero Zero"));
            saker.Add(new DVD("Bill", "Trocadero Zero"));
            saker.Add(new DVD("Bell", "Trocadero Zero"));
            saker.Add(new DVD("Nell", "Trocadero Zero"));
            
        }
        public void Add(Sak enSak)
        {
            saker.Add(enSak);
        }
        public void Run()
        {
            foreach (Sak grej in saker)
            {
                grej.SkrivUt();
            }
        }

    }

}
