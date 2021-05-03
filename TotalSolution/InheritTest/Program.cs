using System;
using System.Collections.Generic;

namespace InheritTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dog> dogs = new List<Dog>()
            {
                new Dog(),new Dog()
            };
            List<Cat> cats = new List<Cat>()
            {
                new Cat(),new Cat()
            };

            foreach (Dog item in dogs)
            {

                item.Eat();
                item.Sleep();
                item.Bark();

            }
            foreach (Cat item in cats)
            {


                item.Eat();
                item.Sleep();
                item.Meow();

            }
        }
    }
}
