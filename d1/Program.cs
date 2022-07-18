/*
Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

Console.Write($"Введи сколько чисел вы планируете ввести количество чисел: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] userNumbers = new int[number];

void GetNumbers(int number)
{
    for (int i = 0; i < number; i++)
    {
        Console.Write($"Введи {i + 1} число: ");
        userNumbers[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int Comparison(int[] userNumbers)
{
    int count = 0;
    for (int i = 0; i < userNumbers.Length; i++)
    {
        if (userNumbers[i] > 0) count += 1;
    }
    return count;
}

GetNumbers(number);

Console.WriteLine($"Введено чисел > 0: {Comparison(userNumbers)} ");
