using CleanCodeLabs.Codelab01;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CleanCodeLabs.Tests
{
    [TestClass]
    public class Codelab01Tests
    {
        [TestMethod]
        public void TestCarManager()
        {
            var carManager = new CarManager();

            Assert.AreEqual("Volkswagen Golf III, Fiat Multipla, Renault Megane", carManager.GetCarsNames());
            Assert.AreEqual("Multipla", carManager.GetBestCar().Model);
            Assert.AreEqual("Renault", carManager.GetCarFromDb("3").Brand);
        }
    }
}