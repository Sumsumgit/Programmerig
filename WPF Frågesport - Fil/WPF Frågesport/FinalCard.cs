using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_Frågesport
{
    class FinalCard : MainCard
    {


        private string antalRätt;


        public FinalCard(string a) : base(q)
        {

            antalRätt = a;



        }


        public override bool SkrivUt()
        {
            throw new NotImplementedException();
        }



        public string HämtaSvar()
        {
            string text = "";

            text = text + antalRätt;

            return text;

        }

        internal override bool IsCorrect(string text)
        {
            throw new NotImplementedException();
        }
    }
}
