
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Practica.Collections;

    public class ContextoMongo
    {
        
            public IMongoDatabase database;
            public ContextoMongo()
            {
                var connectionString = Practica.Properties.Settings.Default.mongoConnection;
                var client = new MongoClient(connectionString);
                database = client.GetDatabase(Practica.Properties.Settings.Default.databaseName);
      
            }

            public IMongoCollection<Clientes> Clientes
            {
                get
                {
                    return (database.GetCollection<Clientes>("Cliente"));
                }
                set
                {
                }
            }

        
    }
