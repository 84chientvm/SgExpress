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

    public interface IOrderDetailRepo : IRepo<OrderDetail>
    {
        IQueryable<OrderDetail> GetListByOrderId(string orderId);
    }
    public class OrderDetailRepo : Repo<OrderDetail>, IOrderDetailRepo
    {

        public OrderDetailRepo(DbContextOptions<LogicticsDbContext> options) : base(options)
        {

        }

        public IQueryable<OrderDetail> GetListByOrderId(string orderId)
        {
            return Table.Where(x => x.orderId == orderId);
        }
    }
}
