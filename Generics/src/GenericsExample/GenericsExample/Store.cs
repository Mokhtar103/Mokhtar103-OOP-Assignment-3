using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsExample
{
    public class Store <T> where T : IHasId
    {
        private readonly Dictionary<int, T> _entities = new Dictionary<int, T>();

        public void Add(T entity)
        {
            if (_entities.ContainsKey(entity.Id))
                throw new InvalidOperationException($"An item with Id '{entity.Id}' already exists in the store.");

            _entities.Add(entity.Id, entity);
        }

        public T? GetById(int id)
        {
            if (_entities.TryGetValue(id, out var entity))
                return entity;

            return default;
        }

        public IEnumerable<T> GetAll()
        {
            return _entities.Values;
        }

        public void Remove(int id)
        {
            _entities.Remove(id);
        }
    }
}
