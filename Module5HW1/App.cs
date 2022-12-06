﻿using Module5HW1.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5HW1
{
    internal class App
    {
        private readonly IUserService _userService;
        private readonly IUsersListService _usersListService;
        public App(IUserService userService, IUsersListService usersListService)
        {
            _userService = userService;
            _usersListService = usersListService;
        }

        public async Task Start()
        {
            //var user = await _userService.GetUserById(2);
            var userInfo = await _userService.CreateUser("morpheus", "leader");
            //var users = await _usersListService.GetUsersList(2);
            //var resourceUsers = await _usersListService.GetUnknownList();
            var userUpdate = await _userService.UpdateUser("mmm","zion resident", 2);

            //var user = await _userService.GetMyUserById(userInfo.Id);

            var urerDeleted = await _userService.DeliteUser(2);
        }
    }
}
