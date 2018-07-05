using System;
using System.Collections;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DBLayer
{
    /// <summary>
    /// Put and get data from MongoDB
    /// </summary>
    public class DataBase
    {
        private string _dbName;
        private IMongoDatabase _db;
        
        public DataBase(string dbName)
        {
            _dbName = dbName;
            _db = GetDb();
        }


        /// <summary>
        /// Get db
        /// </summary>
        /// <returns>db</returns>
        private IMongoDatabase GetDb()
        {
            //get the client to interact with db
            var client = new MongoClient();
            
            //get db
            var db = client.GetDatabase(_dbName);

            return db;
        }
        
        /// <summary>
        /// Insert documents to the collection
        /// </summary>
        /// <param name="documents">objects want to be inserted</param>
        /// <param name="collectionName">working collection name</param>
        /// <typeparam name="T"></typeparam>
        public void InsertMany<T>(IEnumerable<T> documents, string collectionName)
        {
            //get working collection
            var collection = _db.GetCollection<T>(collectionName);
            
            //insert to the collection
            collection.InsertMany(documents);
        }

        /// <summary>
        /// Insert a document to the collection
        /// </summary>
        /// <param name="document">doc want to be inserted</param>
        /// <param name="collectionName">collection name</param>
        /// <typeparam name="T"></typeparam>
        public void InsertOne<T>(T document, string collectionName)
        {
            //get working collection
            var collection = _db.GetCollection<T>(collectionName);
            
            //insert to the collection
            collection.InsertOne(document);
        }
        

        /// <summary>
        /// returns collection by name
        /// </summary>
        /// <param name="name"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public IMongoCollection<T> GetCollection<T>(string name)
        {
            //get the collection
            var collection = _db.GetCollection<T>(name);

            return collection;
        }

        /// <summary>
        /// create colection by name
        /// </summary>
        /// <param name="name"></param>
        public void CreateCollection(string name)
        {
            //get client to interact with db
            var client = new MongoClient();
            
            //get session
            var session = client.StartSession();
            
            //create collection
            _db.CreateCollection(session, name);
        }

        /// <summary>
        /// returns all collections in the db
        /// </summary>
        /// <returns>all collections from db</returns>
        public IAsyncCursor<BsonDocument> GetAllCollections()
        {
            //get client to interact with db
            var client = new MongoClient();
            
            //get session
            var session = client.StartSession();
            
            return _db.ListCollections(session);
        }

        /// <summary>
        /// returns all collection names in the db
        /// </summary>
        /// <returns>all collection names from db</returns>
        public IAsyncCursor<string> GetCollectionNames()
        {
            //get client to interact with db
            var client = new MongoClient();
            
            //get session
            var session = client.StartSession();

            return _db.ListCollectionNames();
        }

        /// <summary>
        /// returns collection of db collection
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public IMongoCollection<BsonDocument> GetCollection(string name)
        {
            //get client to interact with db
            var client = new MongoClient();
            
            //get session
            var session = client.StartSession();

            return _db.GetCollection<BsonDocument>(name);
        }
        
    }
}