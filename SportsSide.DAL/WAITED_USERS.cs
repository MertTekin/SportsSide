//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SportsSide.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class WAITED_USERS
    {
        public int WU_ID { get; set; }
        public int USER_ID { get; set; }
        public Nullable<int> RESERVATION_ID { get; set; }
        public Nullable<int> INVITE_USER { get; set; }
        public string WU_STATUS { get; set; }
    
        public virtual RESERVATION RESERVATION { get; set; }
        public virtual USERS USERS { get; set; }
        public virtual USERS USERS1 { get; set; }
    }
}
