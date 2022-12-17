/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

/*Задача 51: Задайте двумерный массив. Найдите сумму 
элементов, находящихся на главной диагонали 
(с индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12 */


//1. функция ввода числа
//2. функция задачи рандомного массива
//3. функция печати массива
//4.  функция ождения суммы элементов на главной диагонали


//1. функция ввода числа
int GetNumber(string text) 
{ 
    int result = 0; 
    Console.WriteLine(text); 
    while(true) 
    { 
        if (int.TryParse(Console.ReadLine(), out result)) 
       { 
        break; 
        } 
    } 
    return result; 
} 

//функция задачи рандомного 
int[,]GetMatrix(int m, int n) 
{ 
    int [,] matrix = new int [m, n]; 
    Random rnd = new Random(); 
    for (int i = 0; i < matrix.GetLength(0); i++) 
    { 
        for (int j = 0; j < matrix.GetLength(1); j++) 
            { 
                matrix[i, j] = rnd.Next(0,3); 
            } 
    } 
    return matrix; 
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
//4.  функция нахождения суммы элементов на главной диагонали
int OneArr (int n)
{
    int[] massiv = new int[n];
    //int sum = 0;
    int mas = 0;
    for (int j =0; j< n; j++ )
        {
            if(j==0)
            mas  = massiv[j];
            j++;
        }
    return mas;
}


//Вызываем функции
int numer=  GetNumber("введите количество строк: ");
int nor =  GetNumber("введите количество столбцов: ");
int [,] tort = GetMatrix(numer,  nor);
PrintMatrix(tort);
int[] massiv = OneArr(mas); 
//int popil = FindSum (tort);
Console.WriteLine($"Cумма элементов, находящихся в столбцах = {popil}");
 