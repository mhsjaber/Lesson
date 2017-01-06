using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons
{
    class ParentClass
    {
        public virtual void PrintName(string FirstName, string LastName)
        {
            Console.WriteLine(FirstName + " " + LastName + " - Parent Class 2");
        }
    }
    class ChildClass1 : ParentClass
    {
        public override void PrintName(string FirstName, string LastName)
        {
            Console.WriteLine(FirstName + " " + LastName + " - Child Class 1");
        }
    }
    class ChildClass2 : ParentClass
    {
        public new void PrintName(string FirstName, string LastName)
        {
            Console.WriteLine(FirstName + " " + LastName + " - Child Class 2");
        }
    }

    interface IA
    {
        void APrint();
    }
    public class A : IA
    {
        public void APrint()
        {
            Console.WriteLine("AInterface inherited from A Class");
        }
    }
    interface IB
    {
        void BPrint();
    }
    public class B : IB
    {
        public void BPrint()
        {
            Console.WriteLine("BInterface inherited from B Class");
        }
    }
}
