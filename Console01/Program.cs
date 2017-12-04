using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console01
{
    class Program
    {
        static void Main(string[] args)
        {

            Kare kare = new Kare(5);

            //kare.RenkAta(ConsoleColor.Blue);
            kare.Ciz();
            Console.ReadLine();

            kare.Temizle();

        }
    }
}
