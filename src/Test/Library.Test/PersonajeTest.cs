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
        Mago p = new Mago("Messi", "Heroes");
        string expectedName = "Messi";

        Assert.AreSame(expectedName, p.Nombre);

        Elfo i = new Elfo("Messi", "Enemies");
        Assert.AreSame(expectedName, i.Nombre);

        Enano e = new Enano("Messi", "Heroes");
        Assert.AreSame(expectedName, e.Nombre);
      }

      [Test]
      public void AddItemTest()
      {
        Elfo p = new Elfo("Messi", "Enemies");
        Espada i = new Espada("Espada de Diamante", 16);

        p.AddItem(i);
        bool IteminInventario = p.Inventario.Contains(i);
        Assert.IsTrue(IteminInventario);
      }

      [Test]
      public void RemoveItemTest()
      {
        Elfo p = new Elfo("Messi", "Enemies");
        Espada i = new Espada("Espada de Diamante", 16);

        p.AddItem(i);
        p.RemoveItem(i);
        bool IteminInventario = p.Inventario.Contains(i);

        Assert.IsFalse(IteminInventario);
      }

      [Test]
      public void ArmaTest()
      {
        Elfo p = new Elfo("Messi", "Enemies");
        Espada i = new Espada("Espada de Diamante", 16);

        p.AddItem(i);

        Assert.AreEqual(i, p.Arma);
      }

      [Test]
      public void HPTest()
      {
        Elfo p = new Elfo("Messi", "Enemies");
        Enano i = new Enano("Gloin", "Heroes");
        Interacciones.Ataque(i, p);

        int ExpectedHP = 97;

        Assert.AreEqual(ExpectedHP, p.Health);
      }

      [Test]
      public void AtaqueTest()
      {
        Elfo p = new Elfo("Messi", "Enemies");
        Espada i = new Espada("Espada de Diamante", 16);
        Espada e = new Espada("Espada de Plata", 20);

        p.AddItem(i);
        p.AddItem(e);

        int ExpectedAtaque = 25;

        Assert.AreEqual(ExpectedAtaque, p.Ataque);
      }

      [Test]
      public void DefensaTest()
      {
        Elfo p = new Elfo("Messi", "Enemies");
        Pechera i = new Pechera("Armadura de Cuero", 16);
        Pechera e = new Pechera("Armadura de Oro", 20);

        p.AddItem(i);
        p.AddItem(e);

        int ExpectedDefensa = 22;

        Assert.AreEqual(ExpectedDefensa, p.Defensa);
      }

      [Test]
      public void LibroEquipadoTest(){
        Mago p = new Mago("Messi", "Heroes");
        Libro i = new Libro("El Principito");
        Hechizo e = new Hechizo("Kame-hame-ha", "Daño", 5);

        p.AddItem(i);
        i.AñadirHechizo(e);

        Assert.IsTrue(p.LibroEquipado.Contains(e));
      }
    }
}