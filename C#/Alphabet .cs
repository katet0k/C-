using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public class Alphabet : IEnumerable<char>
    {
        private List<char> letters;

        public Alphabet()
        {
            letters = new List<char>();
            InitializeAlphabet();
        }

        private void InitializeAlphabet()
        {
            for (char letter = 'A'; letter <= 'Z'; letter++)
            {
                letters.Add(letter);
            }
        }

        public IEnumerator<char> GetEnumerator()
        {
            return letters.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
