using Module5HW1.Dtos.Responses;
using Module5HW1.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5HW1.Services.Abstractions
{
    internal interface IUserService
    {
        Task<UserDto> GetUserById(int id);
        Task<UserResponse> CreateUser(string name, string job);
        Task<UserResponse> UpdateUser(string name, string job, int id);
        Task<bool> DeliteUser(int id);
    }
}
