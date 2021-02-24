using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_5
{
    public partial class Car
    {
        private string brand { get; set; }
        private double power { get; set; }
        private string color { get; set; }
        private int price { get; set; }
        private int year { get; set; }

        static public int count;
        static public string name;

        public Car() : this(null, 0, null, 0, 0) { }
        public Car(string brand) : this(brand, 0, null, 0, 0) { }
        public Car(string brand, double power, string color, int price, int year)
        {
            this.brand = brand;
            this.power = power;
            this.color = color;
            this.price = price;
            this.year = year;
            count++;
        }

        
        static Car()
        {
            count = 0;
            name = "car";
        }
        public void GetInfo()
        {
            Console.WriteLine("Бренд: " + brand);
            Console.WriteLine("Объем двигателя: " + power);
            Console.WriteLine("Цвет: " + color);
            Console.WriteLine("Цена: " + price);
            Console.WriteLine("Год выпуска: " + year);
            Console.WriteLine("");
        }


        public void SetBrand(string brand) { this.brand = brand; }
        public void SetPower(double power) { this.power = power; }
        public void SetColor(string color) { this.color = color; }
        public void SetPrice(int price) { this.price = price; }
        public void SetYear(int year) { this.year = year; }
      
        public void Discount(ref int price)
        {
            if (this.year <= 2000) price -= 65000;
            else if (this.year <= 2010) price -= 25000;
        }
    }
}
