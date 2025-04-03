using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograClase1
{
    public abstract class Character
    {
        public string Nombre { get; set; }
        public int Salud;
        public Character(string nombre, int salud)
        {
            Nombre = nombre;
            Salud = salud;
        }
        public abstract void MostrarMensaje();
    }
}
