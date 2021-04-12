using Logictics.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logictics.Service.ViewModel
{
    public class OrderCreateModel
    {
        public string Id { get; set; } = "";
        public string StoreId { get; set; } = "";
        public string SenderId { get; set; } = "";
        public string SenderFullName { get; set; } = "";
        public string SenderAddress { get; set; } = "";
        public string SenderPhone { get; set; } = "";
        public string RecipientId { get; set; } = "";
        public string RecipientFullName { get; set; } = "";
        public string RecipientAddress { get; set; } = "";
        public string RecipientPhone { get; set; } = "";
        public int? TotalWeight { get; set; }
        public string Note { get; set; } = "";
        public string PickupDate { get; set; } = "";
        public string Shipment { get; set; } = "";
        public List<OrderDetail> listOrdertail { get; set; }
        public string status { get; set; }
    }
}
