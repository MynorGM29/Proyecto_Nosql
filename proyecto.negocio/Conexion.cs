﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using System.Configuration;

namespace proyecto.negocio
{
    public class Conexion
    {

        private string _connStr;
        public MongoClient ConnectWithoutAuthentication()
        {
            _connStr = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
            string connectionString = _connStr;
            MongoClient client = new MongoClient(connectionString);
            return client;
        }

        public MongoClient ConnectWithAuthentication(string dbName = "ecommlight", string userName = "some_user", string password = "pwd", string servername = "localhost", int portnumber = 27017)
        {
            var credentials = MongoCredential.CreateCredential(dbName, userName, password);
            MongoClientSettings clientSettings = new MongoClientSettings()
            {
                Credentials = new[] { credentials
                },
                Server = new MongoServerAddress(servername, portnumber)
            };
            MongoClient client = new MongoClient(clientSettings);
            return client;
        }

        public MongoClient GetMongoClient(string hostName)
        {
            string connectionString = string.Format("mongodb://{0}:27017", hostName);
            return new MongoClient(connectionString);
        }

        public IMongoDatabase GetDatabaseReference(string hostName, string dbName)
        {
            MongoClient client = GetMongoClient(hostName);
            IMongoDatabase database = client.GetDatabase(dbName);
            return database;
        }

        public IMongoDatabase CreateDatabase(string hostName, string databaseName, string collectionName)
        {
            MongoClient client = GetMongoClient(hostName);
            IMongoDatabase database = client.GetDatabase(databaseName);
            database.CreateCollection(collectionName);
            return database;
        }

    }
}
