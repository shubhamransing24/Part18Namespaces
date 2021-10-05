using System;
using Shu=Shubham.A;
using Sau=Saurabh.A;
namespace Part18Namespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            ////use fully qualified name or use the namespace in top
            //Shubham.A.print();
            //Saurabh.B.print();

            Shu.A.print();
            Sau.B.print();
        }
    }
}
namespace Shubham.A
{
    class A
    {
        public static void print()
        {
            Console.WriteLine("Print Method of Class A");

        }
    }
}
namespace Saurabh.A
{
    class B
    {
        public static void print()
        {
            Console.WriteLine("Print Method of Class B");

        }
    }
}