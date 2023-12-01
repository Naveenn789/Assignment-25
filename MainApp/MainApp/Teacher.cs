using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp
{
    public class Teacher
    {
        public int AssNum { get; private set; }
        public string Title { get; set; }

        public void AddAssignment()
        {
            Console.WriteLine("Enter the Assignment Number");
            AssNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Assignment Title");
            Title = Console.ReadLine();
        }
        public void DiplayAssignment()
        {
            Console.WriteLine("Project Id  :\t" + AssNum);
            Console.WriteLine("Project Name:\t" + Title);
        }
    }
}
