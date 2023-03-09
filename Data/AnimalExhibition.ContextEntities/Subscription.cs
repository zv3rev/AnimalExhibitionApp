namespace AnimalExhibition.ContextEntities
{
    public class Subscription:BaseEntity
    {
        public long UserId { get; set; }
        public virtual User User { get; set; }
        public long ExhibitionId { get; set; }
        public virtual Exhibition Exhibition { get; set; }
    }
}
