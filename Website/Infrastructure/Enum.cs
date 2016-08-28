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
        [Display(Name = "Advanced HVAC Systems")]
        Advanced = 2,
        [Display(Name = "Chilled Water Systems and Process Cooling")]
        ChilledWater = 3,
    }

    public enum FGas
    {
        [Display(Name = "Overview of F Gas")]
        Overview = 1,
        [Display(Name = "F Gas Category 1 Training")]
        Cat1 = 2,
        [Display(Name = "F Gas Category 4 Training")]
        Cat4 = 3,
    }

    public enum Service
    {
        [Display(Name = "Bespoke Training Design")]
        Bespoke = 1,
        [Display(Name = "Employability Training Services")]
        Employability = 2,
        [Display(Name = "Technical Translation Services")]
        Technical = 2
    }
}