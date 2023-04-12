namespace LineComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1, y1, x2, y2;

            //Welcome message
            Console.WriteLine("Welcome to Line Comparison Computation Program");
            
            Console.WriteLine("Enter the coordinates of the first point:");
            Console.Write("x1 = ");
            x1 = double.Parse(Console.ReadLine());
            Console.Write("y1 = ");
            y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the coordinates of the second point:");
            Console.Write("x2 = ");
            x2 = double.Parse(Console.ReadLine());
            Console.Write("y2 = ");
            y2 = double.Parse(Console.ReadLine());

            double length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine("The length of the line is: " + length);
        }
    }
}