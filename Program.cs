using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TERNARYIFEHLIYET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yas = 0;
            bool birsayimi = false;
            
            Console.WriteLine("Yaşınızı belirtin lütfen");
            do
            {
                Console.WriteLine("lÜTFEN yaşınızı rakam olarak girin");
                birsayimi = int.TryParse(Console.ReadLine(), out yas);
            } while (birsayimi==false);
            
            string ehliyet = yas >= 18 ? "ALIR" : "ALAMAZ";

            Console.WriteLine("ŞAHIS EHLİYET " + ehliyet);
        }
    }
}
