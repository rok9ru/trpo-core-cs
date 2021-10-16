using System;
using System.Collections.Generic;
using System.Text;

namespace Lab.Core
{
    public abstract class LogAbstract
    {
        protected string FormatLog(string[] strings)
        {
            return string.Join(";\n\r", strings);
        }

        protected void WriteConsole(string s)
        {
            Console.WriteLine(s);
        }

        protected void WriteConsole(string[] s)
        {
            Console.WriteLine(FormatLog(s));
        }
    }
}
