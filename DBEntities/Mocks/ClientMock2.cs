namespace DBEntities
{
    public class ClientMock2
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
        
        public ClientMock3 Child1 { get; set; }
        public ClientMock3 Child2 { get; set; }
        public ClientMock3 Child3 { get; set; }
        public ClientMock3 Child4 { get; set; }
        public ClientMock3 Child5 { get; set; }

        public static ClientMock2 Factory()
        {
            return new ClientMock2()
            {
                Child1 = ClientMock3.Factory(),
                Child2 = ClientMock3.Factory(),
                Child3 = ClientMock3.Factory(),
                Child4 = ClientMock3.Factory(),
                Child5 = ClientMock3.Factory()
            };
        }
    }
}