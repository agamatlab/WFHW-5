using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFHW_5
{
    public class Car
    {
        public Car(string vendor, string model, int year, float engine, Image carImage)
        {
            Vendor = vendor;
            Model = model;
            Year = year;
            Engine = engine;
            CarImage = carImage;     
        }

        public string Vendor{ get; set; }
        public string Model { get; set; }
        public int Year{ get; set; }
        public float Engine{ get; set; }
        public Image CarImage { get; set; }
    }
}
