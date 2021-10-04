using NUnit.Framework;
using Program;

namespace Test.Library
{
    [TestFixture]
    public class TestInteracciones
    {
        [Test]
        public void Ataque()
        //se testea la interacción de ataque
        {
            Mago danaChar = new Mago("Danurris", "Enemies");
            Libro libro1 = new Libro("El principito");
            Hechizo magiaDana = new Hechizo("Desconocerse", "Daño", 70);
            libro1.AñadirHechizo(magiaDana);
            danaChar.AddItem(libro1);
            
            Enano alonsoChar = new Enano("Torbjorn", "Enemies");
            Espada arma = new Espada("Mjollnir",18);
            Pechera armadura = new Pechera("Cota de Konan",13);
            alonsoChar.AddItem(arma);
            alonsoChar.AddItem(armadura);

            Interacciones.Ataque(danaChar, alonsoChar);

            int expectedHp = 100;
            
            Assert.AreEqual(expectedHp, alonsoChar.Health);
        }

        [Test]

        public void LanzamientoHechizoAtaque()
        //se testea la interacción de ataque con lanzamiento de hechizo
        {
            Mago danaChar = new Mago("Danurris", "Enemies");
            Libro libro1 = new Libro("El principito");
            Hechizo magiaDana = new Hechizo("Desconocerse", "Daño", 70);
            libro1.AñadirHechizo(magiaDana);
            danaChar.AddItem(libro1);
            
            Mago marceChar = new Mago("Isandril", "Heroes");
            Libro libro2 = new Libro("Arcaneum");
            Hechizo magiaMarce = new Hechizo("Tormenta de Arena", "Daño", 45);
            Hechizo curaMarce = new Hechizo("Poción", "Curación", 60);
            libro2.AñadirHechizo(magiaMarce);
            libro2.AñadirHechizo(curaMarce);
            marceChar.AddItem(libro2);

            Enano alonsoChar = new Enano("Torbjorn", "Enemies");
            Espada arma = new Espada("Mjollnir",18);
            Pechera armadura = new Pechera("Cota de Konan",13);
            alonsoChar.AddItem(arma);
            alonsoChar.AddItem(armadura);

            Interacciones.LanzamientoHechizo(danaChar, magiaDana, alonsoChar);

            string expectedHechizo = "Desconocerse";
            int expectedVida = 30;

            Assert.AreEqual(expectedHechizo, magiaDana.Nombre);
            Assert.AreEqual(expectedVida, alonsoChar.Health);
        }

        [Test]

        public void LanzamientoHechizoCuracion()
        //se testea la interacción de curación con lanzamiento de hechizo
        {
            Mago danaChar = new Mago("Danurris", "Enemies");
            Libro libro1 = new Libro("El principito");
            Hechizo magiaDana = new Hechizo("Desconocerse", "Daño", 70);
            libro1.AñadirHechizo(magiaDana);
            danaChar.AddItem(libro1);
            
            Mago marceChar = new Mago("Isandril", "Heroes");
            Libro libro2 = new Libro("Arcaneum");
            Hechizo magiaMarce = new Hechizo("Tormenta de Arena", "Daño", 45);
            Hechizo curaMarce = new Hechizo("Poción", "Curación", 60);
            libro2.AñadirHechizo(magiaMarce);
            libro2.AñadirHechizo(curaMarce);
            marceChar.AddItem(libro2);

            Enano alonsoChar = new Enano("Torbjorn", "Enemies");
            Espada arma = new Espada("Mjollnir",18);
            Pechera armadura = new Pechera("Cota de Konan",13);
            alonsoChar.AddItem(arma);
            alonsoChar.AddItem(armadura);
            
            Interacciones.LanzamientoHechizo(danaChar, magiaDana, alonsoChar);
            Interacciones.LanzamientoHechizo(marceChar, curaMarce, alonsoChar);

            string expectedhechizo = "Poción";
            int expectedCura = 90;

            Assert.AreEqual(expectedhechizo, curaMarce.Nombre);
            Assert.AreEqual(expectedCura, alonsoChar.Health);
        }

        [Test]

        public void Curacion()
        //se testea la interacción de curación no sobrepase la vida máxima
        {
            Mago danaChar = new Mago("Danurris", "Enemies");
            Libro libro1 = new Libro("El principito");
            Hechizo magiaDana = new Hechizo("Desconocerse", "Daño", 70);
            libro1.AñadirHechizo(magiaDana);
            danaChar.AddItem(libro1);
            
            Mago marceChar = new Mago("Isandril", "Heroes");
            Libro libro2 = new Libro("Arcaneum");
            Hechizo magiaMarce = new Hechizo("Tormenta de Arena", "Daño", 45);
            Hechizo curaMarce = new Hechizo("Poción", "Curación", 70);
            libro2.AñadirHechizo(magiaMarce);
            libro2.AñadirHechizo(curaMarce);
            marceChar.AddItem(libro2);

            Enano alonsoChar = new Enano("Torbjorn", "Enemies");
            Espada arma = new Espada("Mjollnir",18);
            Pechera armadura = new Pechera("Cota de Konan",13);
            alonsoChar.AddItem(arma);
            alonsoChar.AddItem(armadura);
            
            Interacciones.LanzamientoHechizo(danaChar, magiaDana, alonsoChar);
            Interacciones.LanzamientoHechizo(marceChar, curaMarce, alonsoChar);

            int expectedCura = 100;

            Assert.AreEqual(expectedCura, alonsoChar.Health);
        }
    }
}