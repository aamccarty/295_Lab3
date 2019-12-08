using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityPage.Models
{
    public class UserReply
    {
            public int ReplyId { get; set; }
            public string CommentText { get; set; }
            public ContactInfo UserName { get; set; }
            public  ContactInfo UserMessage{ get; set; }

        internal List<UserReply> ToList()
        {
            throw new NotImplementedException();
        }
    }
    }

