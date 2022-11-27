using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic_3_Generic
{
    public class Generic<T>
    {
        public List<T> List { get; }

        public Generic(List<T> list)
        {

            List = list;
        }
    }
}
