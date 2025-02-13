using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{
     class Example
    {
        

        public  void LogToConsole(string message)
        {
            Console.WriteLine("from  log to console"+message);
        }

        public void LogToFile(string message)
        {
            Console.WriteLine("from LogToFile"+message);
        }


       

    }
}
