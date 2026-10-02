using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsExample
{
    public class Store <T> where T : IHasId
    {
        private readonly List<T> _entities = new List<T>();

        public void Add(T entity)
        {
            _entities.Add(entity);
        }

        public T? GetById(int id)
        {
            foreach (var entity in _entities)
            {
                if (entity.Id == id)
                {
                    return entity;
                }
            }
            return default;
        }

        public IReadOnlyList<T> GetAll()
        {
            return _entities;
        }

        public void Remove(int id)
        {
            var entity = GetById(id);
            if (entity != null)
            {
                _entities.Remove(entity);
            }
        }
    }
}
