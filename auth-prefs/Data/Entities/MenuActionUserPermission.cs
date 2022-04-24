namespace authprefs.Data.Entities
{
    public class MenuActionUserPermission : BaseEntity
    {
        public long UserId { get; set; }
        public long MenuActionId { get; set; }

        public User User { get; set; }
        public MenuAction MenuAction { get; set; }
    }
}
