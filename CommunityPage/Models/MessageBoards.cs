using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace CommunityPage.Models
{
    public class MessageBoards
    {
            public List<ContactInfo> contactInfos = new List<ContactInfo>();
            public List<UserReply> reply = new List<UserReply>();

            public string UserName { get; set; }
            public string UserMessage { get; set; }

            public ICollection<UserReply> UserReply { get { return reply; } }

        internal void Sort(Func<object, object, int> p)
        {
            throw new NotImplementedException();
        }
    }

    }

