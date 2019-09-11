using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewPr
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            string fstName = "";
            String secondName = "";
            string address = "";
            string contact = "";

            Console.WriteLine("Enter your First name Please : ");
            fstName = Console.ReadLine();

            Console.WriteLine("Enter your Second name Please : ");
            secondName = Console.ReadLine();

            Console.WriteLine("Enter your Age Please : ");
           age=Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter your address Please : ");
            address = Console.ReadLine();

            Console.WriteLine("Enter your contact Please :");
            contact = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(fstName + " " + secondName + ", " + age + ", " + address + ", " + contact);
            
            Console.ReadLine();
        }
    }
}
