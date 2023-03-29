namespace OOP_Passenger_Operations
{
    internal class Bus
    {
        // Название модели
        public string _modelName
        {
            get { return _modelName; }
            set { _modelName = value; }
        }
        //Вместимость модели
        public int _capacity
        {
            get { return _capacity; }
            set { _capacity = value; }
        }
        // Степень "убитости" автобуса
        public int _condition
        {
            get { return _condition; }
            set { _condition = value; }
        }
    }
}
