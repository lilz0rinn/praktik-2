
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;
        
        Console.WriteLine("Введіть значення Х:   ");

        double x = Convert.ToDouble(Console.ReadLine());
        double y = 0;

        if (x < 0)
        {
            y = 10 + Math.Pow(x, 2);
        }
        else if (x >= 0 && x <= 10)
        {
            double sum = 0;
            for (int i = 0; i <= x; i++)
            {
                sum += 5 * Math.Pow(i, 4);
            }

            y = 1.0 / 5 * sum;
        }
        else // x > 10
        {
            double product = 1;
            for (int i = 10; i <= x; i++)
            {
                product *= (i + 1) / 2.0;
            }
            y = 15 + product;
        }

        Console.WriteLine("Значення У: " + y);
    }
    
}