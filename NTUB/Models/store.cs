//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace NTUB.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class store
    {
        public int StoreID { get; set; }
        public string Name { get; set; }
        public int ClassifyID { get; set; }
        public string Address { get; set; }
        public string AddressCity { get; set; }
        public string AddressDistrict { get; set; }
        public string Comment { get; set; }
        public Nullable<System.DateTime> ContractStartDate { get; set; }
        public Nullable<System.DateTime> ContractEndDate { get; set; }
        public Nullable<double> Latitude { get; set; }
        public Nullable<double> Longitude { get; set; }
        public string Telephone { get; set; }
        public string Mobile { get; set; }
    }
}