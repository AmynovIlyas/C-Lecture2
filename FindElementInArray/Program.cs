﻿// Имеется одномерный массив array из n элементо, требуется найти элемент массива равный find
int[] array = { 21, 12, 34, 24, 15, 62, 17, 15, 28 };

int n = array.Length; // array.Length сообщает о количестве элементов в массиве
Console.Write("Введите число: ");
int find = int.Parse(Console.ReadLine()!);

int i = 0;
string check = "-";
while (i < n)
{
    if (array[i] == find)
    {
        check = "+";
        Console.WriteLine(i);
        break; // Данная команда нужна для того, чтобы вывести только индекс первого числа, равного значению find; безданной команды выводится будут ВСЕ индексы чисел в массиве, равные find;
    }
    i++;
}
if (check == "-") {Console.WriteLine("Ни один элемент массива не равен введённому Вами числу");}

// Можно и с помощью метода решить (вместо break там можно использовать return
// в невозвращаемой функции)

// FindIndex(array, find);

// void FindIndex(int[] arr, int find2)
// {
//     int i = 0;
//     while (i < arr.Length)
//     {
//         if (arr[i] == find2)
//         {
//             Console.WriteLine(i);
//             return; // Данная команда нужна для того, чтобы вывести только индекс первого числа, равного значению find; безданной команды выводится будут ВСЕ индексы чисел в массиве, равные find;
//         }
//         i++;
//     }
// }
