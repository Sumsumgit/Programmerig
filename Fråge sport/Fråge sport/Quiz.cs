using System;
using System.Collections.Generic;
using System.Text;

namespace Fråge_sport
{
    class Quiz
    {
        private List<MainCard> cards;
        private int numberOfCorrect;
        private int numberOfQuestions;

        public Quiz()
        {
            cards = new List<MainCard>();
            cards.Add(new QuestionCard("Vad heter Danmarks huvudstad?", "Köpenhamn"));
            cards.Add(new QuestionCard("Vad heter Italiens huvudstad?", "Rom"));
            cards.Add(new MultiCard("Vad heter Sverige huvudstad?", "Stockholm", "Ödsmål", "Göteborg"));
            //cards.Add(new MultiCard("Vad heter Portugals huvudstad?", "Lisabon"));

        }

        public void Run()
        {
            foreach (MainCard grej in cards)
            {
                bool answerOfCorrect = grej.SkrivUt();
                numberOfQuestions = numberOfQuestions + 1;

                if (answerOfCorrect == true)
                {
                    numberOfCorrect = numberOfCorrect + 1;
                    Console.WriteLine("Antalrätt:" + numberOfCorrect + " av " + numberOfQuestions);
                }
                else
                {
                    Console.WriteLine("Antalrätt:" + numberOfCorrect + " av " + numberOfQuestions);
                }
                Console.WriteLine();
            }
        }

    }
}
