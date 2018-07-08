using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarvationPlayings
{
    class Player : Character
    {
        private short sanity;
        private short condition;
        private short hunger;
        private Enums.Gender gender;
        private List<Item> inventory = new List<Item>();

        public short Sanity { get => sanity; set => sanity = value; }
        public short Condition { get => condition; set => condition = value; }
        public short Hunger { get => hunger; set => hunger = value; }
        public Enums.Gender Gender { get => gender; set => gender = value; }

        public void AddItem(Item item)
        {
            inventory.Add(item);
        }

        public void RemoveItem(Item item)
        {
            inventory.Remove(item);
        }

    }
}
