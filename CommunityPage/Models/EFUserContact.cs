using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityPage.Models
{
    public class EFUserContact : IUserRepository
    {
        private ApplicationDbContext context;

        public EFUserContact(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<ContactInfo> Contacts => context.Contacts;
    }
}
