using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_5
{
    class pet_store
    {
        private string animal;
        private string sex;
        private string name;
        private int price;
        public static int count;

        static pet_store() { count = 0; }
        public pet_store (): this(null, null, null, 0){ }
        public pet_store(string animal, string sex, string name, int price)
        {
            this.animal = animal;
            this.sex = sex;
            this.name = name;
            this.price = price;
        }

        public void SetAnimal(string animal) { this.animal = animal; }
        public void SetSex(string sex) { this.sex = sex; }
        public void SetName(string name) { this.name = name; }
        public void SetPrice(int price) { this.price = price; }

        public void Eat()
        {
            Console.WriteLine("животное ест");
        }




    }
}
