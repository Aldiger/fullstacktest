using System;
using System.ComponentModel.DataAnnotations;

namespace Auction.Models
{
    public class Bid : IEntityBase
    {
        public Guid Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public bool IsActive { get; set; }
        [Timestamp]
        public byte[] RowVersion { get; set; }
        public string UserId { get; set; }
        public Guid ItemId { get; set; }
        public virtual Item Item { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}