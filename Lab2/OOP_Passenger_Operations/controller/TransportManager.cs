namespace OOP_Passenger_Operations
{
    internal class TransportManager
    {
        // Метод генерации модели автобуса
        public string GenerateBusModel()
        {
            string[] _busModels = { "МАЗ-241", "МАЗ-103", "МАЗ-107", "МАЗ-251", "МАЗ-152", "МАЗ-216" };
            string _busModel = _busModels[new Random().Next(_busModels.Length - 1)];
            return _busModel;
        }

        // Метод генерации вместительности автобуса
        public int GenerateBusCapacity(string _busModel)
        {
            return 0;
        }

        // Метод генерации процента изношенности автобуса
        public int GenerateBusCondition()
        {
            return 0;
        }

        // Метод поиска самого вместительного автобуса компании
        public string ReturnModelNameMostCapaciousBus(Dictionary<string, int> _buses)
        {
            return "";
        }

        // Метод поиска самого популярного автобуса компании
        public string ReturnModelNameMostPopularBus(string[] _fleetBuses)
        {
            return "";
        }

        // Метод возврата общей вместительности автобусов всех компаний
        public int ReturnTotalCapacity()
        {
            return 0;
        }

        // Метод возврата самой вместительной модели автобуса из всех компаний
        public string ReturnCapacityModel()
        {
            return "";
        }

        // Метод возврата самой популярной модели автобуса из всех компаний
        public string ReturnPopularModel()
        {
            return "";
        }

        // Метод возврата маскимального процента изношенности автобуса из всех компаний
        public int ReturnMaxCondition()
        {
            return 0;
        }

        // Метод возврата минимального процента изношенности автобуса из всех компаний
        public int ReturnMinCondition()
        {
            return 0;
        }

        // Метод вывода данных об автобусах для каждой компании
        public string ReturnTotalTransportInfo(TransportParks _transportParks ,string _category)
        {
            return "";
        }
    }
}
