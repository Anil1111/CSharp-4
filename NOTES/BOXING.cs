using System;

namespace ToSa
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 123;

            // Boxing copies the value of i into object o.
            object o = i;

            // Change the value of i.
            i = 456;

            // The change in i doesn't affect the value stored in o.
            Console.WriteLine("The value-type value = {0}", i);
            Console.WriteLine("The object-type value = {0}", o);

            Console.ReadKey();
        }
    }
}
/* Output:
The value-type value = 456
The object-type value = 123
*/