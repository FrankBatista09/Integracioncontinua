namespace PruebaUni
{
    [TestClass]
    public class UnitTest1 
    {
        [TestMethod]
        public void TestMethod1()
        {
            var saludo = Saludo.clase.Saludo.Saludos();

            Assert.AreEqual(saludo, "Hola mundo");
        }

    }
}