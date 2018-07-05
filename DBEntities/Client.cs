using System;

namespace DBEntities
{
    /// <summary>
    /// Entity that reflect an information
    /// about a client
    /// </summary>
    public class Client
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string WorkCollection { get; set; }
        
        //ctor
        public Client()
        {
            var id = IdGenerator.GetId();
            var name = NameGenerator.GetName();
            var workColl = "coll" + name + Convert.ToString(id);



            this.Id = id;
            this.Name = name;
            this.WorkCollection = workColl;

        }
        public static Client GenerateRandom()
        {
            var id = IdGenerator.GetId();
            var name = NameGenerator.GetName();
            var workColl = "coll" + name + Convert.ToString(id);

            var client = new Client()
            {
                Id = id,
                Name = name,
                WorkCollection = workColl
            };

            return client;
        }
    }
}