using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClosingOfFourWeek
{
    //base class
    public abstract class BaseMakine
    {
        // Property to identify
        public DateTime ProductDate { get; set; }
        public string SerialNumber { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string OperatingSystem { get; set; }

        //  Define the BaseMakine constructor for ProductDat
        public BaseMakine()
        {
            ProductDate = DateTime.Now;

        }
        // Define a virtual method that displays general information
        public virtual void DisplayInfo()
        {

            Console.WriteLine($"Seri Numarsi: {SerialNumber} Urun Adi: {ProductName} Urun Aciklamasi: {ProductDescription}  Isletim Sistemi: {OperatingSystem} Uretim Tarihi: {ProductDate.ToShortDateString()}");
        }
        // abstract metod 
        public abstract void ProductNameGet();

    }
    // derived class
    class Phone : BaseMakine
    {
        // TRLicensed of identify
        public bool TRLicensed { get; set; }


        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Turkiye Lisansi Var Mi?: {(TRLicensed ? "Evet" : "Hayir")}");
        }

        // abstract metod override
        public override void ProductNameGet()
        {
            Console.WriteLine($"Telefonunuzun Adi-------> {ProductName}");
        }
    }

    //derived class
    class Computer : BaseMakine
    {
        // UsbGetNumber property of identify
        int _usbGateNumber;
        public int UsbGateNumber
        {
            get
            {
                return _usbGateNumber;
            }

            set
            {
                if (value == 2 || value == 4)
                {
                    _usbGateNumber = value;
                }
                else
                {
                    Console.WriteLine("USB giris sayisi 2 veya 4 olabilir.");
                    _usbGateNumber = -1;
                }
            }
        }

        // Bluetooth property od identify
        public bool Bluetooth { get; set; }

        public override void DisplayInfo()
        {
            base .DisplayInfo();
            Console.WriteLine($"USB Giris Sayisi: {UsbGateNumber}\nBluetooth Var Mi?: {(Bluetooth ? "Evet" : "Hayir")}");

        }

        // abstract metod override
        public override void ProductNameGet()
        {
            Console.WriteLine($"Bilgisayarinizin Adi------> {ProductName}");
        }
    }


}
