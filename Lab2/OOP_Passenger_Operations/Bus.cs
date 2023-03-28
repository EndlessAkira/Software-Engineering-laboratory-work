namespace OOP_Passenger_Operations
{
    internal class Bus
    {
        // Название модели
        private string _modelName
        {
            get { return _modelName; }
            set { _modelName = value; }
        }
        //Вместимость модели
        private int _capacity
        {
            get { return _capacity; }
            set { _capacity = value; }
        }
        // Степень "убитости" автобуса
        private int _condition
        {
            get { return _condition; }
            set { _condition = value; }
        }
    }
}
