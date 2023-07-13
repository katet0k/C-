using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public class MarineCreature
    {
        public string Name { get; set; }
        public string Species { get; set; }

        public MarineCreature(string name, string species)
        {
            Name = name;
            Species = species;
        }
    }

    public class Oceanarium : IEnumerable<MarineCreature>
    {
        private List<MarineCreature> creatures;

        public Oceanarium()
        {
            creatures = new List<MarineCreature>();
        }

        public void AddCreature(string name, string species)
        {
            creatures.Add(new MarineCreature(name, species));
        }

        public IEnumerator<MarineCreature> GetEnumerator()
        {
            return creatures.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
