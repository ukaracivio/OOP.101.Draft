using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP._101.Draft
{
    // constructor overloading

    internal class clsHomeOL
    {
        public clsHomeOL() // parametresiz standard bir ctor
        {
            Console.WriteLine("Ev {0} caddesinde, {1} kapı numarasında bulunuyor...", StreetName, DoorNumber);
        }

        public clsHomeOL(int dn) // 1 parametreli bir ctor
        {
            DoorNumber= dn; // gelen parametreyi direkt property e atadım.

            Console.WriteLine("Ev {0} caddesinde, {1} kapı numarasında bulunuyor...", StreetName, DoorNumber);

        }

        public clsHomeOL(int dn,string sn) // 2 parametreli
        {
            DoorNumber = dn; // gelen parametreyi direkt property e atadım.
            StreetName= sn; // gelen sn parametresi ilgili yere aktarılıyor

            Console.WriteLine("Ev {0} caddesinde, {1} kapı numarasında bulunuyor...", StreetName, DoorNumber);

        }

        public int DoorNumber { get; set; } = 111;

        public string StreetName { get; set; } = "One Redmond Way..";
    }
}
