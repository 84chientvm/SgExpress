using Logictics.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logictics.Service.ViewModel {

    public class OrderEditViewModel {
        public Order orderTbl { get; set; }

        public List<OrderDetail> listDetailTbl { get; set; }

        public User Sender { get; set; }

        public User Recipient { get; set; }

        public Store store { get; set; }

        public List<CategoryProduct> listCategoryTbl { get; set; }
    }
}