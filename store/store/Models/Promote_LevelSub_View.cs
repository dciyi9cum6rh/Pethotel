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
    
    public partial class Promote_LevelSub_View
    {
        public long id { get; set; }
        public string pmid { get; set; }
        public int MLid { get; set; }
        public string Gift { get; set; }
        public Nullable<System.DateTime> UDate { get; set; }
        public string Esno { get; set; }
        public string Subject { get; set; }
        public string CupSubject { get; set; }
        public int UseDays { get; set; }
        public bool IsOnline { get; set; }
        public bool IsDel { get; set; }
        public string Contents { get; set; }
        public Nullable<double> basediscount { get; set; }
    }
}
