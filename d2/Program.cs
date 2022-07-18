/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
 k1 = 5, b1 = 2 
 k2 = 9, b2 = 4  -> (-0,5; -0,5)
*/
double[,] coefficients = new double[2, 2];
double[] crossPoint = new double[2];

void GetCoefficients()
{
    for (int i = 0; i < coefficients.GetLength(0); i++)
    {
        Console.Write($"Введите коэффициенты {i + 1}-го уравнения (y = k * x + b):\n");
        for (int j = 0; j < coefficients.GetLength(1); j++)
        {
            if (j == 0) Console.Write($"Введите коэффициент k: ");
            else Console.Write($"Введите коэффициент b: ");
            coefficients[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
}

double[] Decision(double[,] coefficients)
{
    crossPoint[0] = (coefficients[1, 1] - coefficients[0, 1]) / (coefficients[0, 0] - coefficients[1, 0]);
    crossPoint[1] = crossPoint[0] * coefficients[0, 0] + coefficients[0, 1];
    return crossPoint;
}

void OutputResponse(double[,] coefficients)
{
    if (coefficients[0, 0] == coefficients[1, 0] && coefficients[0, 1] == coefficients[1, 1])
    {
        Console.Write($"Прямые совпадают");
    }
    else if (coefficients[0, 0] == coefficients[1, 0] && coefficients[0, 1] != coefficients[1, 1])
    {
        Console.Write($"Прямые параллельны");
    }
    else
    {
        Decision(coefficients);
        Console.Write($"Точка пересечения прямых: ({crossPoint[0]}, {crossPoint[1]})");
    }
}

GetCoefficients();
OutputResponse(coefficients);
Console.WriteLine();