using System.ComponentModel.DataAnnotations;

namespace AnimalExhibition.ContextEntities
{
    public class Breed
    {
        [Key]
        public long Id { get; set; }  
        public string Name { get; set; }
        public long SpeciesID { get; set; }
        public virtual Species Species { get; set; }
        public virtual ICollection<Animal> Animals { get; set; }



    }
}
