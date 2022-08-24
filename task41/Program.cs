// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

while (true)
{
    int[] CreateArray(int number)
    {
        int[] numArray = new int[number];
        for (int i = 0; i < number; i++)
        {
            numArray[i] = Convert.ToInt32(Console.ReadLine());
        }
        return numArray;
    }

    void PrintArray(int[] arr)
    {
        int length = arr.Length;
        Console.Write("[");
        for (int i = 0; i < length - 1; i++)
        {
            Console.Write(arr[i] + ", ");
        }
        Console.WriteLine(arr[length - 1] + "]");
    }

    int CountPositiveNum(int[] array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
                count++;
        }
        return count;
    }
    Console.WriteLine("Введите количество элементов в массиве");
    int M = Convert.ToInt32(Console.ReadLine());
    int[] array = CreateArray(M);
    PrintArray(array);
    Console.WriteLine($"Количество введенных положительных чисел равно {CountPositiveNum(array)}.");
    Console.WriteLine("Для завершения введите end, для продолжения - любой символ");
    string a = Console.ReadLine();
    if (a == "end")
    {
        break;
    }
}
