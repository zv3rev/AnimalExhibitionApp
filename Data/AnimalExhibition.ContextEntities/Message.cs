namespace AnimalExhibition.ContextEntities
{
    public class Message : BaseEntity
    {
        public long ReceiverId { get; set; }
        public virtual User User { get; set; }
        public long SenderId { get; set; }
        public virtual Exhibition? Exhibition { get; set; }
        public bool HasRead { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime SendingTime { get; set; }
    }
}
 