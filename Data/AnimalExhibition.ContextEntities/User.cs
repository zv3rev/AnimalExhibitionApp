namespace AnimalExhibition.ContextEntities;

public class User: BaseEntity
{
    public string Fio { get; set; }
    public virtual ICollection<Animal> Animals { get; set; }
    public virtual ICollection<Exhibition> Subsriptions { get; set; }
    public virtual ICollection<Message> Messages { get; set; }
    public virtual ICollection<Exhibition> JudgedExhibitions { get; set; }  

}

