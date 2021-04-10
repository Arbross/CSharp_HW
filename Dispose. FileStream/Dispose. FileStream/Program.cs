using System;

namespace Dispose._FileStream
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileWorker fileWorker = new FileWorker("test.txt", FileWorker.Mode.ReadWrite))
            {
                fileWorker.Write("Hello world!\nProgramming the best!\n:)");
                fileWorker.Read();
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            FileWorker nFileWorker = new FileWorker("test1.txt", FileWorker.Mode.ReadWrite);
            nFileWorker.Write("Hello world!\nProgramming the best!\n:)");
            nFileWorker.Read();
            nFileWorker.Dispose();
        }
    }
}
