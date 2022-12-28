using System.Reflection;
using OOP._101.Draft;

internal class Program
{
    private static void Main(string[] args)
    {
        // Sıra geldi tanımlanmış class dan bir örnek-instance-nesne yaratmaya
        // <Sınıf adı> <Nesne adı> = new <Sınıf Adı>

        clsCarGallery carGalleryM = new clsCarGallery(); // Nesnem tanımlanmış olan sınıftan kendini örnekledi(instance aldı..nesne yaratıldı bellekte)

        
        // nesnemizin özelliklerine ulaşalım

        carGalleryM.Colour = "Füme";

        carGalleryM.Brand = "Mercedes"; // bellekte boş olarak duran yerleri doldurdum veri ile
        carGalleryM.Model = "C200";


           Console.WriteLine("Arabanın markası : " + carGalleryM.Brand + " - Modeli : " + carGalleryM.Model + " - Rengi :" + carGalleryM.Colour);

            Console.WriteLine(carGalleryM.Price.ToString()+"\n\n"); //  fiyatını da sınıf içinde default olarak tanımlanmış propertiy den (özellikten) alacak

        clsStudent clsStudent=new clsStudent();

        clsStudent.Name = "Ümit";
        clsStudent.Surname = "Karaçivi";

        Console.WriteLine("Bu arabanın sabihi : {0} {1}",clsStudent.Name,clsStudent.Surname );

        // Parametrik Constructor örneği

        new clsHome(234); // 234 değeri class a geçilecek olan prametre değeridir

        // Overload Constructor örneği
        Console.WriteLine("Overload Constructor\n");

        new clsHomeOL(); // class çalış ama parametresiz ctor

        new clsHomeOL(675); // tek parametreli ctor

        new clsHomeOL(985, "Wall Street"); // çift parametreli ctor







        Console.ReadKey();


        //Console.WriteLine("Hello, World!");
    }



}