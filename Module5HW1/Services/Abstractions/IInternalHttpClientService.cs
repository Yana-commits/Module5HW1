using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5HW1.Services.Abstractions
{
    internal interface IInternalHttpClientService
    {
        Task<TResponse> SendAsync<TResponse, TRequest>(string url, HttpMethod method, TRequest content = null)
        where TRequest : class;
    }
}
