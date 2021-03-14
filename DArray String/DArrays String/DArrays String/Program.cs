using System;
using System.Linq;

// Jugged arrays
namespace DArrays_String
{
    class Program
    {
        static int[][] CreateJugged(params int[] cols)
        {
            int[][] m = new int[cols.Length][];

            for (int i = 0; i < m.Length; i++)
            {
                m[i] = new int[cols[i]];
            }

            return m;
        }

        static void FillRand(int[][] matrix, int left, int right)
        {
            Random rand = new Random();

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    matrix[i][j] = rand.Next(left, right + 1);
                }
            }
        }

        static void PrintJugged(int[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write($"{matrix[i][j], 10}\t");
                }
                Console.WriteLine();
            }
        }

        static void Up(ref int[][] matrix, int countOfRows, int countOfNumsInARow)
        {
            int[][] tmp = new int[matrix.Length + countOfRows][];

            for (int i = 0; i < countOfRows; i++)
            {
                tmp[i] = new int[countOfNumsInARow];
            }
            int k = 0;
            for (int i = countOfRows; i < tmp.Length; i++)
            {
                tmp[i] = matrix[k];
                ++k;
            }

            Array.Resize(ref matrix, matrix.Length + countOfRows);
            for (int i = 0; i < matrix.Length; i++)
            {
                    matrix[i] = tmp[i];
            }
        }

        static void Down(ref int[][] matrix, int countOfRows, int countOfNumsInARow)
        {
            Array.Resize(ref matrix, matrix.Length + countOfRows);
            for (int i = matrix.Length - countOfRows; i < matrix.Length; i++)
            {
                matrix[i] = new int[countOfNumsInARow];
            }
        }

        static void AddElement(int[][] matrix, int value)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                Array.Resize(ref matrix[i], matrix[i].Length + 1);
            }

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i][matrix.Length] = value;
            }
        }

        static void Remove(ref int[][] matrix, int index)
        {
            int[][] tmp = new int[matrix.Length - 1][];

            int j = 0;
            for (int i = 0; i < matrix.Length; i++)
            {
                if (i == index)
                {
                    continue;
                }
                else
                {
                    tmp[j] = matrix[i];
                    j++;
                }
            }

            Array.Resize(ref matrix, matrix.Length - 1);
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = tmp[i];
            }
        }
        static void Main()
        {
            int[][] matrix = CreateJugged(5, 5, 5, 5, 5);
            FillRand(matrix, 1, 100);

            PrintJugged(matrix);
            Console.WriteLine();
            // Remove(ref matrix, 1);
            // AddElement(matrix, 1);
            Down(ref matrix, 5, 5);
            PrintJugged(matrix);


        }
    }
}
