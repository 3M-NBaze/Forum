using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForumApp.Models
{
    public class DislikeComment
    {
        public int ID { get; set; }
        public Commnet CommnetDislike { get; set; }

        public User CommentUser { get; set; }
    }
}
