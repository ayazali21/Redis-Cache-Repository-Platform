using StackExchange.Redis;

namespace Platform.Redis.Interfaces
{
    public interface IRepositoryContext
    {
        /// <summary>
        /// Get Radis Db Context here
        /// </summary>
        ConnectionMultiplexer ObjectContext { get; }        
        
        /// <summary>
        /// Terminates the current repository context
        /// </summary>
        void Terminate();
    }
}
