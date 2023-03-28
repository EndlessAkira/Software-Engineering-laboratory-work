namespace OOP_Passenger_Operations
{
    internal class BrestOblAvtoTrans : OblAvtoTrans
    {
        public BrestOblAvtoTrans()
        {
            foreach(Bus bus in buses)
            {
                //
            }
        }
        public override string ReturnTransportInfo()
        {
            throw new NotImplementedException();
        }
        public override string ReturnCapacityModelForCategory()
        {
            throw new NotImplementedException();
        }

        public override float ReturnMaxConditionForCategory()
        {
            throw new NotImplementedException();
        }

        public override float ReturnMinConditionForCategory()
        {
            throw new NotImplementedException();
        }

        public override string ReturnPopularModelForCategory()
        {
            throw new NotImplementedException();
        }

        public override int ReturnTotalCapacityForCategory()
        {
            throw new NotImplementedException();
        }
    }
}
