using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanterna
{
    internal class Bateria
    {
        public int Carga { get; set; }

        public Bateria()
        {
            Carga = 100;
        }

        public void atualizaCarga()
        {
            if(Carga > 0)
                Carga--;
        }
    }
}
