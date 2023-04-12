namespace LineComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1, y1, x2, y2, x3, y3, x4, y4;
            
            //Welcome message
            Console.WriteLine("Welcome to Line Comparison Computation Program");


            Console.WriteLine("Enter the coordinates of the first point for line 1:");
            Console.Write("x1 = ");
            x1 = double.Parse(Console.ReadLine());
            Console.Write("y1 = ");
            y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the coordinates of the second point for line 1:");
            Console.Write("x2 = ");
            x2 = double.Parse(Console.ReadLine());
            Console.Write("y2 = ");
            y2 = double.Parse(Console.ReadLine());

            Line line1 = new Line(x1, y1, x2, y2);

            Console.WriteLine("Enter the coordinates of the first point for line 2:");
            Console.Write("x3 = ");
            x3 = double.Parse(Console.ReadLine());
            Console.Write("y3 = ");
            y3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the coordinates of the second point for line 2:");
            Console.Write("x4 = ");
            x4 = double.Parse(Console.ReadLine());
            Console.Write("y4 = ");
            y4 = double.Parse(Console.ReadLine());

            Line line2 = new Line(x3, y3, x4, y4);

            //Compare Lines
            if (line1.Equals(line2))
            {
                Console.WriteLine("The two lines are equal.");
            }
            else
            {
                Console.WriteLine("The two lines are not equal.");
            }
        }
    }
}