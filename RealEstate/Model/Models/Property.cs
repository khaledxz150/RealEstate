//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApp2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Property
    {
        public int PropertyID { get; set; }
        public string PropertyName { get; set; }
        public int StatusID { get; set; }
        public int TypeID { get; set; }
        public int StartingPrice { get; set; }
        public int LayoutID { get; set; }
        public int OwnerID { get; set; }
        public int AddressID { get; set; }
        public string Description { get; set; }
    
        public virtual Address Address { get; set; }
        public virtual Layout Layout { get; set; }
        public virtual Owner Owner { get; set; }
        public virtual Status Status { get; set; }
        public virtual Type Type { get; set; }
    }
}
