using System;

namespace smaple
{
    class A
    {
        public void abc(int q)
        {
            Console.WriteLine("abc from A");
        }
    }
    class B : A
    {
        public int abc(double p)
        {
            Console.WriteLine("abc from B");
            return (5);
        }
        
    }
    class Program {
        static void Main(string[] args)
        {
            int i = 5;
            B b = new B();
            b.abc((int)i);
            Console.ReadLine();
            
        }
    }
    

}
