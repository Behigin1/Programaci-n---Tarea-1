using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograClase1
{
    public class Player : Character
    {
        public Player(string nombre) : base(nombre, 100)
        {
        }

        public override void MostrarMensaje()
        {
            Console.WriteLine("Eres un aventurero valiente en busca de un tesoro.");
        }
    }
}
