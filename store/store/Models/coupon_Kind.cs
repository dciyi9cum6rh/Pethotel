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
    
    public partial class coupon_Kind
    {
        public int CKid { get; set; }
        public string CKName { get; set; }
        public Nullable<System.DateTime> CKDate { get; set; }
        public Nullable<int> Type { get; set; }
        public Nullable<bool> Online { get; set; }
        public Nullable<int> SortNo { get; set; }
        public Nullable<System.DateTime> UDate { get; set; }
        public string Esno { get; set; }
        public Nullable<bool> IsDel { get; set; }
        public bool Isflag { get; set; }
    }
}