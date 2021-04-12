using Logictics.DAL.EFContext;
using Logictics.DAL.Infrastructure;
using Logictics.Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logictics.DAL.Repository
{
    public interface IStoreRepo : IRepo<Store>
    {

    }
    public class StoreRepo : Repo<Store>, IStoreRepo
    {
        public StoreRepo(DbContextOptions<LogicticsDbContext> options) : base(options)
        {

        }
    }
}
