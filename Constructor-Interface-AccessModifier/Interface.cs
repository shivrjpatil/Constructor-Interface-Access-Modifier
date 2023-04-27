using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Interface_AccessModifier
{
    interface Ipig
    {
        void PigSound(); // interface method (does not have a body)
    }
    interface Idog
    {
        void DogSound();
    }

    // Animal "implements" the Ipig and Idog interfaces
    class Animal : Ipig, Idog
    {
        public void PigSound()
        {
            // The body of pigSound() is provided here
            Console.WriteLine("The pig says: wee wee");
        }
        public void DogSound()
        {
            Console.WriteLine("The dog says:Boww Boww");
        }
    }
}

