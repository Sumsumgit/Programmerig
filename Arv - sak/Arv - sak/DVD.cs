using System;
using System.Collections.Generic;
using System.Text;

namespace Arv___sak
{
    class DVD : Sak
    {
        protected string regisör;

        public DVD(string myTitle, string myRegisör)
        {
            regisör = myRegisör;
            title = myTitle;
        }
        public override void SkrivUt()
        {
            Console.WriteLine("DVD, Namn:" + title);
            Console.WriteLine("Regisör:" + regisör);
        }


    }
}
