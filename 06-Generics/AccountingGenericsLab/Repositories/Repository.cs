using AccountingGenericsLab.Models;

namespace AccountingGenericsLab.Repositories;

public class Repository<T>
    where T : IEntity
{
    private readonly List<T> _items = [];

    public void Add(T item)
    {
        _items.Add(item);
    }

    public T? GetById(int id)
    {
        return _items.FirstOrDefault(item => item.Id == id);
    }

    public IEnumerable<T> GetAll()
    {
        return _items;
    }

    public int Count()
    {
        return _items.Count;
    }
}