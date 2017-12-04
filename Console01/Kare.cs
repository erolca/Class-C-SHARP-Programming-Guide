using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console01
{
    class Kare
    {

        private int boyut;

        private ConsoleColor renk;

        public Kare(int boyut)
        {
            this.boyut = boyut;
            renk =  (ConsoleColor) Rastgele.Uret(1, 15);    
        }

        public void Temizle()
        {

            Console.Clear();

        }


        public  void Ciz()
        {

            ConsoleColor LastConsoleColor = Console.ForegroundColor;
            Console.ForegroundColor = renk;

            for (int i = 0; i < boyut; i++)
                Console.Write("*");

            Console.SetCursorPosition(0,boyut-1);

            for (int i = 0; i < boyut; i++)
                Console.Write("*");

            for (int i = 0; i < boyut; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("*");

                Console.SetCursorPosition(boyut - 1,i);
                Console.Write("*");


            }

           
            Console.ForegroundColor = LastConsoleColor;




        }

        public void BoyutAta(int boyut)
        {

            this.boyut = boyut;

        }

        public void RenkAta(ConsoleColor renk)
        {

            this.renk = renk;

        }



    }
}
