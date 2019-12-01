using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace CommunityPage.Models
{
    public static class Repository
    {
        private static List<ContactInfo> responses = new List<ContactInfo>();

        public static IEnumerable<ContactInfo> Responses
        {
            get
            {
                return responses;
            }
        }
        public static void AddResponse(ContactInfo response)
        {
            responses.Add(response);
        }
        
    }
}
