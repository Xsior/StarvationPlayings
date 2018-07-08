using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarvationPlayings
{
    class Food: Item
    {
        private short conditionChange;
        private short hungerChange;
        private short sanityChange;

        public short ConditionChange { get => conditionChange; set => conditionChange = value; }
        public short HungerChange { get => hungerChange; set => hungerChange = value; }
        public short SanityChange { get => sanityChange; set => sanityChange = value; }
    }
}
