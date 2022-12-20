/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

// 1. функция ввода числа

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

// 2. функция задачи рандомного массива
int[,] GetArray(int a, int b)
{
    int[,] array = new int[a, b];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 11);
        }
    }
    return array;
}
//3. функция печати массива
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
// 4. функция нахождение среднего арифмитического в каждом столбце
/*
int FindSrAr(int[,] myarr, int a, int b);
{
    
    for (int i = 0; i < b; i++)
    {
            double sum = 0;
            for (int j = 0; j < a; j++)
            {
                sum += myarr[j, i];
            }
            double average = sum / myarr.GetLength(0)+1;
            int g = i + 1;
            Console.WriteLine($"Среднее арифмитическое для столбца {g} = {Math.Round(average, 2)}");
    }
        return sum;
 }
    */



int a = GetNumber("введите количество строк: ");
int b = GetNumber("введите количество столбцов: ");
int[,] myarr = GetArray(a, b);
PrintMatrix(myarr);

//не смог решить через метод myarr подчеркивается при тех же условиях
for (int i = 0; i < b; i++)
{
    double summ = 0;
    for (int j = 0; j < a; j++)
    {
        summ += myarr[j, i];
    }
    double average = summ / a;
    int g = i + 1;
    Console.WriteLine($"Среднее арифмитическое для столбца {g} = {Math.Round(average, 2)}");
}
