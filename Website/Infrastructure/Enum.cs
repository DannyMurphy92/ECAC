using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Website.Infrastructure
{
    
    public enum TrainingCourse
    {
        [Display(Name="Course 1")]
        Training1 = 1,
        [Display(Name = "Course 2")]
        Training2 = 2
    }
    
}