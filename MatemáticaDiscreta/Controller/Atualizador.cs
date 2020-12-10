using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatemáticaDiscreta.Controller
{
    public class Atualizador
    {


        static public double ValueM = 0;
        static public double ValueN = 0;

        static public bool Box1, Box2;


        static double status = 0;
        static public double stats
        {
            get
            {
                double old = 0; ;
                if (status == 1)
                {
                    old = 1;
                }
                status = 0;
                return old;

            }
            set
            {
                status = value;
            }

        }


    }
}
