using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B0226497_段昱如_PDPR__Week14_4
{
    class Program
    {
        public static void Salary(int a)
        {
            if (a >= 120)
                Console.Write("時薪:" + a + " 高時薪");
            else
                Console.Write("時薪:" + a + " 低時薪");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("B0226497_段昱如_PDPR__Week14_4");
            int salary;
            Console.Write("請輸入時薪值:");
            salary = int.Parse(Console.ReadLine());
            Salary(salary);
            Console.ReadLine();
        }
    }
}
