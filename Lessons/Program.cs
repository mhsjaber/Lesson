using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons
{
    public delegate void HelloDelegateMethod(string str);
    class Program
    {
        static void Main(string[] args)
        {
            float floatval = 923241;
            int intval1 = (int)floatval; //If float value is greater than int.Max then it will do unexpected behaviour without throwing error. 
            int intval2 = Convert.ToInt32(floatval); //Throw an error

            string strval = "100";
            int intval3 = int.Parse(strval); //Throw an error if string have non-numeric value
            int intval4 = 0;
            int.TryParse(strval, out intval4);//If string has real number intval4 will 100, otherwise 0.

            int a = 10;
            Ref(ref a); //REFERENCE parameter; REFERENCE is almost like as POINTER; But not STATIC 

            int Sum, Product;
            Calculate(10, 20, out Sum, out Product); // OUT parameter; Here it returns 2 values of Sum & Product from Calculate().

            ArrayParameter(1, 2, 3, 4); //ARRAY parameter

            ParentClass pc = new ChildClass1();
            pc.PrintName("Jaber", "Kibria");  //Function OVERRIDING (in Polymorphism). Execute Child class method by using virtual-override.

            ParentClass pc1 = new ChildClass2();
            pc1.PrintName("Jaber", "Kibria");  //Function HIDING (in Inheritance)

            Add(1, 3); //Function OVERLOADING (functions can be overloaded by different type/number of parameters)

            IClass ic = new IClass();
            ic.Print();
            ((IInterface)ic).AnotherMethod();  //Typecasting of Interface; Used when more than 1 inherited Interface has same Method
            //Reference variable of Interface can point to a class reference; Object of Interface can not be created,
            IInterface ii = new IClass();  
            ii.Print();

            //Abstract class is same as Interface. But child class dont have to implement when it (Child Class) has also a abstract Keyword.
            AbsClassBase abb = new AbsClassChild();

            HelloDelegateMethod hm = new HelloDelegateMethod(HelloMethod);
            hm("Hello for delegate method.");
            Console.ReadKey();
        }
        public static void HelloMethod(string str)
        {
            Console.WriteLine(str);
        }


        //////////////////////////////////////////
        // Program Class indirectly inheriting 2 classes A & B
        A ca = new A();
        B cb = new B();
        public void APrint()
        {
            ca.APrint();
        }
        public void BPrint()
        {
            cb.BPrint();
        }
        //////////////////////////////////////////
        //////////////////////////////////////////

        private static void ArrayParameter(params int[] param) { }
        public static void Calculate(int a, int b, out int sum, out int product) { sum = a + b; product = a * b; }
        public static void Ref(ref int A) { A = 100; }
        public static int Add(string A, int B) { return B; }
        public static int Add(int A, int B) { return A + B; }
        public static int Add(int A, int B, int C) { return A + B + C; }
    }
}
