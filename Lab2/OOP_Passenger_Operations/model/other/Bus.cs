namespace OOP_Passenger_Operations.model.other
{
    internal class Bus
    {
        // Название модели
        private string _modelName;
        // Гаражный номер
        private string _garageNuber;
        //Вместимость модели
        private int _capacity;
        // Степень "убитости" автобуса
        private int _condition;
        public Bus(string modelName, string garageNumber, int capacity, int condition)
        {
            _modelName = modelName;
            _garageNuber = garageNumber;
            _capacity = capacity;
            _condition = condition;
        }
        public string GetModelName() => _modelName;
        public string GetGarageNumber() => _garageNuber;
        public int GetModelCapacity() => _capacity;
        public int GetModelCondition() => _condition;
    }
}
