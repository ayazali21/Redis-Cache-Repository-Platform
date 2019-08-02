using Microsoft.Extensions.Configuration;
using System;
using Platform.Redis.Interfaces;

namespace Platform.Redis.Infrastructure
{
    public sealed class ApplicationConstants : IApplicationConstants
    {
        #region PrivateMembers
        private IConfiguration _configuration = null;
        #endregion

        #region Constructor
        public ApplicationConstants(IConfiguration configuration)
        {
            _configuration = configuration ?? throw new ArgumentException(nameof(configuration));
        }
        #endregion

        #region Public Properties
        public string ElastiCacheConnection => _configuration.GetConnectionString("ElastiCacheConnection") ?? "localhost:6379";
        public string ElastiCacheConnectionName => _configuration.GetConnectionString("ElastiCacheConnectionName") ?? "Unknown-APP";
        public int REDIS_HASHSET_EXPIRY_IN_MINUITES => Convert.ToInt32(_configuration.GetSection("AppSettings:REDIS_HASHSET_EXPIRY_IN_MINUITES").Value);
        public int MongoCacheExpireInMinutes => Convert.ToInt32(_configuration.GetSection("AppSettings:MongoCacheExpireInMinutes").Value);
        public int CacheTTL => Convert.ToInt32(_configuration.GetSection("AppSettings:CacheTTL").Value);
        public string LOCALE_SEPERATOR_CACHE_KEY => _configuration.GetSection("AppSettings:LOCALE_SEPERATOR_CACHE_KEY").Value;
        public string CACHE_KEY_SEPERATOR => _configuration.GetSection("AppSettings:CACHE_KEY_SEPERATOR").Value;

        public string ElastiCacheConnectionPassword => _configuration.GetConnectionString("ElastiCacheConnectionPassword") ?? "21995653348896897844";

        #endregion
    }
}
