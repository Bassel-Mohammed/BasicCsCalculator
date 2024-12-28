// See https://aka.ms/new-console-template for more information


using BasicCalculator;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Enter value for x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter value for y: ");
        double y = Convert.ToDouble(Console.ReadLine());

       
        Calculator calc = new Calculator(x, y);
       
        Console.WriteLine("Results:");

        Console.WriteLine("Sum (x + y) : " + calc.Add());

        Console.WriteLine("Difference (x - y):" + calc.Subtract());

        Console.WriteLine("Product (x * y):" + calc.Multiply());

        Console.WriteLine("Quotient (x / y): " + calc.Divide());
    }
}
