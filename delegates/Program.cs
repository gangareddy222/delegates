using System;
using static delegates.Example;

namespace delegates
    
{

    class Program
    {
        static void Main(string[] args)
        {
            Event e = new Event();

            Student s = new Student("ganga");
            Student g = new Student("reddy");

            e.bell += s.RespondToBell;
            e.bell += g.RespondToBell;
            e.bell += s.Newone;

            e.notiFy();
           

        }
    }
   
}