using System;
using System.Text;




namespace Pogram
{

    class Program2
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            // --------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("Програма визначення кількості варівантів пароля ! ");
            Console.WriteLine("Оберіть кількість символів: ");
            Console.WriteLine();

            Console.WriteLine("1 - 4 симоли ");
            Console.WriteLine("2 - 5 символів ");
            Console.WriteLine("3 - 6 символів ");

            string input = Console.ReadLine();

            if (int.TryParse(input, out int num1))
            {
                if (num1 != 1 && num1 != 2 && num1 != 3)
                {
                    Console.WriteLine("Немає такого варіанту !");

                    Console.WriteLine("Оберіть кількість символів: ");
                    Console.WriteLine();

                    Console.WriteLine("1 - 4 симоли ");
                    Console.WriteLine("2 - 5 символів ");
                    Console.WriteLine("3 - 6 символів ");

                    string input2 = Console.ReadLine();
                    if (int.TryParse(input2, out int numtray))
                    {
                        if (numtray != 1 && numtray != 2 && numtray != 3)
                        {
                            Console.WriteLine("Немає такого варіанту !");

                        }
                    }
                }
            }
            // --------------------------------------------------------------------------------------------------------------------
            Console.ReadKey();

            Console.WriteLine("Оберіть припустимі символи ! ");
            Console.WriteLine(" 1 - цифри ");
            Console.WriteLine(" 2 - цифри і букви у нижньому регістрі ");
            Console.WriteLine(" 3 - цифри і букви у будь-якуому регістрі ");

            string chi = Console.ReadLine();
            if (int.TryParse(chi, out int num2))
                if (num2 != 1 && num2 != 2 && num2 != 3)
                {
                    Console.WriteLine("Немає такого варіанту !");

                    Console.WriteLine("Оберіть припустимі символи ! ");
                    Console.WriteLine(" 1 - цифри ");
                    Console.WriteLine(" 2 - цифри і букви у нижньому регістрі ");
                    Console.WriteLine(" 3 - цифри і букви у будь-якуому регістрі ");

                    string chi2 = Console.ReadLine();
                    if (int.TryParse(chi2, out int num3))
                        if (num3 != 1 && num3 != 2 && num3 != 3)
                        {
                            Console.WriteLine("Немає такого варіанту !");
                        }

                }
            // --------------------------------------------------------------------------------------------------------------------
            //    формула  A(62, 4) = 62*4

            switch (num1)
            {
                // --------------------------------------------------------------------------------------------------------------------
                case 1:
                    switch (num2)
                    {

                        case 1:
                            double number = 10;
                            int exponent = 4;

                            double result = Math.Pow(number, exponent);

                            Console.WriteLine(result);

                            break;

                        case 2:
                            double number5 = 36;
                            int exponent5 = 4;

                            double result5 = Math.Pow(number5, exponent5);

                            Console.WriteLine(result5);

                            break;


                        case 3:
                            double number4 = 62;
                            int exponent4 = 4;

                            double result4 = Math.Pow(number4, exponent4);

                            Console.WriteLine(result4);

                            break;
                    }

                    break;
                // --------------------------------------------------------------------------------------------------------------------
                case 2:
                    switch (num2)
                    {

                        case 1:
                            double number = 10;
                            int exponent = 5;

                            double result = Math.Pow(number, exponent);

                            Console.WriteLine(result);

                            break;

                        case 2:
                            double number5 = 36;
                            int exponent5 = 5;

                            double result5 = Math.Pow(number5, exponent5);

                            Console.WriteLine(result5);

                            break;


                        case 3:
                            
                            double number9 = 62;
                            int exponent9 = 5;

                            double result2 = Math.Pow(number9, exponent9);

                            Console.WriteLine(result2);
                            break;

                    }

                    break;

                // --------------------------------------------------------------------------------------------------------------------
                case 3:
                    switch (num2)
                    {

                        case 1:
                            double number = 10;
                            int exponent = 6;

                            double result = Math.Pow(number, exponent);

                            Console.WriteLine(result);

                            break;

                        case 2:
                            double number5 = 36;
                            int exponent5 = 6;

                            double result5 = Math.Pow(number5, exponent5);

                            Console.WriteLine(result5);

                            break;


                        case 3:
                            
                            double number2 = 62;
                            int exponent2 = 6;

                            double result2 = Math.Pow(number2, exponent2);

                            Console.WriteLine(result2);
                            break;

                    }

                    break;

            }


        }
    }
}
