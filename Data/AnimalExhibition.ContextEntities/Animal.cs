namespace AnimalExhibition.ContextEntities
{
    public class Animal :BaseEntity
    {
        public long OwnerId { get; set; }
        public virtual User User { get; set; }
        public string Nickname { get; set; }  
        public byte Age { get; set; } 
        public long BreedId { get; set; }
        public virtual Breed Breed { get; set; }
        public virtual ICollection<Exhibition> Exhibitions { get; set; }


    }
}
