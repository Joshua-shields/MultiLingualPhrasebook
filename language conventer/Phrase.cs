using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace language_conventer
{
    public class Phrase
    {
        public string English { get; set; }
        public Dictionary<string, string> Translations { get; set; }

        public Phrase()
        {
            Translations = new Dictionary<string, string>();
        }
    }
}
