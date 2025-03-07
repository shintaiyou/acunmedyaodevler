using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ödev_4.NewFolder
{
    public class arabalar
    {
        public string araç;

        public double litre;
        public string li;
        public void yazdır(string araç,double litre,string li)
        {
            Console.WriteLine( araç + " "+ "->"+ " " +  litre + li);
        }
    }
}
