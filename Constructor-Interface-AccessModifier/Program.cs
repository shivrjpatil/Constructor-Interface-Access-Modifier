using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Interface_AccessModifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Default Constructor
            Constructor constructor2=new Constructor();
            //calling of Parameterless Constructor
            new Constructor();
            //Calling Parameterized constructor
            Constructor constructor1 = new Constructor("Bugatti", 50000);

            Console.WriteLine("Brand: " + constructor1.brand);
            Console.WriteLine("Price: " + constructor1.price);
            Console.ReadLine();
        }
    }
}
