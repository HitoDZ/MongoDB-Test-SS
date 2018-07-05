namespace DBEntities
{
    public class ClientMock1
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
        
        
        public ClientMock2 Child1 { get; set; }
        public ClientMock2 Child2 { get; set; }
        public ClientMock2 Child3 { get; set; }
        public ClientMock2 Child4 { get; set; }
        public ClientMock2 Child5 { get; set; }
        
        public ClientMock3 Child6 { get; set; }
        public ClientMock3 Child7 { get; set; }
        public ClientMock3 Child8 { get; set; }
        public ClientMock3 Child9 { get; set; }
        public ClientMock3 Child10 { get; set; }

        public static ClientMock1 Factory()
        {
            return new ClientMock1()
            {
                Child1 = ClientMock2.Factory(),
                Child2 = ClientMock2.Factory(),
                Child3 = ClientMock2.Factory(),
                Child4 = ClientMock2.Factory(),
                Child5 = ClientMock2.Factory(),
                Child6 = ClientMock3.Factory(),
                Child7 = ClientMock3.Factory(),
                Child8 = ClientMock3.Factory(),
                Child9 = ClientMock3.Factory(),
                Child10 = ClientMock3.Factory()
            };
        }
    }
}