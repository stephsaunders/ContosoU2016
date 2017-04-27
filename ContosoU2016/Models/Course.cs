using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoU2016.Models
{
    public class Course
    {
        /*you can turn off IDENTITY propery by using the DatabaseGeneratedOption.None
         * you have the following 3 options:
         *  Computed: Database generates a value when a row is inserted or updataed.
         *  Identity: Database generates a value when a row is inserted
         *  None: Database does not generate a value 
         *  
         *  IDENTITY (auto incrament) 
         *  
         */

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }//PK

        public string Title { get; set; }

        public int Credits { get; set; }

        // ================NAVIGATION PROPERTY================ //
        //1 course: many enrollments
        public virtual ICollection<Enrollment> Enrollment { get; set; }
    }
}