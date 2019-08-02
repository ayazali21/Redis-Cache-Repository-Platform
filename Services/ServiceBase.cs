using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Platform.Redis.Interfaces;

namespace Platform.Redis.Services
{
    public abstract class ServiceBase<TKey, TValue> : IService<TKey, TValue>
    {
        #region Methods

        public string Serialize(object obj)
        {
            try
            {
                return JsonConvert.SerializeObject(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public T Deserialize<T>(string serialized)
        {
            try
            {
                return JsonConvert.DeserializeObject<T>(serialized);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void Add(TKey key, TValue value)
        {
            throw new NotImplementedException();
        }

        public void Add(TKey key, TValue value, int ExpiryinMinutes)
        {
            throw new NotImplementedException();
        }


        public bool ContainsKey(TKey key)
        {
            throw new NotImplementedException();
        }
        public bool Remove(TKey key)
        {
            throw new NotImplementedException();
        }
        public bool TryGetValue(TKey key, out TValue value)
        {
            throw new NotImplementedException();
        }
        public ICollection<TKey> Keys { get; }
        public TValue this[TKey key]
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
        public void Add(KeyValuePair<TKey, TValue> item)
        {
            throw new NotImplementedException();
        }
        public void Clear()
        {
            throw new NotImplementedException();
        }
        public bool Contains(KeyValuePair<TKey, TValue> item)
        {
            throw new NotImplementedException();
        }
        public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }
        public int Count
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        public bool IsReadOnly { get; }
        public bool Remove(KeyValuePair<TKey, TValue> item)
        {
            throw new NotImplementedException();
        }
        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            throw new NotImplementedException();
        }
        public void AddMultiple(IEnumerable<KeyValuePair<TKey, TValue>> items)
        {
            throw new NotImplementedException();
        }
        
        public void Dispose()
        {
            
        }
        #endregion

    }
}
