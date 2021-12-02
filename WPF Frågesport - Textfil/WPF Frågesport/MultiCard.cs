using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_Frågesport
{
    class MultiCard : MainCard
    {
        private string answer;
        private string multiAnswer2;



        public MultiCard(string q, string m2, string m) : base(q)
        {
            multiAnswer2 = m2;
            answer = m;


        }

        internal override bool IsCorrect(string text)
        {
            if (text == answer)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public string HämtaSvar()
        {


            return multiAnswer2;

        }

        public override bool SkrivUt()
        {
            Console.WriteLine(question);
            Console.WriteLine();
            Console.WriteLine("Svars alternativ:");
            Console.WriteLine();
            Console.WriteLine("Alternativ 1: " + answer);
            Console.WriteLine("Alternativ 2: " + multiAnswer2);
            


            String guess = Console.ReadLine();




            if (guess.ToLower() == answer.ToLower())
            {
                Console.WriteLine("Rätt!");
                return true;
            }
            else
            {
                Console.WriteLine("Fel, Rätt svar:" + answer);
                return false;
            }


        }
    }
}