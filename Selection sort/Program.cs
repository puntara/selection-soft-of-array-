using System;

namespace Selection_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 17, 8, 99, 2, 5, 6 };
            selectionSort(nums);
            Print(nums);
        }
        static void selectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length-1; i++)
            {
                int hand = i; //find smallest element in arr.
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[hand])
                    {
                        hand = j;
                    }
                }
                int temp = arr[hand];//swap arr[hand] with arr[0]
                arr[hand] = arr[i];
                arr[i] = temp;
            }
        }
        static void Print(int[] arr)
        {
            foreach(int value in arr)
            {
                Console.Write(value+ " ");
            }
            Console.WriteLine();
        }
    }
}
