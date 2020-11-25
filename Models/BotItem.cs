using System;

namespace Auction.Models
{
    public class BotItem : IEntityBase
    {
        public Guid Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public bool IsActive { get; set; }
        public Guid BotId { get; set; }
        public Guid ItemId { get; set; }

        public virtual Bot Bot { get; set; }
        public virtual Item Item { get; set; }
    }
}