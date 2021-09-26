using System;

namespace Program
{
    public static class Interacciones
    {
        //esta clase se responsabiliza de manejar los diferentes tipos de interacciones a nivel matematico, ya que puede facilmente acceder a los datos de los
        //personajes implicados y realizar las operaciones y controles necesarios. Es aplicación de EXPERT y SRP, al delegar la impresión a ConsoleLogger
        public static void Ataque(IPersonaje atacante, IPersonaje atacado)
        {
            atacado.HP -= atacante.Ataque - atacado.Defensa;
            if(atacado.HP < 0)
            {
                atacado.HP = 0;
            }

            //se le envía los datos de los personajes implicados en ataque para que se imprima en pantalla
            ConsoleLogger.ImprimirAtaque(atacante, atacado);
        }
        public static void LanzamientoHechizo(Mago lanzador, Hechizo hechizo, IPersonaje objetivo)
        {
            if(hechizo.TipoEfecto == "Daño" && lanzador.LibroEquipado.Contains(hechizo))
            {
                objetivo.HP -= hechizo.Poder;
                if(objetivo.HP < 0)
                {
                    objetivo.HP = 0;
                }

                //se le envía los datos de los personajes implicados lanzamiento de hechizo de ataque para que se imprima en pantalla
                ConsoleLogger.ImprimirLanzamientoHechizo(lanzador, hechizo, objetivo);
            }
            if(hechizo.TipoEfecto == "Curación" && lanzador.LibroEquipado.Contains(hechizo))
            {
                objetivo.HP += hechizo.Poder;
                if(objetivo.HP > IPersonaje.K_maxHP)
                {
                    objetivo.HP = IPersonaje.K_maxHP;
                }


                //se le envía los datos de los personajes implicados lanzamiento de hechizo de curación para que se imprima en pantalla
                ConsoleLogger.ImprimirLanzamientoHechizo(lanzador, hechizo, objetivo);
            }
        }
    }
}