
using System.ComponentModel.DataAnnotations;

namespace AnimalExhibition.ContextEntities
{
    public class Criteria
    {
        [Key]
        public long ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; } 
        public byte MaxScore { get; set; }
        public virtual ICollection<AnimalScore> Scores { get; set; }
        public virtual ICollection<Exhibition> Exhibitions { get; set; }

    }
}
