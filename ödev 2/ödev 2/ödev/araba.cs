using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev_2.ödev
{
    public class Araba
    {
        public string marka;
        public string sür;
        public string yüz;
        public string uc;
        public void yazdir(string marka ,string sür, string yüz, string uç)
        {
            Console.WriteLine(marka+ " " +sür + " " + yüz + " " + uç);

        }
        public void yazdir1(string marka ,string yüz, string uç)
        {
            Console.WriteLine(marka + " " + yüz + " " + uç);

        }
        public void yazdir2( string marka ,string uç)
        {
            Console.WriteLine(marka + " " + uç);

        }
    }
}
