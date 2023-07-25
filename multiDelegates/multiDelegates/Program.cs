using System;

namespace multiDelegates
   
{
    public delegate void MyDelegate(string Message);
    internal class Program
    {
        static void Main()
        {
            MyDelegate multicastDelegate = Method1;
            multicastDelegate += Method2;
            multicastDelegate += Method3;
            multicastDelegate("Hello Everyone");
            multicastDelegate -= Method2;
            multicastDelegate("Hello There");
         }
            static void Method1(string message)
            {
                Console.WriteLine("Method1:" +message);
            }
            static void Method2(string message)
            {
                Console.WriteLine("Method2:" + message);
            }
            static void Method3(string message)
            {
                Console.WriteLine("Method3:" + message);
            Console.ReadLine();
            }
    }
}
