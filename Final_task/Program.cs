// Задача Финальная: Написать программу, которая из массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.

int n = 9;
Console.WriteLine($"В заданном массиве всего {n} элементов");

string[] array = new string[n];
array[0] = "hello";
array[1] = "2";
array[2] = "world";
array[3] = ":-)";
array[4] = "1234";
array[5] = "1567";
array[6] = "Russia";
array[7] = "Denmark";
array[8] = "Kazan";

void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

Console.WriteLine($"Исходный массив: ");
ShowArray(array);

string[] NewArray(string[] array)
{
    int lengthOfNewArray = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) lengthOfNewArray++;
    }

    string[] newArray = new string[lengthOfNewArray];

    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[index] = array[i];
            index++;
        }
    }
    return newArray;

}

Console.WriteLine();
Console.WriteLine($"Полученный массив из строк, длина которых меньше либо равна 3 символа :");
ShowArray(NewArray(array));