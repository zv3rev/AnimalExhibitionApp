namespace AnimalExhibition.ContextEntities
{
    public class Exhibition: BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public decimal Price { get; set; }
        //public long SpeciesID { get; set; } 
        //public virtual Species Species { get; set; }
        //public virtual ICollection<Criteria> Criterias { get; set; }
        //public virtual ICollection<Animal> Animals { get; set; }
        //public virtual ICollection<User> Judges{ get; set; }
        //public virtual ICollection<User> Subscribers { get; set; }
        //public virtual ICollection<Message> Messages { get; set; }
    }
}
