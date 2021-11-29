namespace Autopark.Models.Entities
{
    public interface IEntity
    {
        int ID { get; set; }
        bool Deleted { get; set; }
    }
}
