using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForumApp.Models
{
    public class DislikePost
    {
        public int ID { get; set; }

        public User DislikePostUser { get; set; }

        public Post DislikePostPost { get; set; }
    }
}
