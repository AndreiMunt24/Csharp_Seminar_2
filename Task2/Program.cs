// Задача 2: Напишите программу, которая принимает на вход 
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной 
// четверти плоскости, в которой находится эта точка

void Main()
    {
        try
        {
            Console.Write("Введите координату X (≠ 0): ");
            double x = double.Parse(Console.ReadLine());
            
            Console.Write("Введите координату Y (≠ 0): ");
            double y = double.Parse(Console.ReadLine());

            if (x == 0 || y == 0)
            {
                Console.WriteLine("Координаты X и Y не должны быть равны нулю.");
            }
            else
            {
                int quadrant = DetermineQuadrant(x, y);
                Console.WriteLine($"Точка ({x}, {y}) находится в {quadrant}-й четверти.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Пожалуйста, введите корректное число.");
        }
    }

    static int DetermineQuadrant(double x, double y)
    {
        if (x > 0 && y > 0)
        {
            return 1;
        }
        else if (x < 0 && y > 0)
        {
            return 2;
        }
        else if (x < 0 && y < 0)
        {
            return 3;
        }
        else // x > 0 && y < 0
        {
            return 4;
        }
    }
Main();
