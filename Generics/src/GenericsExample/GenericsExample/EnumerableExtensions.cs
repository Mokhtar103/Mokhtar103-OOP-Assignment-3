using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsExample
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<T> Page<T>(this IEnumerable<T> items, int pageNumber, int pageSize)
        {
            if (items == null)
                throw new ArgumentNullException(nameof(items));
            if (pageNumber < 1)
                throw new ArgumentOutOfRangeException(nameof(pageNumber));
            if (pageSize < 1)
                throw new ArgumentOutOfRangeException(nameof(pageSize));

            int skipCount = (pageNumber - 1) * pageSize;
            int currentIndex = 0;
            int returnedCount = 0;

            foreach (var item in items)
            {
                if (currentIndex >= skipCount) 
                {
                    yield return item; 
                    returnedCount++;

                    if (returnedCount >= pageSize)
                    {
                        yield break;
                    }
                }
                currentIndex++;
            }
        }

        public static T? FindById<T>(this IEnumerable<T> items, int id) where T : IHasId
        {
            if (items == null)
                throw new ArgumentNullException(nameof(items));

            foreach (var item in items)
            {
                if (item.Id == id)
                    return item;
            }
            return default;
        }

        public static IReadOnlyDictionary<int, T> ToIdDictionary<T>(this IEnumerable<T> items) where T : IHasId
        {
            if (items == null)
                throw new ArgumentNullException(nameof(items));

            var itemsDictionary = new Dictionary<int, T>();

            foreach (var item in items)
            {
                itemsDictionary.Add(item.Id, item);
            }

            return itemsDictionary;

        }

    }
}
