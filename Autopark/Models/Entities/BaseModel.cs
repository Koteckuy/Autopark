namespace Autopark.Models.Entities
{
    public abstract class BaseModel : IEntity
    {
        public int ID { get; set; }
        public bool Deleted { get; set; }
    }
}
