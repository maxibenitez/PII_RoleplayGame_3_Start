using NUnit.Framework;
using Program;

namespace Test.Library
{
    [TestFixture]

    public class PersonajeTest
    {
      [Test]

      public void ConstruirPersonajeTest()
      {
        Personaje p = new Personaje("Messi", "MAGO");
        string expectedName = "Messi";
        string expectedSpecies = "MAGO";

        Assert.AreSame(expectedName, p.Nombre);
        Assert.AreSame(expectedSpecies, p.Especie);
      }

      [Test]
      public void AddItemTest()
      {
        Personaje p = new Personaje("Messi", "MAGO");
        Item i = new Item("Espada de Diamante", "ARMA", 16, 0);

        p.AddItem(i);
        bool IteminInventario = p.Inventario.Contains(i);

        Assert.IsTrue(IteminInventario);
      }

      [Test]
      public void RemoveItemTest()
      {
        Personaje p = new Personaje("Messi", "MAGO");
        Item i = new Item("Espada de Diamante", "ARMA", 16, 0);

        p.AddItem(i);
        p.RemoveItem(i);
        bool IteminInventario = p.Inventario.Contains(i);

        Assert.IsFalse(IteminInventario);
      }

      [Test]
      public void ArmaTest()
      {
        Personaje p = new Personaje("Messi", "MAGO");
        Item i = new Item("Espada de Diamante", "ARMA", 16, 0);

        p.AddItem(i);

        Assert.AreSame(i, p.Arma);
      }

      [Test]
      public void HPTest()
      {
        Personaje p = new Personaje("Messi", "MAGO");

        p.HP = -20;

        int ExpectedHP = 0;

        Assert.AreEqual(ExpectedHP, p.HP);
      }

      [Test]
      public void AtaqueTest()
      {
        Personaje p = new Personaje("Messi", "MAGO");
        Item i = new Item("Espada de Diamante", "ARMA", 16, 0);
        Item e = new Item("Espada de Madera", "ARMA", 20, 0);

        p.AddItem(i);
        p.AddItem(e);

        int ExpectedAtaque = 25;

        Assert.AreEqual(ExpectedAtaque, p.Ataque);
      }

      [Test]
      public void DefensaTest()
      {
        Personaje p = new Personaje("Messi", "MAGO");
        Item i = new Item("Armadura de Cuero", "ARMADURA", 16, 0);
        Item e = new Item("Armadura de Acero", "ARMADURA", 20, 2);

        p.AddItem(i);
        p.AddItem(e);

        int ExpectedDefensa = 4;

        Assert.AreEqual(ExpectedDefensa, p.Defensa);
      }

      [Test]
      public void LibroEquipadoTest(){
        Personaje p = new Personaje("Messi", "MAGO");
        Item i = new Item("El Principito", "LIBRO", 16, 0);

        p.AddItem(i);

        Assert.AreSame(i, p.LibroEquipado);
      }

    }
}