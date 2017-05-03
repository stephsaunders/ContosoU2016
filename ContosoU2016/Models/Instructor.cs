using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoU2016.Models
{
    public class Instructor: Person
    {
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Hire Date")]
        public DateTime HireDate { get; set; }


        // ================NAVIGATION PROPERTY================ //
        /*
        public virtual ICollection<CourseAssignment> Courses { get; set; }
        public virtual OfficeAssignment OfficeAssignment MyProperty { get; set; }
        */

        /*
         * an instructor can teach any number of courses, so Courses is defined
         * 
         * 
         */
        public virtual ICollection<CourseAssignment> Courses { get; set; }

        /*
         * 
         * MISSING NOTES
         * 
         */
        public virtual OfficeAssignment OfficeAssignment { get; set; }
    }
}
