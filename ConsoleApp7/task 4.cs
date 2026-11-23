using System;

namespace ConsoleApp7;

public class CommonElementsTask
{
    public static void Run()
    {
        Console.Write("Введите размер M первого массива: ");
        uint m;
        while (!UInt32.TryParse(Console.ReadLine(), out m) || m == 0)
        {
            Console.Write("Некорректный ввод. Введите целое положительное число: ");
        }

        Console.Write("Введите размер N второго массива: ");
        uint n;
        while (!UInt32.TryParse(Console.ReadLine(), out n) || n == 0)
        {
            Console.Write("Некорректный ввод. Введите целое положительное число: ");
        }

        int[] arr1 = new int[m];
        int[] arr2 = new int[n];

        FillArray(arr1, 1, 15);
        FillArray(arr2, 1, 15);

        Console.Write("Массив 1: ");
        ShowArray(arr1);

        Console.Write("Массив 2: ");
        ShowArray(arr2);

        int[] commonArr = GetCommonUniqueElements(arr1, arr2);

        Console.Write("Общие элементы без повторений: ");
        if (commonArr.Length > 0)
        {
            ShowArray(commonArr);
        }
        else
        {
            Console.WriteLine("общих элементов нет.");
        }
    }

    static void FillArray(int[] arr, int min, int max)
    {
        Random r = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = r.Next(min, max);
        }
    }

    static void ShowArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($"{arr[i]} ");
        }
        Console.WriteLine();
    }

    static int[] GetCommonUniqueElements(int[] arr1, int[] arr2)
    {
        int maxLen = arr1.Length < arr2.Length ? arr1.Length : arr2.Length;
        int[] temp = new int[maxLen];
        int count = 0;

        for (int i = 0; i < arr1.Length; i++)
        {
            if (Array.IndexOf(arr2, arr1[i]) != -1 && Array.IndexOf(temp, arr1[i], 0, count) == -1)
            {
                temp[count] = arr1[i];
                count++;
            }
        }

        int[] result = new int[count];
        for (int i = 0; i < count; i++)
        {
            result[i] = temp[i];
        }

        return result;
    }
}