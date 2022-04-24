using System.Collections.Generic;

namespace authprefs.Data.Entities
{
    public class Role : BaseEntity
    {
        public string Name { get; set; }
        public string NormalizedName { get; set; }

        public ICollection<UserRole> UserRoles { get; set; }
    }
}
