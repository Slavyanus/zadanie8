// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


    using System;
     
    namespace ConsoleApp1
    {
        class Program
        {
            static void Main(string[] args)
            {
                int[,] array = new int[3, 3] { { 6, 2, 1 }, { 5, 4, 3 }, { 9, 8, 7 } };
     
                Output(array);
     
                Console.WriteLine();
     
                Sort(array);
     
                Output(array);                       
     
                Console.ReadKey();
            }
     
            static void Sort(int[,] arr)
            {
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        for (int x = 0; x < arr.GetLength(0); x++)
                        {
                            for (int y = 0; y < arr.GetLength(1); y++)
                            {
                                if (arr[i, j] > arr[x, y])
                                    Swap(arr, i, j, x, y);
                            }
                        }
                    }                
                }
            }       
            static void Swap(int[,] arr, int i, int j, int x, int y)
            {
                int temp = arr[i, j];
                arr[i, j] = arr[x, y];
                arr[x, y] = temp;
            }
     
            static void Output(int[,] arr)
            {
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                        Console.Write(arr[i, j] + " ");
                    Console.Write(Environment.NewLine);
                }
            }
        }
    }