using System;
using System.Collections.Generic;

namespace Auction.Models
{
    public class Bot : IEntityBase
    {
        public Guid Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public bool IsActive { get; set; }
        public decimal Maximum { get; set; }
        public string UserId { get; set; }

        public virtual ICollection<BotItem> BotItems { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}