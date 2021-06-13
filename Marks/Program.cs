using System;

namespace Marks
{
    class Program
    {
        static void Main(string[] args)
        {
            int mark; 
            Console.Write("Enter Student Mark: ");
            mark = Convert.ToInt32(Console.ReadLine());

            if (mark > 91 && mark <= 100)
            {
                Console.WriteLine("Student Got A+");
            }
            else if(mark>81 && mark <=90)
            {
                Console.WriteLine("Student Got A");
            }
            else if(mark>71 && mark <=80)
            {
                Console.WriteLine("Student Got B");
            }
            else if (mark>61 && mark<=70)
            {
                Console.WriteLine("Student Got C");
            }
            else
            {
                Console.WriteLine("Student Failed");
                Console.ReadKey();
            }    
        }
    }
}
