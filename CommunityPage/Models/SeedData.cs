using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityPage.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices
                .GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Contacts.Any())
            {
                context.Contacts.AddRange(
                    new ContactInfo
                    {
                        Name = "Bill",
                        Email = "numbone@gmail.com",
                        Phone = "555-555-5555",
                        UserMessage = "You're all going to lose."
                    }
                    
                );
                context.SaveChanges();
            }
        }
    }
}
