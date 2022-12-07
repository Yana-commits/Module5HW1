using Module5HW1.Dtos.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5HW1.Services.Abstractions
{
    internal interface IRegisterService
    {
        Task<RegisterResponse> RegisterUser(string email, string password);
      
    }
}
