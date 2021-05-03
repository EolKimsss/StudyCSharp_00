using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace InheritTest
{
    class Dog : Animal
    {

        public string Color { get; set; }

        public Dog() { this.Age = 0; this.Color = "흰색"; }


        public void Bark() { Console.WriteLine("왈왈"); }

        
    }

}
