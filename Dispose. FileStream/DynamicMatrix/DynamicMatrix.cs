using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace DynamicMatrix
{
    class DynamicMatrix
    {
        public byte[][] juggedArray;
        public DynamicMatrix(params byte[] cols)
        {
            juggedArray = new byte[cols.Length][];
            checked
            {
                for (int i = 0; i < juggedArray.Length; i++)
                {
                    juggedArray[i] = new byte[cols[i]];
                }
            }
        }
        public void FillRand(byte first, byte second)
        {
            Random rand = new Random();
            for (int i = 0; i < juggedArray.Length; i++)
            {
                for (int j = 0; j < juggedArray[i].Length; j++)
                {
                    juggedArray[i][j] = (byte)rand.Next(first, second + 1);
                    Console.Write($"{juggedArray[i][j], -3}");
                }
                Console.WriteLine();
            }
        }
        public void Write(string fname)
        {
            using (FileStream fs = new FileStream(fname, FileMode.Create))
            {
                foreach (var row in juggedArray)
                {
                    byte[] len = BitConverter.GetBytes(row.Length);
                    fs.Write(len);
                    fs.Write(row);
                }
            }
        }
        public byte[][] Read(string fname)
        {
            byte[][] array = new byte[0][];
            using (FileStream fs = new FileStream(fname, FileMode.Open))
            {
                int countRead = 0, countItems = 0;
                var sizeRow = new byte[sizeof(int)];
                while (true)
                {
                    countRead = fs.Read(sizeRow);
                    if (countRead != sizeof(int))
                    {
                        break;
                    }
                    countItems = sizeRow.Length + 1;
                    byte[] data = new byte[countItems];
                    countRead = fs.Read(data, 0, countItems);
                    Array.Resize(ref array, array.Length + 1);
                    array[array.Length - 1] = data;
                }
            }
            return array;
        }
    }
}
