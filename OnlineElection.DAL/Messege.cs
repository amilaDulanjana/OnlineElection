//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineElection.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Messege
    {
        public int ID { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public Nullable<System.Guid> from { get; set; }
        public Nullable<System.Guid> to { get; set; }
        public string subject { get; set; }
        public string body { get; set; }
        public Nullable<int> read { get; set; }
    }
}
