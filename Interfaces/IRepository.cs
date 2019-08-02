using StackExchange.Redis;
using System.Collections.Generic;

namespace Platform.Redis.Interfaces
{
    /// <summary>
    /// The generic interface that abstractly defines 
    /// the behavior of all the repositories of our system. 
    /// This is the super repository. This is what extends 
    /// to create the abstract repository with the name 'RepositoryBase<T>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<TKey, TValue> : IDictionary<TKey, TValue>
    {
       
        IDatabase GetDataBase();
        void Add(TKey key, TValue value);
        void Add(TKey key, TValue value, int ExpiryinMinutes);
        bool ContainsKey(TKey key);
        bool Remove(TKey key);
        bool TryGetValue(TKey key, out TValue value);
        bool TryGetKeyValue(TKey key, out TValue value);
        ICollection<TKey> Keys { get; }
        TValue this[TKey key] { get; set; }
        void Add(KeyValuePair<TKey, TValue> item);
        void Clear();
        bool Contains(KeyValuePair<TKey, TValue> item);
        void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex);
        int Count { get; }
        bool IsReadOnly { get; }
        bool Remove(KeyValuePair<TKey, TValue> item);
        IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator();
        void AddMultiple(IEnumerable<KeyValuePair<TKey, TValue>> items);
    }
}
