using Logictics.DAL.EFContext;
using Logictics.DAL.Infrastructure;
using Logictics.Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logictics.DAL.Repository
{
    public interface IUserRepo : IRepo<User>
    {
        IQueryable<User> GetUserByUserName(string userName, string password);

        //IEnumerable<UserAdmin> GetAllInclude();
        //UserAdmin GetInclude(int id);

    }
    public class UserRepo : Repo<User>, IUserRepo
    {

      

        public UserRepo(DbContextOptions<LogicticsDbContext> options) : base(options)
        {

        }

        public IQueryable<User> GetUserByUserName(string userName, string password)
        {
            return Table.Where(x => x.UserName == userName && x.PassWord == password);
        }
      
    }
}
