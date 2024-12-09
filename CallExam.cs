using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsProject1
{
    internal class CallExam
    {
        static void Main(string[] args)
        {
            Exam em= new Exam();
           em.result();
            Console.WriteLine("Student name" + em[1]);
            
            //  Console.WriteLine("Your percentage is" + em.result());
          
            
        }
    }
}
