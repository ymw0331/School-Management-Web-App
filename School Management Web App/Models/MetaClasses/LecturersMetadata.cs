using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace School_Management_Web_App.Models
{
    public class LecturersMetadata
    {
        [StringLength(50)]
        [Display(Name = "First Name")]
        public string First_Name { get; set; }

        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string Last_Name { get; set; }

    }


    [MetadataType(typeof(LecturersMetadata))]
    public partial class Lecturer{}



}