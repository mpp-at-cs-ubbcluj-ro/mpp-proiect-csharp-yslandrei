namespace mpp.repository;

public interface Repository<T, Tid>
{
    void Add(T elem);
    void Delete(T elem);
    void Update(T elem, Tid id);
    T FindById(Tid id);
    IEnumerable<T> FindAll();
    ICollection<T> GetAll();
}