using System;

namespace DynamicMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicMatrix dynamicMatrix = new DynamicMatrix(5, 5);
            dynamicMatrix.FillRand(1, 10);
            dynamicMatrix.Write("text.dat");
            var tmp = dynamicMatrix.Read("text.dat");
            for (int i = 0; i < tmp.Length; i++)
            {
                for (int j = 0; j < tmp[i].Length; j++)
                {
                    Console.Write($"{tmp[i][j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
