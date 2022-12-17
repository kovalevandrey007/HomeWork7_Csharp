/*Задача 50. Напишите программу, которая на вход принимает 
позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет*/

/*Задача 49: Задайте двумерный массив. 
Найдите элементы, у которых оба индекса чётные, 
и замените эти элементы на их квадраты. 

Например, изначально массив
выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4 

Новый массив будет выглядеть 
вот так:
1 4 7 2
5 81 2 9
8 4 2 4 */

//1,функция ввода числа
//2.функция задачи рандомного массива
//3.функция печати массива
//4.функция замены элементов

// функция ввода числа z
int GetF (string message);
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

// функция задачи рандомного массива 

int[,] GetArray(int m, int n) 
{ 
int [,] array = new int [m, n]; 
Random rnd = new Random(); 
for (int i = 0; i < array.GetLength(0); i++) 
{ 
for (int j = 0; j < array.GetLength(1); j++) 
{ 
array[i, j] = rnd.Next(-99, 99); 
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
Console.Write($"{array[i,j]} "); 
} 
Console.WriteLine(); 
} 
} 

// функция замены элементов 

int GetEnterNumber( int[,] array) 
{ 
    int num = a;
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        for (int j = 0; j < array.GetLength(1); j++) 
            { 
                if (num==array[i,j])
                    { 
                            num = array[i,j]; 
                            
                    } 
            } 
    } 
    return num;
} 


int m = GetNumber("Введите m"); 
int n = GetNumber("Введите n"); 
int a = GetF("Ввведите искомое число");
int [,] array = GetArray(m, n);    
GetEnterNumber(array); 
Console.WriteLine(); 
PrintArray(array); 
