
// Задача 1: Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.

void Main()
    {
        try
        {
            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());

            if (IsDivisibleBy7And23(number))
            {
                Console.WriteLine($"Число {number} кратно одновременно 7 и 23.");
            }
            else
            {
                Console.WriteLine($"Число {number} не кратно одновременно 7 и 23.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Пожалуйста, введите корректное целое число.");
        }
    }

    static bool IsDivisibleBy7And23(int number)
    {
        return number % 7 == 0 && number % 23 == 0;
    }
Main();
