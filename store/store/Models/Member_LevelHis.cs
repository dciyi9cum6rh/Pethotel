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
    
    public partial class Member_LevelHis
    {
        public long mlid { get; set; }
        public System.DateTime mlDate { get; set; }
        public string mlMidno { get; set; }
        public string mlKind { get; set; }
        public int mblid { get; set; }
        public System.DateTime mlSDate { get; set; }
        public System.DateTime mlEDate { get; set; }
        public double mlTgAmt { get; set; }
        public double mlNowAmt { get; set; }
        public string mlMemo { get; set; }
        public string mlEsno { get; set; }
        public System.DateTime mlUDate { get; set; }
        public bool Isflag { get; set; }
    }
}
