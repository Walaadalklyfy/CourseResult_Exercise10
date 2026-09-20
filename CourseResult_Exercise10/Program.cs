namespace CourseResult_Exercise10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                CourseResult S = new CourseResult();
                Console.WriteLine("=====Welcome System=====");
                Console.Write("Enter StudentName :");
                S.StudentName = Console.ReadLine();
                Console.Write("Enter Mark :");
                S.Mark = double.Parse(Console.ReadLine());
                S.PrintResult();
                Console.WriteLine("Testing Invalid Mark");
                S.Mark = 120;

            }
        }
    }

}
    

