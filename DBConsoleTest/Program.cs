using System;
using System.Collections.Generic;
using DBEntities;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DBConsoleTest
{
    static class Program
    {

        static List<Client> Clients()
        {
            List<Client> clientList = new List<Client>();

            for (int i = 0; i < 100; i++)
            {
                Client test = new Client();
                clientList.Add(test);
            }

            return clientList;
        }

        static void Main()
        {


            var clienList = Clients();
            
            string clientsCollectionName = "ClientsCollection";
            string dbName = "test1DB";
            
   
            var dbConnection = new DBLayer.DataBase(dbName);
            
            dbConnection.InsertMany(clienList,clientsCollectionName);
            
            //get info from ClientsCollection
            var clientsCollection = dbConnection.GetCollection<Client>(clientsCollectionName);
            var clients = clientsCollection.FindSync(_ => true).ToList();
            
            //create separate collection for
            //each one of client`s work collection
            //ALREADY DONE
            /*foreach (var client in clients)
            {
                var workCollection = client.WorkCollection;
                
                dbConnection.CreateCollection(workCollection);
            }*/
            
            
            //show all collections in db
            
            /*var allCollections = dbConnection.GetAllCollections();
            
            //iterates each one of collection
            foreach (var collection in allCollections.ToList())
            {
                //iterates each one of documents
                foreach (var element in collection.Elements)
                {
                    Console.WriteLine(element.Name);
                    Console.WriteLine("\t{0}",element.ToJson());
                }
            }*/

            //insert documents into clients collections
            //ALREADY DONE
            /*foreach (var client in clients)
            {
                //get client collection
                var workCollection = dbConnection.GetCollection(client.WorkCollection);

                var mock = DBEntities.TestMock.Factory();
                
                dbConnection.InsertOne(mock, client.WorkCollection);
            }*/
            
            foreach (var client in clients)
            {
                //get client collection
                var workCollection = dbConnection.GetCollection(client.WorkCollection);

                Console.WriteLine("Collection name : {0}", client.WorkCollection);
                var documents = workCollection.FindSync(_ => true);
                foreach (var document in documents.ToList())
                {
                    Console.WriteLine("\t{0}", document.ToJson());
                }
            }
            
            
            
            

            Console.ReadKey();
        }
    }
}