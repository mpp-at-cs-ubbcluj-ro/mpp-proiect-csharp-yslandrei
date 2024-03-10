namespace mpp.domain;

public abstract class Entity<T>
{
    private T id;

    public Entity(T id)
    {
        this.id = id;
    }

    public T Id
    {
        get { return id; }
        set { id = value; }
    }
}
