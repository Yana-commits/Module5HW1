using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Module5HW1.Config;
using Module5HW1.Dtos.Requests;
using Module5HW1.Dtos.Responses;
using Module5HW1.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Module5HW1.Services
{
    internal class RegisterService : IRegisterService
    {
        private readonly IInternalHttpClientService _httpClientService;
        private readonly ILogger<RegisterService> _logger;
        private readonly ApiOption _options;
        private readonly string _userRegisterApi = "api/register";

        public RegisterService(
            IInternalHttpClientService httpClientService,
            IOptions<ApiOption> options,
            ILogger<RegisterService> logger)
        {
            _httpClientService = httpClientService;
            _logger = logger;
            _options = options.Value;
        }
        public async Task<RegisterResponse> RegisterUser(string email, string password = null!)
        {
            var result = await _httpClientService.SendAsync<RegisterResponse, RegisterRequest>(
                $"{_options.Host}{_userRegisterApi}",
                HttpMethod.Post,
                 new RegisterRequest()
                 {
                     Email = email,
                     Password = password
                 }
                );
               
            if (result != null)
            {
                _logger.LogInformation($"User with id = {result?.Id} was registered");
            }

            return result;
        }
       
    }
}
