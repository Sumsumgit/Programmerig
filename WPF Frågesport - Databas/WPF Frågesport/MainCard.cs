using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_Frågesport
{
    abstract class  MainCard
    {
        protected string question;

        public string Question
        {
            get 
            {
                return question;
            }

        }


        public MainCard(string q)
        {

            question = q;
        }

        public abstract bool SkrivUt();

        internal abstract bool IsCorrect(string text);
        
    }
}
