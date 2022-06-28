using System;
namespace Begineer
{
    internal class primitive_data_types
    {
        public static void AllPrimitiveDataTypes()//Use of all the main Data Types
        { 
            byte a = 1;
            int count = 500;
            float total = 95.4f;
            char character = 'A';
            string str = "Naman Jain";
            bool bol = true;
            var newThing = "Naman";
            Console.WriteLine("Values: {0}{1}{2}{3}{4}{5}{6}{7}", a, count, total, character, str, bol, newThing);
            //Use of the Operations like type conversion
            int i = a;
            byte b = (byte)count;//Implict type conversion will overflow
            var number = "123";
            int j = Convert.ToInt32(number);// Explicit Type Conversion

        }
    }
}