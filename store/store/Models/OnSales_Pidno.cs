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
    
    public partial class OnSales_Pidno
    {
        public long sapid { get; set; }
        public long said { get; set; }
        public System.DateTime sapDate { get; set; }
        public int sapSNO { get; set; }
        public string sapPidno { get; set; }
        public double sapRate { get; set; }
        public int sapQty { get; set; }
        public int sapBuyQty { get; set; }
        public double sapPrice { get; set; }
        public string sapMemo { get; set; }
        public string Esno { get; set; }
        public System.DateTime UDate { get; set; }
        public bool Isflag { get; set; }
    }
}