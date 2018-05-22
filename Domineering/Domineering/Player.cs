using System.Collections.Generic;
using System.Windows;

namespace Domineering
{
    public class Player
    {
        public string Name { get; set; }
        public bool IsWonned { get; set; }
        public List<Point> Moves { get; set; }

        public Player(string name)
        {
            Name = name;
        }
    }
}