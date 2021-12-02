using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_Frågesport
{
    class QuestionCard : MainCard
    {
      
        private string answer;

        public QuestionCard(string q, string a) : base(q)
            {

            answer = a;

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
