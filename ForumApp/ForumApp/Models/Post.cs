using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ForumApp.Models
{
    public class Post
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }

        //fk

        //[JsonIgnore]
        //public List<Comment> Comments { get; set; }
        //public List<Like_Post> Likes {get; set;}
        //public List<Dislike_Post> Dislikes {get; set;}
        //public Topic Topic { get; set; }
        //public User User { get; set; }
    }
}
