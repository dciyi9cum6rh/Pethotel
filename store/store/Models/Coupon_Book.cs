//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace store.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Coupon_Book
    {
        public int couid { get; set; }
        public System.DateTime NDate { get; set; }
        public string user_id { get; set; }
        public bool IsOut { get; set; }
        public bool IsUsed { get; set; }
        public string ApplyID { get; set; }
        public string couRemarks { get; set; }
        public Nullable<int> coid { get; set; }
        public Nullable<int> couDisNums { get; set; }
        public Nullable<System.DateTime> UseDate { get; set; }
        public string Midno { get; set; }
        public string eSNO { get; set; }
        public Nullable<System.DateTime> UDate { get; set; }
        public bool Isflag { get; set; }
    }
}
