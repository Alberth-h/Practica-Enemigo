using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Enemigo
    {
        public int X { get; set; }
        public int Y { get; set; }
        private int _pun;
        public int Pun
        {
            get
            {
                return _pun;
            }
            set
            {
                if(value >= 100)
                {
                    _pun = value;
                }
                else
                {
                    throw new Exception("El valor tiene que ser mayor a 100");
                }
            }
        }
        public void mover()
        {

        }
        public void disparar()
        {

        }
        public void explotar()
        {

        }
    }
}
