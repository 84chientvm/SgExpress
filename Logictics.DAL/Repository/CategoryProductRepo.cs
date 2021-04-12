using Logictics.DAL.EFContext;
using Logictics.DAL.Infrastructure;
using Logictics.Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logictics.DAL.Repository
{

    public interface ICategoryProductRepo : IRepo<CategoryProduct>
    { 
    }
    public class CategoryProductRepo : Repo<CategoryProduct>, ICategoryProductRepo
    {

        public CategoryProductRepo(DbContextOptions<LogicticsDbContext> options) : base(options)
        {

        }

    }
}
