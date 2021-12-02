using System;
using System.Collections.Generic;
using System.Text;

namespace Arv___sak
{
    class CD : Sak
    {

        protected string artist;

        public CD(string myTitle, string myArtist)
        {
            artist = myArtist;
            title = myTitle;
        }
        public override void SkrivUt()
        {
            Console.WriteLine("CD, Namn:" + title);
            Console.WriteLine("Artist:" + artist);
        }

    }
}
