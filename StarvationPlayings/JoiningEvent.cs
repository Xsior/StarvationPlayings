using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarvationPlayings
{
    class JoiningEvent : Event
    {
        private short joiningPlayer; 
        public JoiningEvent(short playerNumber, string message, Player[] playerList, short joiningPlayer) : base(playerNumber, message, playerList)
        {
            this.joiningPlayer = joiningPlayer;
        }

        public short JoiningPlayer { get => joiningPlayer; set => joiningPlayer = value; }

        public override void StartEvent()
        {
            
        }
    }
}
