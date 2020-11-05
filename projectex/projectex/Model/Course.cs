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

    public partial class Course
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Course()
        {
            this.Exams = new HashSet<Exam>();
            this.Questions = new HashSet<Question>();
            this.Students_Course = new HashSet<Students_Course>();
        }
        [Key]
        public int Course_Id { get; set; }
        public string Course_Name { get; set; }
        public string Course_eDiscription { get; set; }
        public int Max_Degree { get; set; }
        public int Min_Degree { get; set; }
        public Nullable<int> Instructor_Id { get; set; }
        public Nullable<int> Track_Id { get; set; }
    
        public virtual Instructor Instructor { get; set; }
        public virtual Track Track { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Exam> Exams { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Question> Questions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Students_Course> Students_Course { get; set; }
    }
}
