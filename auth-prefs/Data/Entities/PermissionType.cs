namespace authprefs.Data.Entities
{
    public class PermissionType : BaseEntity
    {
        public long? ParentTypeId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
    }
}
