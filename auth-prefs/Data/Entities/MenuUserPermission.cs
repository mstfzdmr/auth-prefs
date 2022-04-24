namespace authprefs.Data.Entities
{
    public class MenuUserPermission : BaseEntity
    {
        public long UserId { get; set; }
        public long MenuId { get; set; }
        public bool HasPermission { get; set; }

        public User User { get; set; }
        public Menu Menu { get; set; }
    }
}
