using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForumApp.Models
{
    public class LikePost
    {
        public int ID { get; set; }

        public User LikePostUser { get; set; }

        public Post LikePostPost { get; set; }
    }
}
