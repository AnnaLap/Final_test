/* Задача: Написать программу, которая из имеющегося массива строк формирует 
массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив 
можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении 
не рекомендуется пользоваться коллекциями, лучше обойтись
исключительно массивами.
Примеры:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
['1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> [] */
using System;
using static System.Console;

Clear();

string[] EnterArray()
{
    Console.Write("Введите значения через пробел: ");
    return ReadLine().Split(" ");
}

int GetLengthArray(string[] enter, int n)
{
    int count = 0;
    for (int i = 0; i < enter.Length; i++)
    {
        if (enter[i].Length <= n)
        {
            count++;
        }
    }
    return count;
}

string[] array = EnterArray();
int count = GetLengthArray(array, 3);
Console.Write(count);