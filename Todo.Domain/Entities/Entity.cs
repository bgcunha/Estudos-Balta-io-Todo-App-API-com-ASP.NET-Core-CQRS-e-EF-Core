namespace Todo.Domain.Entities;

public abstract class Entity : IComparable<Entity>
{
    public Entity()
    {
        Id = Guid.NewGuid();
    }

    public Guid Id { get; private set; }

    public int CompareTo(Entity? other) => Id.CompareTo(other.Id);
    
}