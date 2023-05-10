using OOP_Passenger_Operations;
using OOP_Passenger_Operations.model.other;

namespace TestProject
{
    [TestClass]
    public class StateBusInspectionUnitTest
    {
        [TestMethod]
        public void TestMaxConditionBusMethod()
        {
            Bus[] buses = new Bus[]
            {
                new Bus("AAAA", "1111", 100, 53),
                new Bus("BBBB", "2222", 100, 50),
            };
            Bus expected = buses[0];
            Bus retrieved = StateBusInspection.ReturnMaxConditionBus(buses);
            Assert.AreEqual(expected, retrieved, "Метод ReturnMaxConditionBus работает некорректно!");
        }

        [TestMethod]
        public void TestMinConditionBusMethod()
        {
            Bus[] buses = new Bus[]
            {
                new Bus("AAAA", "1111", 100, 77),
                new Bus("BBBB", "2222", 100, 33),
            };
            Bus expected = buses[1];
            Bus retrieved = StateBusInspection.ReturnMinConditionBus(buses);
            Assert.AreEqual(expected, retrieved, "Метод ReturnMaxConditionBus работает некорректно!");
        }

        [TestMethod]
        public void TestMostCapaciousBusMethod()
        {
            Bus[] buses = new Bus[]
            {
                new Bus("AAAA", "1111", 300, 77),
                new Bus("BBBB", "2222", 100, 33),
            };
            Bus expected = buses[0];
            Bus retrieved = StateBusInspection.ReturnMostCapaciousBus(buses);
            Assert.AreEqual(expected, retrieved, "Метод ReturnMostCapaciousBus работает некорректно!");
        }

    }
}