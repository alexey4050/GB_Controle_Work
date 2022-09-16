/* Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк,
длина которых меньше либо равна 3 символам. Первоначальный массив можно
ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Пример: ["hello", "2", "world", ":)"] -> ["2",":)"] */

Console.Clear();

string[] firstArray = new string[5] {"It", "rain", "outside", "every", "day"};
string[] secondArray = new string[firstArray.Length];

void FillArray(string[] firstArray, string[] secondArray)
{
    int count = 0;
    for(int i =0; i < firstArray.Length; i++)
    {
        if (firstArray[i].Length <= 3)
        {
            secondArray[count] = firstArray[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

FillArray(firstArray, secondArray);
PrintArray(secondArray);