using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public class Course
    {
        /// <summary>
        /// Enrollments is a navigation property. 
        /// Course can be related to any Enrollment entity.
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
