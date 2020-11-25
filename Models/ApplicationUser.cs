using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Auction.Models
{
    public class ApplicationUser : IdentityUser
    {
        public virtual ICollection<Bot> Bots { get; set; }
        public virtual ICollection<Bid> Bids { get; set; }
    }
}
