using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class enemigo
    {
        public int posX { get; set; }
        public int posY { get; set; }
        public bool dis { get; set; }
        public bool exp { get; set; }

        private int _pun;
        public int pun
        {
            get
            {
                return _pun;
            }

            set
            {
                if (value < 100)
                {
                    _pun = value;
                }
                else
                {
                    throw new Exception("Este numero no puede ser menor a 100");
                }
            }
        }

        public movimiento()
        {

        }

        public disparo()
        {

        }

        public explotar()
        {

        }
    }
}
