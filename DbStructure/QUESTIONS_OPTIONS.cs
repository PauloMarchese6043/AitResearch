//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DbStructure
{
    using System;
    using System.Collections.Generic;
    
    public partial class QUESTIONS_OPTIONS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public QUESTIONS_OPTIONS()
        {
            this.ANSWERS = new HashSet<ANSWER>();
        }
    
        public int ID { get; set; }
        public string TEXT { get; set; }
        public int QUESTION_ID { get; set; }
        public Nullable<int> NEXT_QUESTION_ID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ANSWER> ANSWERS { get; set; }
        public virtual QUESTION QUESTION { get; set; }
        public virtual QUESTION QUESTION1 { get; set; }
    }
}
