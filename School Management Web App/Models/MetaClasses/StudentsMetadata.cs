using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace School_Management_Web_App.Models
{
    public class StudentsMetadata
    {
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }


        [StringLength(50)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [StringLength(50)]
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }

        [Display(Name = "Date of Enrollment")]
        public Nullable<System.DateTime> EnrollmentDate { get; set; }

        [Display(Name = "Date of Birth")]
        public Nullable<System.DateTime> DateOfBirth { get; set; }

    }

    [MetadataType(typeof(StudentsMetadata))]
    public partial class Student { }

}