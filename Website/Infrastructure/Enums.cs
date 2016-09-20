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
        FGas = 3
    }
    public enum Refrigeration
    {
        [Display(Name= "Introduction to Refrigeration")]
        Intro = 1,
        [Display(Name = "Advanced Refrigeration Maintenance and Fault Finding")]
        Advanced = 2,
        [Display(Name = "Ammonia Safety Workshop")]
        Ammonia = 3,
        [Display(Name = "Liquid Sverfeed Systems")]
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
        [Display(Name = "Overview of F Gas")]
        Overview = 1,
        [Display(Name = "F Gas Category 1 Training")]
        Cat1 = 2,
        [Display(Name = "F Gas Category 2 Training")]
        Cat2 = 3,
        [Display(Name = "F Gas Category 3 Training")]
        Cat3 = 4,
        [Display(Name = "F Gas Category 4 Training")]
        Cat4 = 5,
    }

    public enum Service
    {
        [Display(Name = "Tailored Training Design")]
        Bespoke = 1,
        [Display(Name = "Career Services")]
        Employability = 2,
        [Display(Name = "Translation Services")]
        Technical = 3
    }
}