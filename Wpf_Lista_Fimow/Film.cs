using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_Lista_Fimow
{
    public class Film
    {
        public string Tytul { get; set; }
        public string Kategoria { get; set; }
        public int RokProdukcji { get; set; }

        public bool TylkoDlaDoroslych { get; set;  }

        public Film(string tytul, string kategoria, int rokProdukcji, bool tylkoDlaDoroslych)
        {
            Tytul = tytul;
            Kategoria = kategoria;
            RokProdukcji = rokProdukcji;
            TylkoDlaDoroslych = tylkoDlaDoroslych;
        }
    }
}
