using System;

namespace Advance_1
{
    public delegate string MyDel(string str);
    class EventProgram
    {
        event MyDel MyEvent;
        public EventProgram()
        {
            this.MyEvent += new MyDel(this.WelcomeUser);
        }
        public string WelcomeUser(string username)
        {
            return "Welcome " + username;
        }
    }
    class Program
    {

        public delegate void addnum(int a, int b);//Use of Delegate
        public delegate void subnum(int a, int b);
        public void sum(int a, int b)
        {
            Console.WriteLine("(100 + 40={0}", a + b);
        }
        public void subtract(int a, int b)
        {
            Console.WriteLine("(100 - 60)={0}", a - b);
        }
        static void Main(string[] args)
        {
            genericpractice<string> name = new genericpractice<string>();
            name.value = "Naman Jain";
            genericpractice<float> version = new genericpractice<float>();
            version.value = 4.0F;

            Console.WriteLine(name.value);
            Console.WriteLine(version.value);
            Program obj = new Program();
            addnum del1 = new addnum(obj.sum);
        }
    }


}