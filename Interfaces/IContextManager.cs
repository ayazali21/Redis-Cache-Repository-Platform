using StackExchange.Redis;

namespace Platform.Redis.Interfaces
{
    public interface IContextManager
    {
        ConnectionMultiplexer GetDbContext(string contextKey);
        object GetRepositoryContext(string contextKey);
        void SetRepositoryContext(object repositoryContext, string contextKey);
    }
}
