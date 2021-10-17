using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Diagnostics; 

namespace _4._1
{
    class Program
    {
        static void Main(string[] args)           
        {
            Klass m1 = new Klass();
            m1.nameklass = "Перший клас";
            m1.Method1(7);
            Console.WriteLine("Наслiдування вiдбувається?");
            try
            {
                string answer = Console.ReadLine();
                if (answer == "Так")
                {
                    SecondKlass m2 = new SecondKlass("Другий клас");
                    m2.Non();
                }
                else
                {
                    Console.WriteLine("Кiнець");
                }
            }
            catch 
            {

                Console.WriteLine("Даннi введеннi не вiрно");
            }

            Console.ReadLine();
        }
    }
    class Klass
    {
        public string nameklass;
        public void Method1(int a)
        {
            Console.WriteLine($"Имя класса:{nameklass}");
            Console.WriteLine($"Число:{a}");
        }
    }
    class SecondKlass : Klass
    {
        public string Nameklass2
        {
            get;
            set;
        }
       
        public SecondKlass(string name)
        {
            this.Nameklass2 = name;
        }
        public void Non()
        {
            Type type = typeof(SecondKlass);
            PropertyInfo[] info = type.GetProperties();
            foreach ( PropertyInfo lb in info)
            {
                Console.WriteLine($"{lb.Name},{lb.PropertyType}");





                ConsoleColor tempColor = Console.ForegroundColor;
                StackTrace stackTrace = new StackTrace();
                Console.ForegroundColor = ConsoleColor.Red;
                System.Diagnostics.Debug.WriteLine($"Property {lb.Name}, Type - {lb.PropertyType}");
                Console.ForegroundColor = tempColor;
            }
        }
    }
}
