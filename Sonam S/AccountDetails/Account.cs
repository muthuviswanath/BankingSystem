//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccountDetails
{
    using System;
    using System.Collections.Generic;
    
    public partial class Account
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public Nullable<int> AccountNumber { get; set; }
        public string AccountType { get; set; }
        public Nullable<int> IFSC { get; set; }
        public Nullable<int> OpeningBalance { get; set; }
        public Nullable<int> MinimumBalance { get; set; }
        public string OD { get; set; }
        public string FD { get; set; }
    }
}