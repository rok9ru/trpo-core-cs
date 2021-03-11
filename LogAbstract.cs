using System;
using System.Collections.Generic;
using System.Text;

namespace Lab.core {
    public abstract class LogAbstract {

        public List<string> log = new List<string>();
        public abstract void _write();
        public abstract void _log(string str);
    }
}
