using System;
using System.Collections.Generic;
using System.Text;

namespace Fråge_sport
{
    class MultiCard : MainCard
    {
        private string multiAnswer;
        private string multiAnswer2;
        private string multiAnswer3;


        public MultiCard(string q, string m, string m2, string m3) : base(q)
        {
            multiAnswer = m;
            multiAnswer2 = m2;
            multiAnswer3 = m3;
        }

        public override bool SkrivUt()
        {
            Console.WriteLine(question);
            Console.WriteLine();
            Console.WriteLine("Svars alternativ:");
            Console.WriteLine();
            Console.WriteLine("Alternativ 1: " + multiAnswer);
            Console.WriteLine("Alternativ 2: " + multiAnswer2);
            Console.WriteLine("Alternativ 3: " + multiAnswer3);


            String guess = Console.ReadLine();




            if (guess.ToLower() == multiAnswer.ToLower())
            {
                Console.WriteLine("Rätt!");
                return true;
            }
            else
            {
                Console.WriteLine("Fel, Rätt svar:" + multiAnswer);
                return false;
            }


        }
    }
}
