namespace AnimalExhibition.ContextEntities
{
    public class AnimalScore : BaseEntity
    {
        public long AnimalId { get; set; } 
        public virtual Animal Animal { get; set; }
        public long JudgeId { get; set; }
        public virtual User Judge { get; set; }
        public long ExhibitionID { get; set; }
        public virtual Exhibition Exhibition { get; set; }
        public long CriteriaID { get; set; }
        public virtual Criteria Criteria { get; set; }

        public byte Score {get; set; }
    }
}
