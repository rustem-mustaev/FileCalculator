using System;

namespace FileCalculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            IFileReader reader = new FileReader("test.txt");

            for(int i=0;i< reader.GetRowsCount(); i++)
            {
                Console.WriteLine(reader.ReadLine());
            }

            Console.WriteLine("\n\n");

            reader = new FileReader("default");
            for (int i = 0; i < reader.GetRowsCount(); i++)
            {
                Console.WriteLine(reader.ReadLine());
            }
        }
    }
}
