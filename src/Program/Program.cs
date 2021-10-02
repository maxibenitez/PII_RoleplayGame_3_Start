namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
        //los personajes los ideaban cada integrante, Alonso solo escribió la implementación
            Elfo maxiChar = new Elfo("Legolas", "Heroes");
            Espada arco = new Espada("Arco élfico",14);
            Pechera cota = new Pechera("Cota de Malla élfica",8);
            maxiChar.AddItem(arco);
            maxiChar.AddItem(cota);

            Mago danaChar = new Mago("Danurris", "Enemies");
            Libro danaBook = new Libro("El principito");
            Hechizo magiaDana = new Hechizo("Desconocerse", "Daño", 69);
            danaBook.AñadirHechizo(magiaDana);
            danaChar.AddItem(cota);
            danaChar.AddItem(danaBook);
            
            Mago marceChar = new Mago("Isandril", "Heroes");
            Libro marceBook = new Libro("Arcaneum");
            Hechizo magiaMarce2 = new Hechizo("Rejuvenecer", "Curación", 50);
            Hechizo magiaMarce = new Hechizo("Tormenta de Arena", "Daño", 45);
            marceBook.AñadirHechizo(magiaMarce);
            marceBook.AñadirHechizo(magiaMarce2);
            Pechera toga = new Pechera("Toga de Fuego",12);
            marceChar.AddItem(toga);
            marceChar.AddItem(marceBook);

            Enano alonsoChar = new Enano("Torbjorn", "Enemies");
            Espada thor = new Espada("Mjollnir",85);
            Pechera konan = new Pechera("Cota de Konan",15);
            alonsoChar.AddItem(thor);
            alonsoChar.AddItem(konan);

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
    }
}
