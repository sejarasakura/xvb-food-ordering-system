﻿// ------------------------------------------------------------------------------
// <auto-generated>
// This code was generated from a template.
// 
// Manual changes to this file may cause unexpected behavior in your application.
// Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Collections.Generic;

namespace VisualBasicAssignment
{
    public partial class Catergory
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public virtual ICollection<Food> Foods { get; set; } = new HashSet<Food>();
    }
}