using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public abstract class Game
    {
        //Fields
        public List<string> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }

        //Methods
        public abstract void Play();

        public virtual void ListPlayers()
        {
            foreach(string player in Players)
            {
                Console.WriteLine(player);
            }
        }
    }
}
