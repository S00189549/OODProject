//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OOD_Project
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Workout
    {
        public int Id { get; set; }
        public int ExerciseID { get; set; }
        public System.DateTime SaveDate { get; set; }
        public int ProfileID { get; set; }
        public Nullable<int> Reps { get; set; }
        public Nullable<int> Sets { get; set; }
        public Nullable<bool> TUT { get; set; }
        public Nullable<bool> Pause { get; set; }
        public Nullable<bool> C1_5xReps { get; set; }
    
        public virtual tbl_Exercises tbl_Exercises { get; set; }
        public virtual tbl_Profiles tbl_Profiles { get; set; }
    }
}
