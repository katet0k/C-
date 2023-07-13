using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public class FootballPlayer
    {
        public string Name { get; set; }
        public int Number { get; set; }

        public FootballPlayer(string name, int number)
        {
            Name = name;
            Number = number;
        }
    }

    public class FootballTeam : IEnumerable<FootballPlayer>
    {
        private List<FootballPlayer> players;

        public FootballTeam()
        {
            players = new List<FootballPlayer>();
        }

        public void AddPlayer(string name, int number)
        {
            players.Add(new FootballPlayer(name, number));
        }

        public IEnumerator<FootballPlayer> GetEnumerator()
        {
            return players.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
