namespace DBEntities
{
    public class ClientMock3
    {
        public long Field1 { get; set; }
        public long Field2 { get; set; }
        public long Field3 { get; set; }
        public long Field4 { get; set; }
        public long Field5 { get; set; }
        public long Field6 { get; set; }
        public long Field7 { get; set; }
        public long Field8 { get; set; }
        public long Field9 { get; set; }


        public static ClientMock3 Factory()
        {
            return new ClientMock3();
        }
    }
}