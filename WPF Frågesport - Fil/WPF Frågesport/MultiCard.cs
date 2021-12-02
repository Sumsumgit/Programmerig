using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_Frågesport
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

        internal override bool IsCorrect(string text)
        {
            if (text == multiAnswer)
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
            string text = "";

            text = text + multiAnswer + " - " + multiAnswer2+ " - " + multiAnswer3;

            return text;

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
