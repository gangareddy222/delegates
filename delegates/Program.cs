using System;
using static delegates.Example;

namespace delegates
    
{
    public delegate void ExampleDelegate(string message);
    class Program
    {
        static void Main(string[] args)
        {
            Example e = new Example();
            ExampleDelegate h = e.LogToConsole;
            h += e.LogToFile;
            h(" hello,doing delegates");
           

        }
    }
   
}