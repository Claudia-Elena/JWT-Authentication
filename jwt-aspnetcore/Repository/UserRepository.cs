﻿using JWTASPNetCore.Interfaces;
using JWTASPNetCore.Models;
using System.Collections.Generic;
using System.Linq;

namespace JWTASPNetCore.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly List<UserDTO> users = new List<UserDTO>();
        public UserRepository()
        {
            users.Add(new UserDTO { UserName = "draghiciandreea", Password = "draghi123", Role = "manager" });
            users.Add(new UserDTO { UserName = "diaconescurazvan", Password = "razvan321", Role = "developer" });
            users.Add(new UserDTO { UserName = "ciontuclaudia", Password = "clau123", Role = "tester" });
            users.Add(new UserDTO { UserName = "rodpaddock", Password = "rod123", Role = "admin" });
            users.Add(new UserDTO { UserName = "admin", Password = "admin321", Role = "admin" });
        }
        public UserDTO GetUser(UserModel userModel)
        {
            return users.Where(x => x.UserName.ToLower() == userModel.UserName.ToLower()
                && x.Password == userModel.Password).FirstOrDefault();
        }
    }
}
