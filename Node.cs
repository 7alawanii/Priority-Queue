using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priority_Queue
{
    public class Node
    {
        public int priority;
        public int value;
        public int order;
        public Node(int v, int p, int o)
        {
            this.value = v;
            this.priority = p;
            this.order = o;
        }
    }
}
