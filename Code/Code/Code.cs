using System;

 public class Program
{
    public static void BubbleSort(int[] array)
    {
        if (array == null) {
            Console.WriteLine("Массив пуст")
        }
        int n = array.Length;
        for (int i = 0; i < n - 1; i++) {
            for (int j = 0; j < n - i - 1; j++) 
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        } 
    }

    public static void Main(String[] array)
    {
        int[] myArray = { 54, 3, 22, 34, 65, 77, 5 };
        BubbleSort(myArray);
        Console.WriteLine(String.Join(", ", myArray));
    }
}
