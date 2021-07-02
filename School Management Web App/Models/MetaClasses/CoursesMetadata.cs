using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

//the namespace of partial class must refer to Models folder instead of MetaClasses folder, change it
namespace School_Management_Web_App.Models
{
    public class CoursesMetadata
    {
        [StringLength(50)]
        public string Title { get; set; }

        [Range(1, 8)]
        public int Credits { get; set; }
    }


    //associate with metaDataClass
    [MetadataType(typeof(CoursesMetadata))]
    public partial class Course { }

}