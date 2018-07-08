using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarvationPlayings
{
    abstract class Item
    {
        protected string name;

        public string Name { get => name; set => name = value; }
    }
}
