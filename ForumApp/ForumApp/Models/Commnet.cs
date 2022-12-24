using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForumApp.Models
{
    public class Commnet
    {
        public int ID { get; set; }
        
        public string Text { get; set; }
        public List<LikeComment> LikeComments { get; set; }
        public List<DislikeComment> DislikeComments { get; set; }

        public User CommentUser { get; set; }

        public Post CommentPost { get; set; }
    }
}
