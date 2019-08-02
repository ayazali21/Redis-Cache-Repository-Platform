using System;
using System.Collections.Generic;

namespace Platform.Redis.Interfaces
{
    public interface IService<TKey, TValue> : IDisposable
    {
        /// <summary>
        /// Get a selected extiry by the object primary key ID
        /// </summary>
        /// <param name="id">Primary key ID</param>
        void Add(TKey key, TValue value);
        void Add(TKey key, TValue value, int ExpiryinMinutes);
        bool ContainsKey(TKey key);
        bool Remove(TKey key);
        bool TryGetValue(TKey key, out TValue value);
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
