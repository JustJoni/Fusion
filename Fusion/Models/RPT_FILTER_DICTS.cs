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
    
    public partial class RPT_FILTER_DICTS
    {
        public RPT_FILTER_DICTS()
        {
            this.RPT_REPORT_PARAMS = new HashSet<RPT_REPORT_PARAMS>();
        }
    
        public int UID { get; set; }
        public string PROVIDER_NAME { get; set; }
        public string SCRIPT { get; set; }
    
        public virtual ICollection<RPT_REPORT_PARAMS> RPT_REPORT_PARAMS { get; set; }
    }
}
