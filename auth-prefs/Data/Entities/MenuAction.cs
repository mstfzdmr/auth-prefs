namespace authprefs.Data.Entities
{
    public class MenuAction : BaseEntity
    {
        public long MenuId { get; set; }
        public long PermissionTypeId { get; set; }
        public string Alias { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public string Description { get; set; }
        public int DisplayOrder { get; set; }
        public bool IsVisible { get; set; }

        public Menu Menu { get; set; }
        public PermissionType PermissionType { get; set; }
    }
}
