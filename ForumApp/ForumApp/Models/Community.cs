using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ForumApp.Models
{
    public class Community
    {
        public int ID { get; set; }
        public string Name { get; set; }

        //fk
        //[JsonIgnore]
        //public List<Like_Post> Posts { get; set; }
    }
}
