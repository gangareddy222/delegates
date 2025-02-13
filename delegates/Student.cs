using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{
    public class Student
    {
        private string name;

        public Student(string name)
        {
            this.name = name;
        }

        public void RespondToBell(string message)
        {
            Console.WriteLine($"{name} says: {message} and pack books");
        }
        public void Newone(string message)
        {
            Console.WriteLine($"{message} passed to {name}");
        }
    }
}
