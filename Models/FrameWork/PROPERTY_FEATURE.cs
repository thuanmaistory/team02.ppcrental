//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models.FrameWork
{
    using System;
    using System.Collections.Generic;
    
    public partial class PROPERTY_FEATURE
    {
        public int ID { get; set; }
        public Nullable<int> Property_ID { get; set; }
        public Nullable<int> Feature_ID { get; set; }
    
        public virtual FEATURE FEATURE { get; set; }
        public virtual PROPERTy PROPERTy { get; set; }
    }
}
