using NUnit.Framework;
using Program;

namespace Test.Library
{
    [TestFixture]

    public class ExampleTest
    {

        [Test]
        public void itemCreationTest()
        //se testea las asignaciones corerctas funcionen y las erroneas rechazadas
        {
            Espada espadaAvanzada = new Espada("Espada de Diamante",16);
            string expectedName = "Espada de Diamante";
            int expectedDMG = 16;
            Assert.AreEqual(expectedName, espadaAvanzada.Nombre);
            Assert.AreEqual(expectedDMG, espadaAvanzada.DMG);
        }

        [Test]
        public void spellCreationTest()
        //se testea la clase hechizo y su uso
        {
            Hechizo spell = new Hechizo("spell", "Daño", 10);
            string expectedType = "Daño";
            string expectedName = "spell";
            int expectedPower = 10;
            Assert.AreSame(expectedName, spell.Nombre);
            Assert.AreEqual(expectedType, spell.TipoEfecto);
            Assert.AreEqual(expectedPower, spell.Poder);

        }
        [Test]
        public void itemAndSpellTest()
        //testeo de items especiales LIBRO y hechizos juntos (collab)
        {
            Libro libro = new Libro("Sapo Ruperto");
            Hechizo spell1 = new Hechizo ("RupertoRocanrol", "Daño", 9000);
            Hechizo spell2 = new Hechizo ("SanaSanaColitaDeRana", "Curación", 9000);
            libro.AñadirHechizo(spell1);
            libro.AñadirHechizo(spell2);
            Assert.IsTrue(libro.HechizosGuardados.Contains(spell1));
            Assert.IsTrue(libro.HechizosGuardados.Contains(spell2));
        }
    }
}