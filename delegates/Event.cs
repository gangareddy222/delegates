using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{

    public class Event
    {

        public delegate void Notify(string message);
        public event Notify bell;

        public void notiFy()
        {
            Console.WriteLine("teacher rings the bell");
            Thread.Sleep(3000);
            bell?.Invoke("Classs is over");
        }



    }
}
