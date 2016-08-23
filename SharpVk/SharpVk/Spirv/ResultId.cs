namespace SharpVk.Spirv
{

    public struct ResultId
    {
        public int Id
        {
            get;
            private set;
        }

        public override string ToString()
        {
            return "%" + this.Id;
        }

        public static implicit operator ResultId(int value)
        {
            return new ResultId
            {
                Id = value
            };
        }
    }
}
