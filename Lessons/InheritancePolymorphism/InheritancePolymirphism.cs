using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons.InheritancePolymorphism
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
}
