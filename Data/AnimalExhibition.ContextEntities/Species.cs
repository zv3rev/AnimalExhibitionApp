using System.ComponentModel.DataAnnotations;

namespace AnimalExhibition.ContextEntities
{
    public class Species
    {
        [Key]
        public long Id { get; set; }   
        public string Name { get; set; }
        public virtual ICollection<Species> Specieses { get; set; }
    }
}
