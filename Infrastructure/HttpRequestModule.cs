using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;
using Platform.Redis.Interfaces;

namespace Platform.Redis.Infrastructure
{
    public class HttpRequestModule 
    {
        #region PrivateMembers
        private readonly RequestDelegate _requestDelegate;
        private readonly IRepositoryContext _repositoryContext;
        #endregion

        #region Constructor
        public HttpRequestModule(RequestDelegate requestDelegate, IRepositoryContext repositoryContext)
        {
            _requestDelegate = requestDelegate ?? throw new ArgumentNullException(nameof(requestDelegate));
            _repositoryContext = repositoryContext ?? throw new ArgumentNullException(nameof(repositoryContext));
        }
        #endregion

        #region Methods
        public async Task Invoke(HttpContext context)
        {
            // Do something with context near the beginning of request processing.
            try
            {
                this.BeginInvoke(context);
                await _requestDelegate.Invoke(context);
                this.EndInvoke(context);
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        private void BeginInvoke(HttpContext context)
        {
            //HTTP Application_Begin Request
        }
        private void EndInvoke(HttpContext context)
        {
            try
            {
                //disposing the connection
                _repositoryContext.Terminate();
            }
            catch (System.Exception ex)
            {

                throw ex;
            }
           
        }
        #endregion
    }
}

