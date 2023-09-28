namespace lab02
{
    public partial class Bus
    {
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType()) { return false; }

            Bus compare = (Bus)obj;

            return Id == compare.Id;
        }

        public override int GetHashCode()
        {
            return YearExploitation ^ _myConst;
        }
    }
}