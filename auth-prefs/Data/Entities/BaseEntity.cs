using System;

namespace authprefs.Data.Entities
{
    public class BaseEntity
    {
        public long Id { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
