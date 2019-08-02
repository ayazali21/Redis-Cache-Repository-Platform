using StackExchange.Redis;
using System;
using Platform.Redis.Interfaces;

namespace Platform.Redis.Infrastructure
{
    public class RepositoryContext : IRepositoryContext
    {
        #region PrivateMembers
        private const string OBJECT_CONTEXT_KEY = "TCIG.ElastiCache.Redis.Entities";
        private IContextManager _contextManager = null;
        #endregion

        #region Constructor
        public RepositoryContext(IContextManager contextManager)
        {
            _contextManager = contextManager ?? throw new ArgumentNullException(nameof(contextManager));
        }
        #endregion

        #region Methods
        /// <summary>
        /// Returns the active object context
        /// </summary>
        public ConnectionMultiplexer ObjectContext
        {
            get
            {
                return _contextManager.GetDbContext(OBJECT_CONTEXT_KEY);
            }
        }

        public void Terminate()
        {
            try
            {
                _contextManager.SetRepositoryContext(null, OBJECT_CONTEXT_KEY);
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }
        #endregion
    }
}
