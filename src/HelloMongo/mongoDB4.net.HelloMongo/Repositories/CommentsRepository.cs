using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Driver;
using mongoDB4.net.HelloMongo.Models;

namespace mongoDB4.net.HelloMongo.Repositories
{
    public class CommentsRepository : ICommentsRepository
    {
        #region Member Vars
        
        private readonly string _connectionString;
        private MongoCollection<Comment> _defaultCollection; 

        #endregion

        #region Constructors
        
        public CommentsRepository(string connectionString)
        {
            _connectionString = connectionString;
            _defaultCollection = null;
        } 

        #endregion

        #region Public Methods

        public Comment Save(Comment comment)
        {
            DefaultCollection.Save(comment);
            return comment;
        }

        public IEnumerable<Comment> GetAll()
        {
            return DefaultCollection.FindAll();
        }
        
        public MongoCollection<Comment> DefaultCollection
        {
            get
            {
                if (_defaultCollection == null)
                {
                    var mongoClient = new MongoClient(_connectionString);
                    var mongoServer = mongoClient.GetServer();
                    var mongoDatabase = mongoServer.GetDatabase("helloMongo");
                    _defaultCollection = mongoDatabase.GetCollection<Comment>("comments");
                }

                return _defaultCollection;
            }
        }
        
        #endregion
    }
}