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
    
    public partial class comment
    {
        public int id { get; set; }
        public Nullable<int> post_id { get; set; }
        public string user_id { get; set; }
        public string body { get; set; }
        public Nullable<System.DateTime> timestamp { get; set; }
        public int likes_number { get; set; }
        public int replies_number { get; set; }

        public IEnumerable<reply> comment_replies { get; set; }
        public virtual AspNetUser AspNetUser { get; set; }
    }
}
