using OOP_Passenger_Operations;

namespace TestProject
{
    [TestClass]
    public class NationalBusParkUnitTest
    {
        [TestMethod]
        public void TestIsEmptyMethod()
        {
            NationalBusPark nationalBusPark = new NationalBusPark();
            bool expected = true;
            bool retrieved = nationalBusPark.IsEmpty();
            Assert.AreEqual(expected, retrieved, "Метод IsEmpty работает некорректно!");
        }

        [TestMethod]
        public void TestIsFillMethod()
        {
            NationalBusPark nationalBusPark = new NationalBusPark();
            bool expected = false;
            bool retrieved = nationalBusPark.IsFill();
            Assert.AreEqual(expected, retrieved, "Метод IsFill работает некорректно!");
        }
    }
}
