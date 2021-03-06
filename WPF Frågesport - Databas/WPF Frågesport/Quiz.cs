using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace WPF_Frågesport
{
    class Quiz
    {
        private List<MainCard> cards;
        private string numberOfCorrect;
        private string numberOfQuestions;
        private int cardNumber = 0;
        public Quiz()
        {
            cards = new List<MainCard>();
            //cards.Add(new QuestionCard("Vad heter Danmarks huvudstad?", "Köpenhamn"));
            //cards.Add(new QuestionCard("Vad heter Italiens huvudstad?", "Rom"));
            //cards.Add(new MultiCard("Vad heter Sveriges huvudstad?", "Stockholm", "Ödsmål", "Göteborg"));
            //cards.Add(new MultiCard("Vad heter Qatars huvudstad?", "Doha", "Bahrain", "Jeddah"));
            //cards.Add(new QuestionCard("Vad heter Storbritanniens huvudstad?", "London"));

            DatabaseHandler databaseHandler = new DatabaseHandler();
            cards = databaseHandler.GetQuestion();


        }



        public MainCard Nextcard()
        {
           
            cardNumber = cardNumber + 1;
            return cards[cardNumber - 1];

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
