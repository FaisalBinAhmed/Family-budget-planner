using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget_tracking
{
    class Data
    {
        public int gid;
        public Data() { gid = 0; }
        public void setGID(int a) { gid = a; }
        public int getGID() { return gid; }

    }
    struct ID {
        public int gid;
    }
}
