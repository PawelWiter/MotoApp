namespace MotoApp.Repositories
{
    using MotoApp.Entities;
    public class EmployeeRepository<T>
    {
        private readonly List<T> _items = new();

        public void Add(T item)
        {
            item.Id = _item.Count+1;
            _items.Add(item);
        }

        public void Save()
        {
            foreach (var item in _items)
            {
                Console.WriteLine(item);
            }
        }

        public Employee GetById(int id) 
        {
            return _items.Single(item => item.Id == id);
        }
    }
}

