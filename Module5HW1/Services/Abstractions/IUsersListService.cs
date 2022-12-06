using Module5HW1.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5HW1.Services.Abstractions
{
    internal interface IUsersListService
    {
        Task<List<UserDto>> GetUsersList(int pageNumber);
        Task<List<UnknownDto>> GetUnknownList();
    }
}
