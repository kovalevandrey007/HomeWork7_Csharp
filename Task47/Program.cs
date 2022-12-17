﻿/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/


int GetNumber(string message)
{
int result = 0;

while(true)
{
Console.WriteLine(message);
if(int.TryParse(Console.ReadLine(), out result))
{
break;
}
else
{
Console.WriteLine("Ввели не число");
}
}

return result;
}

//задать матрицу и заполнить ее числами
double[,] GetMatrix(int m, int n)
{
double[,] matrix = new double[m,n];
Random rnd = new Random();

for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
matrix[i, j ] = rnd.Next(-10, 10) + rnd.NextDouble()*((0.003-0.001) + 0.001);
}
}

return matrix;
} 
//распечатать матрицу
void PrintMatrix(double[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
Console.Write($"{matrix[i, j]}\t ");
}
Console.WriteLine();
}
}

int  m = GetNumber("Введите количество строк:");
int  n = GetNumber("Введите количество столбцов");
double[,] matrix = GetMatrix(m,n);
PrintMatrix(matrix); 

