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
    
    public partial class Language
    {
        public Language()
        {
            this.Dictionaries = new HashSet<Dictionary>();
            this.Users = new HashSet<User>();
        }
    
        public int LangID { get; set; }
        public string LangName { get; set; }
    
        public virtual ICollection<Dictionary> Dictionaries { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}