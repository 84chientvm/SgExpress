using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace Logictics.Service.ViewModel {

    public class SelectedOptionModel {
        public string key { get; set; }
        public string value { get; set; }
    }

    public class ListSelectOptionModel {
        public List<SelectedOptionModel> selectOption { get; set; }

        public SelectList CreateListSelectStatusOrder(string valueDefault) {
            this.selectOption = new List<SelectedOptionModel>();
            this.selectOption.Add(new SelectedOptionModel() { key = "Open", value = "Open" });
            this.selectOption.Add(new SelectedOptionModel() { key = "New", value = "New" });
            this.selectOption.Add(new SelectedOptionModel() { key = "PickedUp", value = "PickedUp" });
            this.selectOption.Add(new SelectedOptionModel() { key = "SendToVN", value = "SendToVN" });
            this.selectOption.Add(new SelectedOptionModel() { key = "ClearCustom", value = "ClearCustom" });
            this.selectOption.Add(new SelectedOptionModel() { key = "Delivering", value = "Delivering" });
            this.selectOption.Add(new SelectedOptionModel() { key = "Delivered", value = "Delivered" });
            this.selectOption.Add(new SelectedOptionModel() { key = "VNCancel", value = "VNCancel" });
            this.selectOption.Add(new SelectedOptionModel() { key = "ReturnToStore", value = "ReturnToStore" });
            this.selectOption.Add(new SelectedOptionModel() { key = "New - ReturnToStore", value = "New - ReturnToStore" });
            this.selectOption.Add(new SelectedOptionModel() { key = "CheckNote", value = "CheckNote" });
            this.selectOption.Add(new SelectedOptionModel() { key = "CustomerCancel", value = "CustomerCancel" });
            this.selectOption.Add(new SelectedOptionModel() { key = "StoreCancel", value = "StoreCancel" });
            this.selectOption.Add(new SelectedOptionModel() { key = "Processed", value = "Processed" });
            this.selectOption.Add(new SelectedOptionModel() { key = "Processing", value = "Processing" });
            this.selectOption.Add(new SelectedOptionModel() { key = "USCancel", value = "USCancel" });
            this.selectOption.Add(new SelectedOptionModel() { key = "Failed", value = "Failed" });
            this.selectOption.Add(new SelectedOptionModel() { key = "Pending", value = "Pending" });
            this.selectOption.Add(new SelectedOptionModel() { key = "Deleted", value = "Deleted" });
            return new SelectList(this.selectOption, "key", "value", valueDefault);
        }
    }
}