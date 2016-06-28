namespace Executor
{
    using System;
    using System.Collections.Generic;

    public  class OutputWriter
    {
        public  void WriteMessage(string message)
        {
            Console.Write(message);
        }

        public  void WriteMessageOnNewLine(string message)
        {
            Console.WriteLine(message);
        }

        public  void WriteEmptyLine()
        {
            Console.WriteLine();
        }

        public  void DisplayException(string message)
        {
            ConsoleColor currentColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = currentColor;
        }

        public  void PrintStudent(KeyValuePair<string, List<int>> student)
        {
            OutputWriter.WriteMessageOnNewLine(string.Format($"{student.Key} - {string.Join(", ", student.Value)}"));
        }
    }
}
