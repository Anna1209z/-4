using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Diagnostics;

namespace _4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            InfoClass();
            Console.ReadKey();
        }
        static void InfoClass()
        {
            Main mainclass = new Main("Головний клас");
            mainclass.Method1();
            Next1 next1 = new Next1("Клас-наслiдник", "Type");
            next1.Method1();
            next1.L();
            Next2 next2 = new Next2("Клас-наслiдник", "info");
            next2.Method1();
            next2.L();
        }
        
    }
    class Main
    {
        public string Name1
        {
            get; set;
        }
        public Main(string name)
        {
            this.Name1 = name;
        }
        public virtual void Method1()
        {
            Console.WriteLine($"I`мя класу:{Name1}");
         
        }

    }
    class Next1 : Main
    {

        public string TypeClass { get; set; }
        public Next1(string nameclass, string typeclass)
            : base(nameclass)
        {
            this.TypeClass = typeclass;
        }

        public override void Method1()
        {
            base.Method1();

        }
        public void L()
        {
            Type type = typeof(Next1);
            PropertyInfo[] info = type.GetProperties();
            foreach (PropertyInfo lb in info)
            {
                Console.WriteLine($"{lb.Name},{lb.PropertyType}");

                
                StackTrace stackTrace = new StackTrace();
                System.Diagnostics.Debug.WriteLine($"Property {lb.Name}, Type - {lb.PropertyType}");
            }
        }
    }
    class Next2: Main
    {
        public string Info3 { get; set; }
        public Next2(string name, string info)
            : base(name)
        {
            this.Info3 = info;
        }

        public void L()
        {
            Type type = typeof(Next2);
            PropertyInfo[] info = type.GetProperties();
            foreach (PropertyInfo lb in info)
            {
                Console.WriteLine($"{lb.Name},{lb.PropertyType}");

                StackTrace stackTrace = new StackTrace();
                System.Diagnostics.Debug.WriteLine($"Property {lb.Name}, Type - {lb.PropertyType}");
            }
        }
    }
}

