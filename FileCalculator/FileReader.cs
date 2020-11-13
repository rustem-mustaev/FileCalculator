using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileCalculator
{
    class FileReader : IFileReader
    {
        private string _path;
        private List<string> buffer;
        private int _currentRow;

        public FileReader(string path)
        {
            if(path == "default")
            {
                SetDefaultSettings();
            }
            else
            {
                _path = path;
                buffer = new List<string>();
                _currentRow = 0;
                Open(_path);
            }
           
        }
        public void Open(string path)
        {
            try
            {
                using(StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        buffer.Add(line);
                    }   
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }

        public void Close()
        {
            _path = null;
            buffer = new List<string>();
            _currentRow = 0;
        }

        public string ReadLine()
        {
            try
            {
                string line = buffer[_currentRow];
                _currentRow++;
                return line;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public int GetRowsCount()
        {
            return buffer.Count;
        }

        private void SetDefaultSettings()
        {
            _path = "default";
            _currentRow = 0;
            buffer = new List<string>();
            buffer.Add("a = 5;");
            buffer.Add("b = 6;");
            buffer.Add("a + b * 2;");
        }
    }
}
