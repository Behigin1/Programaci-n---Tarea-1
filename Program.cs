using System;
using System.Collections.Generic;
using PrograClase1;

class Program
{
    static Dictionary<string, string> mapa = new Dictionary<string, string>()
    {
        {"izquierda", "Un túnel oscuro."},
        {"derecha", "Un pasaje iluminado."}
    };

    static string Decision(string pregunta, string[] opciones)
    {
        string respuesta;
        do
        {
            Console.WriteLine(pregunta);
            foreach (string opcion in opciones)
            {
                Console.WriteLine("- " + opcion);
            }
            Console.Write("Elige: ");
            respuesta = Console.ReadLine().ToLower();
        } while (!Array.Exists(opciones, opcion => opcion.ToLower() == respuesta));
        return respuesta;
    }

    static void Main()
    {
        Console.Write("Ingresa tu nombre: ");
        string nombre = Console.ReadLine();
        Player jugador = new Player(nombre);
        jugador.MostrarMensaje();

        List<string> inventario = new List<string>();

        Console.WriteLine("\nDecides explorar la cueva...");
        string eleccion1 = Decision("¿Vas a la izquierda o a la derecha?", new string[] { "izquierda", "derecha" });
        Console.WriteLine("Has elegido: " + mapa[eleccion1]);

        if (eleccion1 == "derecha")
        {
            Console.WriteLine("Encuentras una antorcha y la tomas.");
            inventario.Add("Antorcha");
        }
        else
        {
            Console.WriteLine("Tropezaste y perdiste 10 puntos de salud.");
            jugador.Salud -= 10;
        }

        string eleccion2 = Decision("Encuentras una puerta cerrada, ¿la abres o buscas otro camino?", new string[] { "abrir", "buscar" });
        switch (eleccion2)
        {
            case "abrir":
                Console.WriteLine("La puerta se abre y entras a una sala misteriosa.");
                break;
            case "buscar":
                Console.WriteLine("Encuentras un pasadizo secreto y lo sigues.");
                break;
        }

        int enemigos = 3;
        while (enemigos > 0)
        {
            Console.WriteLine("Un enemigo aparece! Decides huir.");
            enemigos--;
        }

        for (int i = 0; i < inventario.Count; i++)
        {
            Console.WriteLine("Tienes: " + inventario[i]);
        }

        Console.WriteLine("Llegaste al tesoro! Fin del juego.");
    }
}
