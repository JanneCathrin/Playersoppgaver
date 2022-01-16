using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playersoppgave
{
    class Player
    {
        public Random RandomGen;
        private string _name;
        private int _points;


        public Player(string name, int points)
        {
            RandomGen = new Random();
            _name = name;
            _points = points;

        }
        public void Play(Player player2)
        {
            var winner = RandomGen.Next(2) == 0 ? this : player2;
            var loser = winner == this ? player2 : this;
            winner._points += 1;
            loser._points -= 1;

        }

        public void ShowNameAndPoints()
        {
            Console.WriteLine($"name {_name}. {_points}");
        }
       
    }
}
