//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace projectex
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class ITI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ITI()
        {
            this.Students = new HashSet<Student>();
        }
        [Key]
        public int ITI_Id { get; set; }
        public Nullable<int> Branch_Id { get; set; }
        public Nullable<int> Intake_Id { get; set; }
        public Nullable<int> Track_Id { get; set; }
    
        public virtual Branch Branch { get; set; }
        public virtual Intake Intake { get; set; }
        public virtual Track Track { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student> Students { get; set; }
    }
}
