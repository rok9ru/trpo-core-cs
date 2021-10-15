using System;
using System.Collections.Generic;
using System.Text;

namespace Lab.Core
{
    public interface LogInterface
    {
        LogInterface Log(string str);
        LogInterface Write();
    }
} 
