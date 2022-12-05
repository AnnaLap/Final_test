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

string[] ChooseLessN(string[] enter, int n)
{
    string[] exit = new string[GetLengthArray(enter, n)];

    for (int i = 0, j = 0; i < enter.Length; i++)
    {
        if (enter[i].Length <= n)
        {
            exit[j] = enter[i];
            j++;
        }
    }
    return exit;
}

string[] array = EnterArray();
string[] result = ChooseLessN(array, 3);
WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", result)}]");
