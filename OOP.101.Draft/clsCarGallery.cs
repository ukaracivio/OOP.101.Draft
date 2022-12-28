using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP._101.Draft
{
    internal class clsCarGallery
    {
        // Yapıcı metot
        public clsCarGallery() 
        {
            GalleryName = "Project 100 KY Gallery";

            Console.WriteLine("Galerimizin Adı : {0}",GalleryName);
        }

        // classın propertyleri
        public string? Brand { get; set; } // Marka 
        public string? Model { get; set; } // Model
        public string? MClass { get; set; } // Sınıf (B,C,SUV)
        public int MPower { get; set; } // Motor gücü 90,140 Beygir ...
        public int MVolume { get; set; } // 1400,2000 cc
        private string? MSerial { get; set; } // Motor seri no XSDRRT%%&Y/YWGGDS
        public char GasType { get; set; } // Yakıt Türü
        public char GearType { get; set; } // Vites türü
        public string? CaseType { get; set; } // Kasa tipi
        public int ProducedYear { get; set; } // Üretildiği yıl
        public string? Colour { get; set; }  // renk bilgisi
        
        public int Price = 100000; // default bir değer atadım.

        public string? GalleryName { get; set; }

    }
}
