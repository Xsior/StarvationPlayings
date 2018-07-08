using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarvationPlayings
{
    abstract class Character
    {
        protected bool dead;
        protected string name;

        public bool Dead { get => dead; set => dead = value; }
        public string Name { get => name; set => name = value; }
    }
}
