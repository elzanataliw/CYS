//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CYS
{
    using System;
    using System.Collections.Generic;
    
    public partial class IngredientsLogic
    {
        public int Id { get; set; }
        public int ingredientsId { get; set; }
        public Nullable<bool> isPregnant { get; set; }
        public Nullable<bool> isUsingBHAetc { get; set; }
        public Nullable<bool> isUsingRetinol { get; set; }
        public string targetCondition { get; set; }
        public string skinWishCondition { get; set; }
    
        public virtual ingridient ingridient { get; set; }
    }
}