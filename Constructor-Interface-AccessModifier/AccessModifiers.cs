using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Interface_AccessModifier
{
    public class AccessModifiers
    {
        public int myPublicInt; // Accessible from anywhere
        private int myPrivateInt; // Accessible only within MyClass
        protected int myProtectedInt; // Accessible within MyClass and any derived classes
        internal int myInternalInt; // Accessible within the same assembly

        public void SetPrivateInt(int value)
        {
            myPrivateInt = value; // Can access myPrivateInt within MyClass
        }

        public void SetProtectedInt(int value)
        {
            myProtectedInt = value; // Can access myProtectedInt within MyClass and any derived classes
        }

        public void SetInternalInt(int value)
        {
            myInternalInt = value; // Can access myInternalInt within the same assembly
        }
    }

    public class MyDerivedClass : AccessModifiers
    {
        public void MyMethod()
        {
            myPublicInt = 42; // Can access myPublicInt from anywhere
            // myPrivateInt = 42; // Error - cannot access myPrivateInt outside of MyClass
            myProtectedInt = 42; // Can access myProtectedInt from MyClass and any derived classes
            myInternalInt = 42; // Can access myInternalInt within the same assembly
            Console.WriteLine(myPublicInt);
            Console.WriteLine(myInternalInt);
            Console.WriteLine(myProtectedInt);
        }
    }

}

