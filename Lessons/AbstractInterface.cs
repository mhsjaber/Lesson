using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons
{
    interface IInterface
    {
        void Print();
        void AnotherMethod();
    }
    class IClass :IInterface
    {
        void IInterface.AnotherMethod()
        {
            Console.WriteLine("This is another method.");
        }
        public void Print()
        {
            Console.WriteLine("Interface implimentation.");
        }
    }

    abstract class AbsClassBase
    {
        public abstract void Print();
    }

    class AbsClassChild :AbsClassBase
    {
        public override void Print()
        {
            Console.WriteLine("Abstract class inherited.");
        }
    }
}
