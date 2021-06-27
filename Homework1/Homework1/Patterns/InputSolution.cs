using System;


namespace Patterns
{
    class InputSolution
    {

        public static void EnterNumber()
        {
            Console.WriteLine("пожалуйста введите число: ");
            string value = Console.ReadLine();

            Compare(value);
        }

        public static void Calculation(int num)
        {
            try
            {
                checked
                {
                    int number1 = 1; int number2 = 0;
                    int number3 = 0;
                    for (int i = 1; i <= num; i++)
                    {
                        number1 *= i;
                        number2 += i;
                        if (i % 2 == 0)
                        {
                            number3 = i;
                        }
                    }
                    Console.WriteLine($"Факториал равен {number1}");
                    Console.WriteLine($"Сумма от 1 до N равна {number2}");
                    Console.WriteLine($"Максимальное четное число меньше N равно {number3}");
                }
            }
            catch
            {
                Console.WriteLine("Ошибка переполнения");
            }
        }

        public static void Compare(string value)
        {
            int number;
            
            bool isNum = int.TryParse(value, out number);
            
            if (isNum == true)
            {
                Calculation(number);
            }
            else
            {
                Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
                EnterNumber();
            }
        }

    }
}
