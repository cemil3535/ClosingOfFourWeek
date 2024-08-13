// See https://aka.ms/new-console-template for more information

using ClosingOfFourWeek;
using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        bool repeat = true;

    GoHere:
        while (repeat)
        {

            Console.WriteLine("Telefon Uretmek icin 1\nBilgisayar uretmek icin 2'ye basiniz.");
            string userEnter = Console.ReadLine();

            //When 1 is selected, the phone generation is generated and the necessary values ​​are defined.
            if (userEnter == "1")
            {
                Phone phone = new Phone();
                Console.Write("Lutfen Seri Numarasini Giriniz: ");
                phone.SerialNumber = Console.ReadLine();
                Console.Write("Lutfen Telefonun Adini Giriniz: ");
                phone.ProductName = Console.ReadLine();
                Console.Write("Lutfen Aciklama Giriniz: ");
                phone.ProductDescription = Console.ReadLine();
                Console.Write("Lutfen Isletim Sistemini Giriniz: ");
                phone.OperatingSystem = Console.ReadLine();
                Console.Write("Turkiye Lisansli Mi? (Evet/Hayir): ");
                phone.TRLicensed = Convert.ToBoolean(Console.ReadLine().ToLower() == "evet");

                //Calling and displaying the defined values ​​in the relevant method
                Console.WriteLine("Asagidaki Urun Basariyla Uretildi.");
                Console.WriteLine("--------------------------------------------");
                phone.DisplayInfo();
            }
            // When 2 is selected, the computer generation is generated and the necessary values ​​are defined.
            else if (userEnter == "2")
            {
                Computer computer = new Computer();
                Console.Write("Lutfen Seri Numarasini Giriniz: ");
                computer.SerialNumber = Console.ReadLine();
                Console.Write("Lutfen Bilgisayarinizin Adini Giriniz: ");
                computer.ProductName = Console.ReadLine();
                Console.Write("Lutfen Aciklama Giriniz: ");
                computer.ProductDescription = Console.ReadLine();
                Console.Write("Lutfen Isletim Sistemini Giriniz: ");
                computer.OperatingSystem = Console.ReadLine();
                Console.Write("Lutfen USB Giris Sayisini Giriniz: ");
                computer.UsbGateNumber = Convert.ToInt32(Console.ReadLine());
                Console.Write("Bluetooth Var Mi? (Evet/Hayir): ");
                computer.Bluetooth = Convert.ToBoolean(Console.ReadLine().ToLower() == "evet");


                // Calling and displaying the defined values ​​in the relevant method
                Console.WriteLine("Asagidaki Urun Basariyla Uretildi.");
                Console.WriteLine("--------------------------------------------");
                computer.DisplayInfo();
            }
            else
            {
                Console.WriteLine("Yanlis sayi girdiniz.");
                goto GoHere;
            }
            //query whether the loop should continue
            Console.WriteLine("Baska Bir Urun Uretmek Ister misiniz? (Evet/Hayir): ");
            repeat = Console.ReadLine().ToLower() == "evet";
        }
        Console.WriteLine("Iyi Gunler!");
    }

}







