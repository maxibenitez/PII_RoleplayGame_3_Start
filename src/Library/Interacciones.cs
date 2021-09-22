using System;

namespace Program
{
    public static class Interacciones
    {
        //esta clase se responsabiliza de manejar los diferentes tipos de interacciones a nivel matematico, ya que puede facilmente acceder a los datos de los
        //personajes implicados y realizar las operaciones y controles necesarios. Es aplicación de EXPERT y SRP, al delegar la impresión a ConsoleLogger
        public static void Ataque(Personaje atacante, Personaje atacado)
        {
            atacado.HP -= atacante.Ataque - atacado.Defensa;

            //se le envía los datos de los personajes implicados en ataque para que se imprima en pantalla
            ConsoleLogger.ImprimirAtaque(atacante, atacado);
        }
        public static void LanzamientoHechizo(Personaje lanzador, Hechizo hechizo, Personaje objetivo)
        {
            if(hechizo.TipoEfecto == "Daño" && lanzador.LibroEquipado.HechizosGuardados.Contains(hechizo))
            {
                objetivo.HP -= hechizo.Poder;

                //se le envía los datos de los personajes implicados lanzamiento de hechizo de ataque para que se imprima en pantalla
                ConsoleLogger.ImprimirLanzamientoHechizo(lanzador, hechizo, objetivo);
            }
            if(hechizo.TipoEfecto == "Curación" && lanzador.LibroEquipado.HechizosGuardados.Contains(hechizo))
            {
                objetivo.HP += hechizo.Poder;

                //se le envía los datos de los personajes implicados lanzamiento de hechizo de curación para que se imprima en pantalla
                ConsoleLogger.ImprimirLanzamientoHechizo(lanzador, hechizo, objetivo);
            }
        }
    }
}