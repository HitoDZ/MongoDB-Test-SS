using System;
using System.Collections.Generic;

namespace DBEntities
{
    public class ClientMock1
    {
        public long Id { get; set; }

        public long Field1 { get; set; }
        public long Field2 { get; set; }
        public long Field3 { get; set; }
        public long Field4 { get; set; }
        public long Field5 { get; set; }
        public long Field6 { get; set; }
        public long Field7 { get; set; }
        public long Field8 { get; set; }
        public long Field9 { get; set; }
        
        // Подумал таким способом передавать родителя будет лучше
        public long? ParentId = null;
        
        public List<ClientMock2> Childs;
        
//        public ClientMock2 Child1 { get; set; }
//        public ClientMock2 Child2 { get; set; }
//        public ClientMock2 Child3 { get; set; }
//        public ClientMock2 Child4 { 0get; set; }
//        public ClientMock2 Child5 { get; set; }
        
        //public List<ClientMock2> Childs;

        public ClientMock1(long parentID)
        {
            this.ParentId = parentID;
            
            var id = IdGenerator.GetId();
            int childNum = new Random().Next(0, 10);

            this.Id = id;
            for (int i = 0; i < childNum; i++)
            {
                Childs.Add(new ClientMock2(this.Id));
            }
        }
        
        public ClientMock1()
        {
            var id = IdGenerator.GetId();
            int childNum = new Random().Next(0, 10);

            this.Id = id;
            for (int i = 0; i < childNum; i++)
            {
                Childs.Add(new ClientMock2(this.Id));
            }
        }
       

//        public static ClientMock1 Factory()
//        {
//            
//            
////            return new ClientMock1()
////            {
////                
////                Child1 = ClientMock2.Factory(),
////                Child2 = ClientMock2.Factory(),
////                Child3 = ClientMock2.Factory(),
////                Child4 = ClientMock2.Factory(),
////                Child5 = ClientMock2.Factory(),
////                Child6 = ClientMock3.Factory(),
////                Child7 = ClientMock3.Factory(),
////                Child8 = ClientMock3.Factory(),
////                Child9 = ClientMock3.Factory(),
////                Child10 = ClientMock3.Factory()
////            };
//        }
    }
}