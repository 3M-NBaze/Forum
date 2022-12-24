using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForumApp.Models
{
    public class LikeComment
    {
        public int ID { get; set; }

        public Commnet CommnetLike { get; set; }

        public User CommentUser { get; set; }
    }
}
