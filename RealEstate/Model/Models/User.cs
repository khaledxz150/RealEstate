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
    
    public partial class User
    {
        public User()
        {
            this.Owners = new HashSet<Owner>();
        }
    
        public int UserID { get; set; }
        public string UserFirstNameEng { get; set; }
        public string UserLastNameEng { get; set; }
        public string UserFirstNameAr { get; set; }
        public string UserLastNameAr { get; set; }
        public string UserEmail { get; set; }
        public string PhoneNumber { get; set; }
        public int LangID { get; set; }
    
        public virtual Language Language { get; set; }
        public virtual ICollection<Owner> Owners { get; set; }
    }
}
