using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;


namespace ForumApp.Models
{
    public class User
    {
       public int ID { get; set; }
        public string Username { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }

        //fk

        [JsonIgnore]
        public List<Post> Posts { get; set; }
        [JsonIgnore]
        public List<Community> Communities { get; set; }
    }
}
