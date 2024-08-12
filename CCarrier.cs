using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConveyorCs
{
    internal class CCarrier
    {
        public UInt64 id;
        public UInt64 source;
        public UInt64 dest;
        public USE use;

        public enum USE
        {
            USE_NONE,
            USE_TAKEOUT,
            USE_STACK
        }
        public void Clear()
        {
            id = 0;
            source = 0;
            dest = 0;
            use = USE.USE_NONE;
        }
    }
}
