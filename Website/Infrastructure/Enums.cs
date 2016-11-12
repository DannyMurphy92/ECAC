using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Website.Infrastructure
{
    public enum TrainingType
    {
        Refrigeration = 1,
        HVAC = 2,
        FGas = 3,
        CustomTraining = 4
    }
    public enum Refrigeration
    {
        [Display(Name= "Introduction to Refrigeration")]
        Intro = 1,
        [Display(Name = "Advanced Refrigeration Maintenance and Fault Finding")]
        Advanced = 2,
        [Display(Name = "Ammonia Safety Workshop")]
        Ammonia = 3,
        [Display(Name = "Liquid Overfeed Systems")]
        Liquid = 4,

    }

    public enum HVAC
    {
        [Display(Name = "Introduction to  HVAC Systems")]
        Intro = 1,
        [Display(Name = "Advanced HVAC and Process Cooling Systems")]
        Advanced = 2
    }

    public enum FGas
    {
        [Display(Name = "Overview of F-Gas")]
        Overview = 1,
        [Display(Name = "Intensive F-Gas")]
        Intensive = 2,
        [Display(Name = "F-Gas Category 1")]
        Cat1 = 3,
        [Display(Name = "F-Gas Category 2")]
        Cat2 = 4,
        [Display(Name = "F-Gas Category 3")]
        Cat3 = 5,
        [Display(Name = "F-Gas Category 4")]
        Cat4 = 6,
    }

    public enum CustomCourse
    {
        [Display(Name = "Facilities HVAC and Cat. 4 F Gas Certification")]
        FacilityHVAC = 1,
    }

    public enum Service
    {
        [Display(Name = "Tailored Training Design")]
        Bespoke = 1,
        [Display(Name = "Career Services")]
        Career = 2,
        //[Display(Name = "Translation Services")]
        //Technical = 3
        //[Display(Name = "تدريب التبريد والتكييف في الشرق الأوسط")]
        //Arabic = 4
    }
}