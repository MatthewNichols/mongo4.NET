using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace mongoDB4.net.HelloMongo.Models
{
    public class Comment
    {
        public Comment()
        {
            DateCreated = DateTime.Now;
        }

        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        [DisplayName("Comment")]
        public string CommentText { get; set; }

        [DisplayName("Date Created")]
        public DateTime DateCreated { get; set; }
    }
}