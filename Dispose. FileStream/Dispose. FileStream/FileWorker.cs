using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Dispose._FileStream
{
    class FileWorker : IDisposable
    {
        private string fname;
        private bool isOpen;
        private bool isDisposed = false;
        public FileWorker(string fileName, Mode mode)
        {
            FileName = fileName;
            this.mode = mode;
        }
        public FileWorker() : this("noname.txt", default(Mode)) { }
        public string FileName
        {
            get => fname;
            set => fname = value;
        }
        public enum Mode : byte { Read = 0, Write, ReadWrite }
        private Mode mode;
        public void Write(string text)
        {
            if (mode == Mode.Write || mode == Mode.ReadWrite)
            {
                File.WriteAllText(fname, text);
            }
            else
            {
                throw new InvalidOperationException("Invalid 'mode' like 'Read', 'Write', 'ReadWrite'.");
            }
        }
        public void Read()
        {
            if (mode == Mode.Read || mode == Mode.ReadWrite)
            {
                if (File.Exists(fname))
                {
                    Console.WriteLine(File.ReadAllText(fname));
                }
                else
                {
                    throw new FileLoadException("File load exception. It isn't exists in this repository.");
                }
            }
            else
            {
                throw new InvalidOperationException("Invalid 'mode' like 'Read', 'Write', 'ReadWrite'.");
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!isDisposed)
            {
                if (disposing)
                {
                    Console.WriteLine($"We are releasing managed resouce..");
                }

                isOpen = false;
                Console.WriteLine($"Dispose done. Is opened {isOpen}.");
                isDisposed = true;
            }
        }
        ~FileWorker()
        {
            Dispose(false);
        }
    }
}
