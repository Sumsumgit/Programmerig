using System;
using System.Collections.Generic;
using System.Text;

namespace Fråge_sport
{
    class QuestionCard : MainCard
    {
      
        private string answer;

        public QuestionCard(string q, string a) : base(q)
            {

            answer = a;

            }

        public override bool SkrivUt()
        {
            Console.WriteLine(question);
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
