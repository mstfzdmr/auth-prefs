namespace authprefs.Data.Entities
{
    public class Menu : BaseEntity
    {
        public long? ParentId { get; set; }
        public string PageName { get; set; }
        public string Alias { get; set; }
        public string IconClass { get; set; }
        public int Level { get; set; }
        public int DisplayOrder { get; set; }
        public bool IsVisible { get; set; }
    }
}
