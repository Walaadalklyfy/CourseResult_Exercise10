using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseResult_Exercise10
{
    internal class CourseResult
    {
        
    
        public string StudentName { get; set; }
        private double mark;
        public double Mark
        {
            get

            {
                return mark;

            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    mark = value;
                }
                else
                {
                    Console.Write("Invalid Mark! Mark must be between 0 and 100.");
                }


            }
        }
        private string Grade
        {
            get
            {
                if (Mark <= 100 && Mark >= 85)
                {
                    return "A";
                }
                else if (Mark <= 84 && Mark >= 75)
                {
                    return "B";
                }
                else if (Mark <= 74 && Mark >= 65)
                {
                    return "C";
                }
                else if (Mark <= 64 && Mark >= 50)
                {
                    return "D";
                }
                else
                {
                    return "F";
                }
            }
        }

        public bool Passed
        {
            get
            {
                if (Mark >= 50)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }


        }
        public void PrintResult()
        {
            Console.WriteLine("=====Student Result=====");
            Console.WriteLine("Name :" + StudentName);
            Console.WriteLine("Mark :" + Mark);
            Console.WriteLine("Grade :" + Grade);
            Console.WriteLine("Passed :" + Passed);

        }
    }
}








    

