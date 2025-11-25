using System;

public class Program
{
    public static void Main(string[] args)
    {
        string stroka = Console.ReadLine()!;
        Console.WriteLine($"Исходная строка: {stroka}");
        var (result, OIndex) = Transform(stroka);
        Console.WriteLine($"Преобразованная строка: {result}");
        Console.WriteLine($"Индекс изначальной строки: {OIndex + 1}");
        string orig = Reversed(result, OIndex);
        Console.WriteLine($"Обратное преобразование: {orig}");
    }

    public static (string trans, int Index) Transform(string input)
    {
        int n = input.Length;
        string[] rotations = new string[n];
        for (int i = 0; i < n; i++)
        {
            rotations[i] = input.Substring(i) + input.Substring(0, i);
        }
        BubbleSort(rotations);
        char[] result = new char[n];
        int OIndex = -1;
        for (int i = 0; i < n; i++)
        {
            result[i] = rotations[i][n - 1];
            if (rotations[i] == input)
            {
                OIndex = i;
            }

        }
        return (new string(result), OIndex);
    }

    public static string Reversed(string trans, int OIndex)
    {
        int n = trans.Length;
        string[] reverse = new string[n];
        for (int step = 0; step < n; step++)
        {
            for (int i = 0; i < n; i++)
            {
                reverse[i] = trans[i] + reverse[i];
            }
            BubbleSort(reverse);
        }
        return reverse[OIndex];
    }

    public static void BubbleSort(string[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (string.Compare(array[j], array[j + 1]) > 0)
                {
                    string temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }
}
