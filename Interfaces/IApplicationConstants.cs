namespace Platform.Redis.Interfaces
{
    public interface IApplicationConstants
    {
        string ElastiCacheConnection { get;}
        string ElastiCacheConnectionPassword { get; }
        string ElastiCacheConnectionName { get; }
        int REDIS_HASHSET_EXPIRY_IN_MINUITES { get; }
        int MongoCacheExpireInMinutes { get; }
        int CacheTTL { get; }
        string LOCALE_SEPERATOR_CACHE_KEY { get; }
        string CACHE_KEY_SEPERATOR { get; }
    }
}
