using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarvationPlayings
{
    class KillingEvent: Event
    {
        private short sanityChange;
        private short conditionChange;
        private short deadPlayerNumber;

        public KillingEvent(short playerNumber, string message, Player[] playerList, short sanityChange, short conditionChange, short deadPlayerNumber) : base(playerNumber, message, playerList)
        { 
            this.sanityChange = sanityChange;
            this.conditionChange = conditionChange;
            this.deadPlayerNumber = deadPlayerNumber;
        }

        public short SanityChange { get => sanityChange; set => sanityChange = value; }
        public short ConditionChange { get => conditionChange; set => conditionChange = value; }
        public short DeadPlayerNumber { get => deadPlayerNumber; set => deadPlayerNumber = value; }

        public override void StartEvent()
        {
            throw new NotImplementedException();
        }
    }
}
