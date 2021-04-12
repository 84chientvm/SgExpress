using Logictics.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Common.Utils;
using System.Linq;
using Common.Provider;

namespace Logictics.Service.ViewModel
{
    public class OrderViewModel
    {
        public string Id { get; set; } = "";
        public double? TotalWeight { get; set; } = 0;
        public string Store { get; set; } = "";
        public string CustomerConfirm { get; set; } = "";
        public int NumberOfDOCS { get; set; } = 0;
        public string Notes { get; set; } = "";
        public string Shipment { get; set; } = "";

        public string SenderName { get; set; } = "";
        public string SenderAddress { get; set; } = "";
        public string SenderPhone { get; set; } = "";

        public string RecipientName { get; set; } = "";
        public string RecipientPhone { get; set; } = "";
        public string RecipientAddress { get; set; } = "";

        public string Status { get; set; } = "";
        public DateTime CreateDate { get; set; }
        public DateTime ModifyDate { get; set; }
        public DateTime PickupDate { get; set; }
    

        public bool MapOrderTblToOrderViewModel(Order order, Store store, User customer, IEnumerable<OrderDetail> orderDetail)
        {
            try
            {
                if (order == null)
                {
                    return false;
                }
                this.Id = order.Id;
                this.TotalWeight = order.TotalWeight;
                this.Store = store == null ? StringProvider.NOTFOUND :  store.Name;
                this.CustomerConfirm = customer == null ? "" : customer.FullName;
                this.NumberOfDOCS = orderDetail.Count();
                this.Notes = order.Notes;
                this.Shipment = order.Shipment;
                this.Status = order.Status;
                this.CreateDate = TimestampStaicClass.ConvertToDatetime(order.CreateDate);
                this.ModifyDate = TimestampStaicClass.ConvertToDatetime(order.ModifyDate);
                this.PickupDate = TimestampStaicClass.ConvertToDatetime(order.PickupDate).ToLocalTime();

                this.SenderName = order.SenderFullName == null ? StringProvider.NOTFOUND : order.SenderFullName;
                this.SenderAddress = order.SenderAddress == null ? StringProvider.NOTFOUND : order.SenderAddress;
                this.SenderPhone = order.SenderPhone == null ? StringProvider.NOTFOUND : order.SenderPhone;

                this.RecipientName = order.RecipientFullName == null ? StringProvider.NOTFOUND : order.RecipientFullName;
                this.RecipientPhone = order.RecipientPhone == null ? StringProvider.NOTFOUND : order.RecipientPhone;
                this.RecipientAddress = order.RecipientAddress == null ? StringProvider.NOTFOUND : order.RecipientAddress;
                return true;
            } catch (Exception e)
            {
                return false;
            }
        }
    }
}
