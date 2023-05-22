namespace MvcApp.Models.Entities
{
    public class Entity
    {
        public Guid Id { get; set; }

        public Entity()
        {

        }
        public Entity(Guid id)
        {
            Id = id;
        }
    }
}
