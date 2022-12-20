/*Задача 50. Напишите программу, которая на вход принимает 
позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет*/


//1,функция ввода числа
//2.функция задачи рандомного массива
//3.функция печати массива
//4.функция замены элементов

// функция ввода числа 
int GetNumber(string text)
{
    int result = 0;
    Console.WriteLine(text);
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
    }
    return result;
}

// функция задачи рандомного массива 
int[,] GetArray(int m, int n)
{
    int[,] array = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(-10, 10);
        }
    }
    return array;
}

// функция печати массива 
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

// функция поиска элемента
int GetEnterNumber(int[,] array, int b)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)

            if (b == array[i, j])
            {
                Console.WriteLine($"Число {b} находится на строке {i + 1} и столбце {j + 1}");
            }
    }
    return b;
}

int b;
Console.WriteLine("Введите число искомое число:");
b = int.Parse(Console.ReadLine());


int m = GetNumber("Введите m");
int n = GetNumber("Введите n");

int[,] array = GetArray(m, n);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
GetEnterNumber(array, b);
