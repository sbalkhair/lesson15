using System;

namespace lesson15
{
    class Animal
    {
        public string Type { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }
        public decimal Price { get; set; }


        public void Eat()
        {
            Console.WriteLine("object eat");
        }

        public void Drink()
        {
            Console.WriteLine("object drink");
        }


    }
}
