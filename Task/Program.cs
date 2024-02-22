// Задача: Написать программу, которая из имеющегося массива строк формирует
// новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

using System;
class Program
{
    static void Main()
    {
        int size1 = 4;
        string[] array1 = new string[size1];
        int j = 0;
        while(j < size1)
        {
            Console.WriteLine("Введите элемент массива (любые символы): "); 
            string input = Console.ReadLine()!;
            array1[j] = input;
            j++;
        }
        Console.WriteLine("Ваш массив: ");

        for(int i = 0; i < array1.Length; i++)
        {
            Console.Write($"[{array1[i]}] ");
        }




    }
}
