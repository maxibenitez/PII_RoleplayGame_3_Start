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
            Personaje danaChar = new Personaje("Danurris", "MAGO");
            Item libro1 = new Item("El principito", "LIBRO", 0, 0);
            Hechizo magiaDana = new Hechizo("Desconocerse", "Daño", 70);
            libro1.AñadirHechizo(magiaDana);
            danaChar.AddItem(libro1);
            
            Personaje alonsoChar = new Personaje("Torbjorn", "ENANO");
            Item arma = new Item("Mjollnir", "ARMA", 18, 0);
            Item armadura = new Item("Cota de Konan", "ARMADURA", 0, 13);
            alonsoChar.AddItem(arma);
            alonsoChar.AddItem(armadura);

            Interacciones.Ataque(danaChar, alonsoChar);

            string expectedNombre = "Torbjorn";
            string expectednombre = "Danurris";
            int expectedHp = 100;
            
            Assert.AreEqual(expectedHp, alonsoChar.HP);
            Assert.AreEqual(expectedNombre, alonsoChar.Nombre);
            Assert.AreEqual(expectednombre, danaChar.Nombre);
        }

        [Test]

        public void LanzamientoHechizoAtaque()
        //se testea la interacción de ataque con lanzamiento de hechizo
        {
            Personaje danaChar = new Personaje("Danurris", "MAGO");
            Item libro1 = new Item("El principito", "LIBRO", 0, 0);
            Hechizo magiaDana = new Hechizo("Desconocerse", "Daño", 70);
            libro1.AñadirHechizo(magiaDana);
            danaChar.AddItem(libro1);
            
            Personaje marceChar = new Personaje("Isandril", "MAGO");
            Item libro2 = new Item("Arcaneum", "LIBRO", 0, 0);
            Hechizo magiaMarce = new Hechizo("Tormenta de Arena", "Daño", 45);
            Hechizo curaMarce = new Hechizo("Poción", "Curación", 60);
            libro2.AñadirHechizo(magiaMarce);
            libro2.AñadirHechizo(curaMarce);
            marceChar.AddItem(libro2);

            Personaje alonsoChar = new Personaje("Torbjorn", "ENANO");
            Item arma = new Item("Mjollnir", "ARMA", 18, 0);
            Item armadura = new Item("Cota de Konan", "ARMADURA", 0, 13);
            alonsoChar.AddItem(arma);
            alonsoChar.AddItem(armadura);

            Interacciones.LanzamientoHechizo(danaChar, magiaDana, alonsoChar);

            string expectedName = "Torbjorn";
            string expectedname = "Danurris";
            string expectedHechizo = "Desconocerse";
            int expectedVida = 30;

            Assert.AreEqual(expectedName, alonsoChar.Nombre);
            Assert.AreEqual(expectedname, danaChar.Nombre);
            Assert.AreEqual(expectedHechizo, magiaDana.Nombre);
            Assert.AreEqual(expectedVida, alonsoChar.HP);
        }

        [Test]

        public void LanzamientoHechizoCuracion()
        //se testea la interacción de curación con lanzamiento de hechizo
        {
            Personaje danaChar = new Personaje("Danurris", "MAGO");
            Item libro1 = new Item("El principito", "LIBRO", 0, 0);
            Hechizo magiaDana = new Hechizo("Desconocerse", "Daño", 70);
            libro1.AñadirHechizo(magiaDana);
            danaChar.AddItem(libro1);
            
            Personaje marceChar = new Personaje("Isandril", "MAGO");
            Item libro2 = new Item("Arcaneum", "LIBRO", 0, 0);
            Hechizo magiaMarce = new Hechizo("Tormenta de Arena", "Daño", 45);
            Hechizo curaMarce = new Hechizo("Poción", "Curación", 60);
            libro2.AñadirHechizo(magiaMarce);
            libro2.AñadirHechizo(curaMarce);
            marceChar.AddItem(libro2);

            Personaje alonsoChar = new Personaje("Torbjorn", "ENANO");
            Item arma = new Item("Mjollnir", "ARMA", 18, 0);
            Item armadura = new Item("Cota de Konan", "ARMADURA", 0, 13);
            alonsoChar.AddItem(arma);
            alonsoChar.AddItem(armadura);
            
            Interacciones.LanzamientoHechizo(danaChar, magiaDana, alonsoChar);
            Interacciones.LanzamientoHechizo(marceChar, curaMarce, alonsoChar);

            string expectedNomb = "Torbjorn";
            string expectednomb = "Isandril";
            string expectedhechizo = "Poción";
            int expectedCura = 90;

            Assert.AreEqual(expectedNomb, alonsoChar.Nombre);
            Assert.AreEqual(expectednomb, marceChar.Nombre);
            Assert.AreEqual(expectedhechizo, curaMarce.Nombre);
            Assert.AreEqual(expectedCura, alonsoChar.HP);
        }

        [Test]

        public void Curacion()
        //se testea la interacción de curación no sobrepase la vida máxima
        {
            Personaje danaChar = new Personaje("Danurris", "MAGO");
            Item libro1 = new Item("El principito", "LIBRO", 0, 0);
            Hechizo magiaDana = new Hechizo("Desconocerse", "Daño", 70);
            libro1.AñadirHechizo(magiaDana);
            danaChar.AddItem(libro1);
            
            Personaje marceChar = new Personaje("Isandril", "MAGO");
            Item libro2 = new Item("Arcaneum", "LIBRO", 0, 0);
            Hechizo magiaMarce = new Hechizo("Tormenta de Arena", "Daño", 45);
            Hechizo curaMarce = new Hechizo("Poción", "Curación", 120);
            libro2.AñadirHechizo(magiaMarce);
            libro2.AñadirHechizo(curaMarce);
            marceChar.AddItem(libro2);

            Personaje alonsoChar = new Personaje("Torbjorn", "ENANO");
            Item arma = new Item("Mjollnir", "ARMA", 18, 0);
            Item armadura = new Item("Cota de Konan", "ARMADURA", 0, 13);
            alonsoChar.AddItem(arma);
            alonsoChar.AddItem(armadura);
            
            Interacciones.LanzamientoHechizo(danaChar, magiaDana, alonsoChar);
            Interacciones.LanzamientoHechizo(marceChar, curaMarce, alonsoChar);

            int expectedCura = 100;

            Assert.AreEqual(expectedCura, alonsoChar.HP);
        }
    }
}