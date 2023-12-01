using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedLibrary;

namespace MainApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the operation you want to perform \n1.Add Student \n2.Add Assignment");
            int option = int.Parse(Console.ReadLine());
            Student student = new Student();
            Teacher teacher = new Teacher();
            switch (option)
            {
                case 1:
                    {
                        student.AddStudent();
                        student.Display();
                        break;
                    }
                case 2:
                    {
                        teacher.AddAssignment();
                        teacher.DiplayAssignment();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid Choice!!!");
                        break;
                    }
            }
            Console.ReadKey();
        }
    }
}
