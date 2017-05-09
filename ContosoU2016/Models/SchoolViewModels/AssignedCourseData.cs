using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoU2016.Models.SchoolViewModels
{
    public class AssignedCourseData
    {
        /*
         * To provide a list of couse checkboxes with Course id and title as well as an indicator
         * that the instructor is assigned or not assigned to a particular course, we are creating this
         * ViewModle class
         */

        public int CourseID { get; set; } //FOr the CourseID
        public string Title { get; set; }// For the Course Title
        public bool Assigned { get; set; }// For (

    }
}
