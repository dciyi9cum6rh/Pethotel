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
    
    public partial class Depart
    {
        public int sdid { get; set; }
        public int DpID { get; set; }
        public string SortNO { get; set; }
        public string DKind { get; set; }
        public Nullable<System.DateTime> DDate { get; set; }
        public string DID { get; set; }
        public string BNOs { get; set; }
        public string area { get; set; }
        public string Name { get; set; }
        public string Memo { get; set; }
        public int SNO { get; set; }
        public string eSNO { get; set; }
        public string eSNO2 { get; set; }
        public Nullable<System.DateTime> Edate { get; set; }
        public string Ename { get; set; }
        public bool IsOnLine { get; set; }
        public bool IsChose { get; set; }
        public Nullable<bool> IsTop { get; set; }
        public bool IsAgt { get; set; }
        public string org_id { get; set; }
        public byte[] tt { get; set; }
        public bool IsUnCheck { get; set; }
        public string Company { get; set; }
        public string Company2 { get; set; }
        public string IVNO { get; set; }
        public string TaxNO { get; set; }
        public string TEL { get; set; }
        public string Addr { get; set; }
        public string Addr2 { get; set; }
        public bool IsIV { get; set; }
        public string IVtype { get; set; }
        public bool IsChIV { get; set; }
        public bool IsPrtIVok { get; set; }
        public bool IsSum { get; set; }
        public bool IsStocks { get; set; }
        public bool IsCashBox { get; set; }
        public string D_SpotKind { get; set; }
        public string D_Spot { get; set; }
        public bool Isflag { get; set; }
    }
}