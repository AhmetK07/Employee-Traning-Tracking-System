//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _5001ProjectNew.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Course
    {
        public Course()
        {
            this.AbroadTrainings = new HashSet<AbroadTraining>();
            this.Employees = new HashSet<Employee>();
            this.Instructors = new HashSet<Instructor>();
            this.Reports = new HashSet<Report>();
            this.TrainingSponsors = new HashSet<TrainingSponsor>();
        }
    
        public int InsturctorId { get; set; }
        public string CourseName { get; set; }
        public int CourseCapacity { get; set; }
        public int CourseDuration_in_days_ { get; set; }
        public string TrainingLocation { get; set; }
        public Nullable<int> ApplianceCount { get; set; }
    
        public virtual ICollection<AbroadTraining> AbroadTrainings { get; set; }
        public virtual Instructor Instructor { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Instructor> Instructors { get; set; }
        public virtual ICollection<Report> Reports { get; set; }
        public virtual ICollection<TrainingSponsor> TrainingSponsors { get; set; }
    }
}
