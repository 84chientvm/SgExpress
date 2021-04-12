using System;
using System.Collections.Generic;
using System.Text;

namespace Logictics.Entity.Models
{
    public class Order
    {
        public string Id { get; set; }
        public string StoreId { get; set; }
        public string StoreName { get; set; }
        public int TotalWeight { get; set; }
        public string Status { get; set; }
        public double? CreateDate { get; set; }
        public double? ModifyDate{ get; set; }
        public string SenderId { get; set; }
        public string SenderAddress { get; set; }
        public string SenderPhone { get; set; }
        public string SenderFullName { get; set; }
        public string RecipientId { get; set; }
        public string RecipientFullName { get; set; }
        public string RecipientAddress { get; set; }
        public string RecipientPhone { get; set; }
        public string CustomerConfirmId { get; set; }
        public string Notes { get; set; }
        public string Shipment { get; set; }
        public double? PickupDate { get; set; }
    }
}
