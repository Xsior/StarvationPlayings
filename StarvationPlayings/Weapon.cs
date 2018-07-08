using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarvationPlayings
{
    class Weapon: Item
    {
        private short fightBoost;

        public short FightBoost { get => fightBoost; set => fightBoost = value; }
    }
}
