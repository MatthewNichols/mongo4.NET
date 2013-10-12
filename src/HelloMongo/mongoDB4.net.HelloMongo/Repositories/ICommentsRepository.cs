using System.Collections.Generic;
using mongoDB4.net.HelloMongo.Models;

namespace mongoDB4.net.HelloMongo.Repositories
{
    public interface ICommentsRepository
    {
        Comment Save(Comment comment);
        IEnumerable<Comment> GetAll();
    }
}