using System;
using System.Collections.Generic;
using System.Text;

namespace Fråge_sport
{
    abstract class  MainCard
    {
        protected string question;

        public MainCard(string q)
        {

            question = q;
        }

        public abstract bool SkrivUt();
    }
}
