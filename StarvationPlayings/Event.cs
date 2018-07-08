using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StarvationPlayings
{
    abstract class Event
    {
        protected short playerNumber;
        protected string message;
        protected Player[] playerList;

        public Event(short playerNumber, string message, Player[] playerList)
        {
            this.playerNumber = playerNumber;
            this.message = message;
            this.playerList = playerList;
        }

        public short PlayerNumber { get => playerNumber; set => playerNumber = value; }

        public void ParseMessage()
        {
            string[] separated = message.Split();
            string finalMessage = "";
            short arrayIndex = 0;
            foreach(String s in separated)
            {
                if (Patterns.playerRegex.IsMatch(s))
                {
                    arrayIndex = Int16.Parse(Regex.Match(s, @"\d").Value);
                    finalMessage += playerList[arrayIndex].Name;
                } else if (Patterns.hisRegex.IsMatch(s))
                {
                    arrayIndex = Int16.Parse(Regex.Match(s, @"\d").Value);
                    if (playerList[arrayIndex].Gender == Enums.Gender.male)
                        finalMessage += "his";
                    else
                        finalMessage += "her";
                }
                else if (Patterns.selfRegex.IsMatch(s))
                {
                    arrayIndex = Int16.Parse(Regex.Match(s, @"\d").Value);
                    if (playerList[arrayIndex].Gender == Enums.Gender.male)
                        finalMessage += "himself";
                    else
                        finalMessage += "herself";
                }
            }

        }
        public abstract void StartEvent();

    }

}
