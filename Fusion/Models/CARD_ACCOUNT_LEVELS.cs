//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Fusion.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CARD_ACCOUNT_LEVELS
    {
        public int ACCOUNT_LEVEL_ID { get; set; }
        public string NAME { get; set; }
        public Nullable<short> DELETED { get; set; }
        public Nullable<System.DateTime> UPDATE_DATE { get; set; }
        public Nullable<int> ACCOUNT_TYPE_ID { get; set; }
        public short LEVEL_NO { get; set; }
        public Nullable<int> SCHEME_ID { get; set; }
        public Nullable<decimal> THRESHOLD { get; set; }
        public Nullable<int> THRESHOLD_ACCOUNT_TYPE_ID { get; set; }
        public Nullable<decimal> AMOUNT { get; set; }
        public Nullable<int> AMOUNT_ACCOUNT_TYPE_ID { get; set; }
        public Nullable<short> RANGE_TYPE { get; set; }
        public Nullable<int> RANGE_VALUE { get; set; }
        public Nullable<short> BLOCKED { get; set; }
        public System.Guid GUID { get; set; }
        public System.Guid TRANSACT_GUID { get; set; }
    }
}
