using apiEspacoLiz.Data;
using apiEspacoLiz.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace apiEspacoLiz.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _dataContext;
        public UserRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public Users Login(Users user)
        {
            try
            {
                return _dataContext.Users.FirstOrDefault(u => u.Id == user.Id);
            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
