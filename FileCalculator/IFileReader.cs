using System;
using System.Collections.Generic;
using System.Text;

namespace FileCalculator
{
    public interface IFileReader
    {
        public void Open(string path);
        public void Close();
        public string ReadLine();
        public int GetRowsCount();
    }
}
