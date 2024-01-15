using Kalkulator;
namespace Kalkulator.Tests
{
    [TestClass]
    public class KalkulatorTests
    {

        [TestMethod]
        public void TestDodawanie()
        {
            Assert.AreEqual(5.0, Kalkulator.Dodawanie(2.5, 2.5), 0.01);
        }
        public void TestOdejmowanie()
        {
            Assert.AreEqual(2.0, Kalkulator.Odejmowanie(5.5, 3.5), 0.01);
        }
        public void TestMno¿enie()
        {
            Assert.AreEqual(15.0, Kalkulator.Mno¿enie(3.0, 5.0), 0.01);
        }
        public void TestDzielenie()
        {
            Assert.AreEqual(2.0, Kalkulator.Dzielenie(6.0, 3.0), 0.01);
        }
        public void TestDzieleniePrzezZero()
        {
            Kalkulator.Dzielenie(5.0, 0.0);
        }
        public void TestPotêgowanie()
        {
            Assert.AreEqual(8.0, Kalkulator.Potêgowanie(2.0, 3.0), 0.01);
        }
        public void TestPierwiastkowanie()
        {
            Assert.AreEqual(2.0, Kalkulator.Pierwiastkowanie(4.0, 2.0), 0.01);
        }
        public void TestPierwiastkowanieLiczbyUjemne()
        {
            Kalkulator.Pierwiastkowanie(-4.0, 2.0);
        }

    }
}
