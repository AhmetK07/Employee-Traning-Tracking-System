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
    
    public partial class Department
    {
        public Department()
        {
            this.Managers = new HashSet<Manager>();
            this.Priviliges = new HashSet<Privilige>();
        }
    
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public int ManagerId { get; set; }
        public int InstructorId { get; set; }
    
        public virtual Instructor Instructor { get; set; }
        public virtual Department Department1 { get; set; }
        public virtual Department Department2 { get; set; }
        public virtual ICollection<Manager> Managers { get; set; }
        public virtual ICollection<Privilige> Priviliges { get; set; }
    }
}
