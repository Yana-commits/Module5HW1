using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Module5HW1.Config;
using Module5HW1.Dtos;
using Module5HW1.Dtos.Responses;
using Module5HW1.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5HW1.Services
{
    internal class UsersListService : IUsersListService
    {
        private readonly IInternalHttpClientService _httpClientService;
        private readonly ILogger<UserService> _logger;
        private readonly ApiOption _options;
        private readonly string _usersListApi = "api/users?page=";
        private readonly string _usersResourceApi = "api/unknown";


        public UsersListService(
            IInternalHttpClientService httpClientService,
            IOptions<ApiOption> options,
            ILogger<UserService> logger)
        {
            _httpClientService = httpClientService;
            _logger = logger;
            _options = options.Value;
        }
        public async Task<List<UserDto>> GetUsersList(int pageNumber)
        {
            var result = await _httpClientService.SendAsync<BaseResponse<List<UserDto>>, object>($"{_options.Host}{_usersListApi}{pageNumber}", HttpMethod.Get);

            if (result?.Data != null)
            {
                _logger.LogInformation($"Users on page {pageNumber} were found");
            }

            return result?.Data;
        }

        public async Task<List<UnknownDto>> GetUnknownList()
        {
            var result = await _httpClientService.SendAsync<BaseResponse<List<UnknownDto>>, object>($"{_options.Host}{_usersResourceApi}", HttpMethod.Get);

            if (result?.Data != null)
            {
                _logger.LogInformation($"Users on resource page were found");
            }

            return result?.Data;
        }
    }
}
