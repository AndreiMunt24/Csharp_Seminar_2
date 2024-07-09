// задача 3: Напишите программу, которая принимает на вход 
// целое число из отрезка [10, 99]
//  и показывает наибольшую цифру числа.

void Main()
    {
        try
        {
            Console.Write("Введите целое число от 10 до 99: ");
            int number = int.Parse(Console.ReadLine());

            if (number < 10 || number > 99)
            {
                Console.WriteLine("Число должно быть в диапазоне от 10 до 99.");
            }
            else
            {
                int largestDigit = GetLargestDigit(number);
                Console.WriteLine($"Наибольшая цифра числа {number} - это {largestDigit}.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Пожалуйста, введите корректное целое число.");
        }
    }

    static int GetLargestDigit(int number)
    {
        int tens = number / 10; // Делим число на 10, чтобы получить десятки
        int ones = number % 10; // Получаем остаток от деления на 10, чтобы получить единицы

        return (tens > ones) ? tens : ones; // Сравниваем и возвращаем большую цифру
    }
Main();

