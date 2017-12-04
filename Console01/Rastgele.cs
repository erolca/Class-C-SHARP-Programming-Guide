using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console01
{
    class Rastgele
    {
        static Random rnd = null;

        public static int Uret(int min, int max)

        {

            if (rnd ==null)
                rnd = new Random();

            return rnd.Next(min, max);
        }



    }
}
