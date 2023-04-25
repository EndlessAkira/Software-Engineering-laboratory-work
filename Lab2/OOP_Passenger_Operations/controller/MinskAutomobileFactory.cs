namespace OOP_Passenger_Operations.controller
{
    internal abstract class MinskAutomobileFactory
    {
        private static List<string> _busModels = new List<string>()
        {
            "МАЗ-241",
            "МАЗ-103",
            "МАЗ-251",
            "МАЗ-107",
            "МАЗ-152",
            "МАЗ-216",
        };
        private static Dictionary<string, int> _busCapacity = new Dictionary<string, int>()
        {
            ["МАЗ-241"] = 20,
            ["МАЗ-103"] = 100,
            ["МАЗ-251"] = 125,
            ["МАЗ-107"] = 45,
            ["МАЗ-152"] = 45,
            ["МАЗ-216"] = 190
        };

        // Метод генерации модели автобуса
        public static string GenerateBusModel()
        {
            return _busModels[new Random().Next(_busModels.Count - 1)];
        }
        // Метод генерации гаражного номера
        public static string GenerateGarageNumber()
        {
            int intNumber = new Random().Next(0, 10000);
            string number = Convert.ToString(intNumber);
            return number;
        }
        // Метод генерации вместительности автобуса
        public static int GenerateBusCapacity(string _busModel)
        {
            return _busCapacity[_busModel];
        }
        // Метод генерации процента изношенности автобуса
        public static int GenerateBusCondition()
        {
            return new Random().Next(0, 100);
        }
    }
}
