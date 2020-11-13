using System;
using System.Collections.Generic;
using System.Text;

namespace FileCalculator
{
    class ExpressionsHandler
    {
        private Dictionary<char, int> variables;

        public ExpressionsHandler()
        {
            variables = new Dictionary<char, int>();
        }

        public ExpressionsHandler(string[] buffer)
        {
            // обработать строки
        }

        public int GetResult(string expression)
        {
            // calculate
            throw new NotImplementedException();
        }


    }
}
