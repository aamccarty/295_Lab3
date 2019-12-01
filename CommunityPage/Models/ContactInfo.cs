using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace CommunityPage.Models
{
    public class ContactInfo 
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string UserMessage { get; set; }
        public UserReply Reply { get; set; }

        internal void Sort(Func<object, object, int> p)
        {
            throw new NotImplementedException();
        }

        internal List<MessageBoards> ToList()
        {
            throw new NotImplementedException();
        }
    }
}
