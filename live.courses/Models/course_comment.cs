//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace live.courses.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class course_comment
    {
        public int id { get; set; }
        public Nullable<int> course_id { get; set; }
        public string user_id { get; set; }
        public string body { get; set; }
        public Nullable<System.DateTime> timestamp { get; set; }
    
        public virtual course course { get; set; }
        public virtual AspNetUser AspNetUser { get; set; }
    }
}