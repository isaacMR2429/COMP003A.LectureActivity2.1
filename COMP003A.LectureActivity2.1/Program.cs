namespace COMP003A.LectureActivity2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            string input1 = Console.ReadLine();

            Console.Write("Enter second number: ");
            string input2 = Console.ReadLine();

            double num1 = double.Parse(input1);
            double num2 = double.Parse(input2);

            double sum = num1 + num2;
            double average = (num1 + num2) / 2;

            Console.WriteLine("\nUsing concatenation");
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Average: " + average);

            Console.WriteLine("\nUsing interpolation");
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Average: {average}");


        }
    }
}
