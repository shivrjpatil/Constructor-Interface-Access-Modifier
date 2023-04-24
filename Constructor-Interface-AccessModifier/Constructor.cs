using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Interface_AccessModifier
{
    internal class Constructor
    {

        public Constructor()
        {
            Console.WriteLine("This is Parameterless constructor");
        }

        public  string brand;
        public int price;

        // parameterized constructor
        public Constructor(string theBrand, int thePrice)
        {

            brand = theBrand;
            price = thePrice;
        }
    }
}
