namespace ContosoU2016.Models
{

    //Grade enumeration
    public enum Grade      
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }//PK


        /*
         * The CourseID property is a foreign key, and the corresponding navigation property 
         * is Course. An Enrollment Entity is associated with one Course Entity
         */
        public int CourseID{ get; set; }//FK
        public int StudentID { get; set; }//FK

        /*
         * the StudentID property is a foreign key, and the corresponding navigation property 
         * is Student. An Enrollment entity is assosiated with one Student entity,
         * so the property can only hold a single Student entity.
         * 
         * Entity Framwore interprets a property as a foreign key property if it's named 
         * <navigation property name><primary key property name> for example:
         * StudentID for the Student navigation property, sine te Student entity's 
         * primary key is ID (Inherits from Person Entity ID Property in this class)
         * 
         * Foreign key properties can also be named <primary key property name> for example,
         * CourseID, since the Corse Entity's primary ke is CourceID 
         */

        public Grade? Grade { get; set; }  //  ? == nullable: because we do not start with a grade 




        // ================NAVIGATION PROPERTY================ //
        public virtual Course Course { get; set; }

        public virtual Student Student { get; set; }
        
    }
}