using System;
using System.Collections;
using System.Linq;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            popularCatalogoItems();

        //los personajes los ideaban cada integrante, Alonso solo escribió la implementación
            Elfo maxiChar = new Elfo("Legolas");
            agregarItemAlCatalogo("Arco élfico", "ARMA", 14, 0);
            agregarItemAlCatalogo("Cota de Malla élfica", "ARMADURA", 0, 8);
            maxiChar.AddItem(GetItem("Arco élfico"));
            maxiChar.AddItem(GetItem("Cota de Malla élfica"));

            Mago danaChar = new Mago("Danurris");
            agregarItemAlCatalogo("El principito", "LIBRO", 0, 0);
                Hechizo magiaDana = new Hechizo("Desconocerse", "Daño", 69);
                Libro danaBook = GetItem("El principito") as Libro;
                danaBook.AñadirHechizo(magiaDana);
            danaChar.AddItem(GetItem("Armadura de Acero"));
            danaChar.AddItem(GetItem("El principito"));
            
            Mago marceChar = new Mago("Isandril");
            agregarItemAlCatalogo("Arcaneum", "LIBRO", 0, 0);
                Hechizo magiaMarce2 = new Hechizo("Rejuvenecer", "Curación", 50);
                Hechizo magiaMarce = new Hechizo("Tormenta de Arena", "Daño", 45);
                Libro marceBook = GetItem("Arcaneum") as Libro;
                marceBook.AñadirHechizo(magiaMarce);
                marceBook.AñadirHechizo(magiaMarce2);
            agregarItemAlCatalogo("Toga de Fuego", "ARMADURA", 0, 12);
            marceChar.AddItem(GetItem("Toga de Fuego"));
            marceChar.AddItem(GetItem("Arcaneum"));

            Enano alonsoChar = new Enano("Torbjorn");
            agregarItemAlCatalogo("Mjollnir", "ARMA", 85, 0);
            agregarItemAlCatalogo("Cota de Konan", "ARMADURA", 0, 15);
            alonsoChar.AddItem(GetItem("Mjollnir"));
            alonsoChar.AddItem(GetItem("Cota de Konan"));

        //Metodos de ver ataque y defensa
            ConsoleLogger.VerAtaqueYDefensa(danaChar);
            ConsoleLogger.VerAtaqueYDefensa(maxiChar);
            ConsoleLogger.VerAtaqueYDefensa(marceChar);
            ConsoleLogger.VerAtaqueYDefensa(alonsoChar);

        //interacciones entre los personajes

            Interacciones.LanzamientoHechizo(danaChar, magiaDana, maxiChar);
            Interacciones.LanzamientoHechizo(marceChar, magiaMarce2, maxiChar);
            Interacciones.Ataque(alonsoChar, maxiChar);
        }

        private static ArrayList catalogoItems = new ArrayList(); 
        //por si alguno le falta inspiracion, una serie de objetos genericos

        private static void popularCatalogoItems()
        {
            agregarItemAlCatalogo("Espada de Madera", "ARMA", 8, 0);
            agregarItemAlCatalogo("Espada de Diamante", "ARMA", 16, 0);
            agregarItemAlCatalogo("Armadura de Cuero", "ARMADURA", 0, 4);
            agregarItemAlCatalogo("Armadura de Acero", "ARMADURA", 0, 8);
            agregarItemAlCatalogo("Libro de Curación", "LIBRO", 0, 0);
            Hechizo smallCure = new Hechizo ("Cura Pequeña", "Curación", 10);
            (GetItem("Libro de Curación") as Libro).AñadirHechizo(smallCure);
            agregarItemAlCatalogo("Libro de Hechizos de Fuego", "LIBRO", 0, 0);
            Hechizo smallDmg = new Hechizo ("Bola de Fuego pequeña", "Daño", 12);
            (GetItem("Libro de Hechizos de Fuego") as Libro).AñadirHechizo(smallDmg);
            agregarItemAlCatalogo("Libro Maestro de Magia", "LIBRO", 0, 0);
            Hechizo bigCure = new Hechizo ("Sanación Profunda", "Curación", 20);
            Hechizo bigDmg = new Hechizo ("Misil mágico", "Daño", 22);
            (GetItem("Libro Maestro de Magia") as Libro).AñadirHechizo(bigCure);
            (GetItem("Libro Maestro de Magia") as Libro).AñadirHechizo(bigDmg);
        }

        private static void agregarItemAlCatalogo(string name, string tipo, int daño, int defensa)
        {
            switch (tipo.ToUpper())
            {
                case "ESPADA":
                catalogoItems.Add(new Espada(name,daño));
                break;

                case "ESCUDO":
                catalogoItems.Add(new Escudo(name,defensa,daño));
                break;

                case "PECHERA":
                catalogoItems.Add(new Pechera(name,defensa));
                break;

                case "LIBRO":
                catalogoItems.Add(new Libro(name));
                break;
            }
        }

        private static IItem GetItem(string nombreItem)
        {
            var query = from IItem item in catalogoItems where item.Name == nombreItem select item;
            return query.FirstOrDefault();
        }
    }
}
