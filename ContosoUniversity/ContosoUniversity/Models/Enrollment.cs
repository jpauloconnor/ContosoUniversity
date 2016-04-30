using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{ 
    public enum Grade
    {
        A, B, C, D, F
    }
    public class Enrollment
    {
        /// <summary>
        /// 1. EnrollementID - primary key column in db table. 
        ///     Differnt pattern than Student class "ID" to show possible variety. Pick one and stick with it.
        /// 
        /// 2. ? indicates that Grade prop is nullable.
        /// 
        /// 3. Virtual: We're calling these virtual to take advantage of lazy loading.
        /// 
        /// 4. StudentID is a foreign key. That key corresponds to the first Student in the Student property.
        ///       
        /// 5. Course and Student are navigation properties.
        ///   "navigation property name" "primary key prop name"
        ///                     Course      Course
        /// </summary>

        public int EnrollmentID { get; set; } //1
        public int CourseID { get; set; }
        public int StudentID { get; set; } //4
        public Grade? Grade { get; set; } //2

        //3
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }//4 & 5
    }
}