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
            

            string docPath =
      Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string pathAndFileName = Path.Combine(docPath, "Questions.txt");

            using (var sr = new StreamReader(pathAndFileName))
            {
                
               
                string question = sr.ReadLine();
                while (question != null)
                {
                    string answer = sr.ReadLine();
                    cards.Add(new QuestionCard(question, answer));
                    question = sr.ReadLine();
                }
            }


            string docPath2 =
Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string pathAndFileName2 = Path.Combine(docPath2, "Questions2.txt");

            using (var sr = new StreamReader(pathAndFileName2))
            {


                string question = sr.ReadLine();
                string multiQ = sr.ReadLine();
                while (question != null)
                {
                    string answer = sr.ReadLine();
                    cards.Add(new MultiCard(question, multiQ, answer));
                    question = sr.ReadLine();
                    multiQ = sr.ReadLine();
                }
            }

            cards.Add(new FinalCard("Grattis!"));
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
