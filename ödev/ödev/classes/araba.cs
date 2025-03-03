using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev.classes
{
    public class Araba
    { 
        public string marka;
        public string vitesTuru;
        public void yazdir (string marka, string vitesTuru)
        {
            Console.WriteLine(marka + " -> " + vitesTuru);

        }
    }
}
