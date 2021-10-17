using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            A all = new A();
            all.InfoAboutAll();
            Console.ReadKey();
        }
    }
    class B
    {
        public string Name;
        public virtual void Method1()
        {
            Console.WriteLine($"Назва класу: {Name}");
        }
        
        public virtual void MethodforD(int Number)
        {
            Console.WriteLine($"Кiлькiсть магазинiв: {Number}");
        }
        
        public virtual  void MethodforC(string Owner)
        {
            Console.WriteLine($"Власник: {Owner}");
        }
        public B(string Name)
        {
            this.Name = Name;
        }

    }
    class A
    {
        public A()
        {

        }
        C c1 = new C("Клас С");
        D d1 = new D("Клас D");
        public A( C shop,D many)
        {
            this.c1 = shop;
            this.d1 = many;
        }
        public void InfoAboutAll()
        {
            c1.Method1();
            c1.MethodforC("Петро");
            d1.Method1();
            d1.MethodforD(5);
        }
        
    }
    class C:B
    {
        public C(string Name)
            :base(Name)
        {
            
        }
        public override void Method1()
        {
            base.Method1();
        }
        public override void MethodforC(string Owner)
        {
            base.MethodforC(Owner);
        }

    }
    class D:B
    {
        public D(string Name)
            : base(Name)
        {

        }
        public override void Method1()
        {
            base.Method1();
        }
        public override void MethodforD(int Number)
        {
            base.MethodforD(Number);
        }


    }
}
