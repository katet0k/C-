using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public class CafeWorker
    {
        public string Name { get; set; }
        public string Position { get; set; }

        public CafeWorker(string name, string position)
        {
            Name = name;
            Position = position;
        }
    }

    public class Cafe : IEnumerable<CafeWorker>
    {
        private List<CafeWorker> workers;

        public Cafe()
        {
            workers = new List<CafeWorker>();
        }

        public void AddWorker(string name, string position)
        {
            workers.Add(new CafeWorker(name, position));
        }

        public IEnumerator<CafeWorker> GetEnumerator()
        {
            return workers.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
