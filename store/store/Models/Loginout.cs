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
    
    public partial class Loginout
    {
        public int Ioid { get; set; }
        public string LogID { get; set; }
        public string Kind { get; set; }
        public Nullable<System.DateTime> Logintime { get; set; }
        public Nullable<System.DateTime> Temptime { get; set; }
        public Nullable<System.DateTime> Logouttime { get; set; }
        public string StayTime { get; set; }
        public string IPAddr { get; set; }
        public string PageNo { get; set; }
        public bool Isflag { get; set; }
    }
}