using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP._101.Draft
{
    internal class clsStaticCTOR
    {
        // static CTOR

        public clsStaticCTOR() 
        {
            tickTack = DateTime.Now.Ticks;
        
        }  


        public static long tickTack;

    }
}
