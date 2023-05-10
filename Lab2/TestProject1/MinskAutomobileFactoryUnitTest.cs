using OOP_Passenger_Operations;
using OOP_Passenger_Operations.controller;
using OOP_Passenger_Operations.model.other;

namespace TestProject
{
    [TestClass]
    public class MinskAutomobileFactoryUnitTest
    {
        [TestMethod]
        public void TestGenerateBusConditionMethod()
        {
            bool expected = true;
            int condition = MinskAutomobileFactory.GenerateBusCondition();
            bool retrieved = (condition <= 100 && condition >= 0);
            Assert.AreEqual(expected, retrieved, "Метод GenerateBusCondition работает некорректно!");
        }

        [TestMethod]
        public void TestGenerateBusCapacityMethod()
        {
            string busModel = MinskAutomobileFactory.GenerateBusModel();
            string garageNumber = MinskAutomobileFactory.GenerateGarageNumber();
            int capacity = MinskAutomobileFactory.GenerateBusCapacity(busModel);
            int condition = MinskAutomobileFactory.GenerateBusCondition();

            Bus bus = new Bus(busModel, garageNumber, capacity, condition);

            int expected = MinskAutomobileFactory._busCapacity[busModel];
            int retrieved = capacity;
            Assert.AreEqual(expected, retrieved, "Метод GenerateBusCapacity работает некорректно!");
        }
    }
}
