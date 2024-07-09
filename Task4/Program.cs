// Напишите программу, которая на вход принимает натуральное число N, 
// а на выходе показывает его цифры через запятую.

void Main()
    {
        try
        {
            Console.Write("Введите натуральное число: ");
            int number = int.Parse(Console.ReadLine());

            if (number <= 0)
            {
                Console.WriteLine("Пожалуйста, введите натуральное число (больше нуля).");
            }
            else
            {
                string result = GetDigitsSeparatedByComma(number);
                Console.WriteLine($"Цифры числа {number} через запятую: {result}");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Пожалуйста, введите корректное натуральное число.");
        }
    }

    static string GetDigitsSeparatedByComma(int number)
    {
        char[] digits = number.ToString().ToCharArray();
        return string.Join(", ", digits);
    }
Main();
