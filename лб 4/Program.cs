using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лб_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть номер ключа: \n1) trial \n2) pro \n3)продовжити роботу без введення ключа ");
            int key = Convert.ToInt32(Console.ReadLine());
            ApplicationLicense app = new ApplicationLicense();
            app.CheckKey(key);
            Console.ReadKey();
        }
    }
    class ApplicationLicense
    {
        public string a, b, c;
        public int key;


        public void CheckKey(int key)
        {
            if (key == 1)
            {
                Console.WriteLine(AllowTrial(a));
            }
            else if (key == 3)
            {
                Console.WriteLine(AllowCommon(b));
            }
            else if (key == 2)
            {
                Console.WriteLine(AllowPro(c));
            }
            else
            {
                Console.WriteLine("Неправильно введенi значення");

            }

        }
        public string AllowTrial(string a)
        {
            return a = "Трiальний режим";
        }
        public string AllowCommon(string b)
        {
            return b = "Безкоштовна версiя";

        }
        public string AllowPro(string c)
        {
            return c = "Платна версiя";

        }
    }
}
