//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ADMS
{
    using System;
    using System.Collections.Generic;
    
    public partial class EMPLOYER
    {
        public short E_ID { get; set; }
        public string E_NAME { get; set; }
        public string E_ADDRESS { get; set; }
        public string E_EMAIL { get; set; }
        public string E_WEBSITE { get; set; }
        public string E_PHONE { get; set; }
    
        public virtual E_USERS E_USERS { get; set; }
    }
}
