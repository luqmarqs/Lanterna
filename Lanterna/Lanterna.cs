using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanterna
{
    internal class Lanterna
    {
        public bool Status { get; set; } //false = desligado, true = ligado
        public Bateria Bateria { get; set; }

        public Lanterna()
        {
            Bateria = new Bateria();
            Status = false;
        }

        public void ligaDesliga()
        {
            if(Status)
                Status = false;
            else
                Status = true;
        }

        public void trocaBateria()
        {
            Bateria = new Bateria();
        }

    }
}
