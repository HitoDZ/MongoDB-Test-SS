using System;
using System.Collections.Generic;

namespace DBEntities
{
    public class ClientMock2
    {
        
        public long Id { get; set; }

        public long Field1 { get; set; }
        public long Field2 { get; set; }
        public long Field3 { get; set; }
        public long Field4 { get; set; }
        public long Field5 { get; set; }
        public long Field6 { get; set; }
     
        public long? ParentId = null;

        public List<ClientMock1> Childs;



        public ClientMock2(long parentID)
        {
            this.ParentId = parentID;
            
            var id = IdGenerator.GetId();
            int childNum = new Random().Next(0, 5);

            this.Id = id;
            for (int i = 0; i < childNum; i++)
            {
                Childs.Add(new ClientMock1(this.Id));
            }
        }
        
//        public static ClientMock2 Factory()
//        {
//            return new ClientMock2()
//            {
//                Child1 = ClientMock3.Factory(),
//                Child2 = ClientMock3.Factory(),
//                Child3 = ClientMock3.Factory(),
//                Child4 = ClientMock3.Factory(),
//                Child5 = ClientMock3.Factory()
//            };
//        }
    }
}