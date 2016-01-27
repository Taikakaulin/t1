using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harj5
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void PrintData()
        {
            Console.WriteLine("Data");
            Console.WriteLine("-Name: " + Name);
            Console.WriteLine("-Age: " + Age);

        }
    }
}
