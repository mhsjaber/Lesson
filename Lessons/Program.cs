using Lessons.InheritancePolymorphism;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Ref(ref a); //REFERENCE parameter; REFERENCE is almost like as POINTER; But not STATIC 

            int Sum, Product;
            Calculate(10, 20, out Sum, out Product); // OUT parameter; Here it returns 2 values of Sum & Product from Calculate().

            ArrayParameter(1, 2, 3, 4); //ARRAY parameter

            ParentClass pc = new ChildClass1();
            pc.PrintName("Jaber", "Kibria");  //Function OVERRIDING (in Polymorphism)

            ChildClass2 cc = new ChildClass2();
            cc.PrintName("Jaber", "Kibria");  //Function HIDING (in Inheritance)

            Add(1, 3); //Function OVERLOADING (can overload functions by number of parameters)

            Console.ReadKey();
        }
        private static void ArrayParameter(params int[] param)
        {
            throw new NotImplementedException();
        }
        public static void Calculate(int a, int b, out int sum, out int product)
        {
            sum = a + b;
            product = a * b;
        }
        public static void Ref(ref int A)
        {
            A = 100;
        }
        public static int Add(int A, int B)
        {
            return A + B;
        }
        public static int Add(string A, int B)
        {
            return B;
        }
        public static int Add(int A, int B, int C)
        {
            return A + B + C;
        }
    }
}
