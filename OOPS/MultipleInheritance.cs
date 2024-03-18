using System;


namespace OOPS
{

    interface IA
    {
        void APrint();
    }

    class A : IA
    {
        public void APrint()
        {
            Console.WriteLine("A class");
        }
    }
    interface IB
    {
        void BPrint();
    }

    class B : IB
    {
        public void BPrint()
        {
            Console.WriteLine("B class");
        }
    }

    class AB : IA, IB
    {
        A a = new A();
        B b = new B();
        public void APrint()
        {
            a.APrint();
        }

        public void BPrint()
        {
            b.BPrint();
        }
    }
    class MultipleInheritance
    {

    }
}
