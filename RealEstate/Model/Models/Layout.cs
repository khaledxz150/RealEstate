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
    
    public partial class Layout
    {
        public Layout()
        {
            this.Properties = new HashSet<Property>();
        }
    
        public int LayoutID { get; set; }
        public int SquareFootage { get; set; }
        public int NoOfRooms { get; set; }
        public int NoOfBathRooms { get; set; }
        public Nullable<int> HasGarage { get; set; }
        public Nullable<int> HasPool { get; set; }
        public Nullable<int> HasBackyard { get; set; }
        public string ExtraFeature { get; set; }
    
        public virtual ICollection<Property> Properties { get; set; }
    }
}
