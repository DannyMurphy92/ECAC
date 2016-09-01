using System.Web.Mvc;
using Website.Helpers;
using Website.Infrastructure;
using Website.Models;

namespace Website.Controllers
{
    public class TrainingController : Controller
    {
        #region Public Methods
        public ActionResult Course(int typeId, int courseId)
        {
            var model = GetCourseModel(typeId, courseId);
            return View(model);
        }

        public ActionResult Service(int id)
        {
            var model = GetServiceModel(id);
            return View(model);
        }
        #endregion

        #region Private Methods
        private CourseModel GetCourseModel(int typeId, int courseId)
        {
            var model = new CourseModel();
            model.Id = courseId;
            model.TypeId = typeId;
            switch (typeId)
            {
                case (int)TrainingType.Refrigeration:
                {
                    switch (courseId)
                    {
                        case (int) Refrigeration.Intro:
                        {
                            model.Title = ResourceStringHelper.GetResourceString(Constants.ResourceKeys.REFRIG_INTRO_TITLE);
                            model.Content = ResourceStringHelper.GetResourceString(Constants.ResourceKeys.REFRIG_INTRO_CONTENT);
                            break;
                        }
                        case (int) Refrigeration.Advanced:
                        {
                            model.Title = ResourceStringHelper.GetResourceString(Constants.ResourceKeys.REFRIG_ADVANCED_TITLE);
                            model.Content = ResourceStringHelper.GetResourceString(Constants.ResourceKeys.REFRIG_ADVANCED_CONTENT);
                            break;
                        }
                        case (int)Refrigeration.Ammonia:
                        {
                            model.Title = ResourceStringHelper.GetResourceString(Constants.ResourceKeys.REFRIG_AMMONIA_TITLE);
                            model.Content = ResourceStringHelper.GetResourceString(Constants.ResourceKeys.REFRIG_AMMONIA_CONTENT);
                            break;
                        }
                    case (int)Refrigeration.Liquid:
                        {
                            model.Title = ResourceStringHelper.GetResourceString(Constants.ResourceKeys.REFRIG_LIQUID_TITLE);
                            model.Content = ResourceStringHelper.GetResourceString(Constants.ResourceKeys.REFRIG_LIQUID_CONTENT);
                            break;
                        }
                    }
                    break;
                }
                case (int)TrainingType.HVAC:
                    {
                        switch (courseId)
                        {
                            case (int)HVAC.Intro:
                                {
                                    model.Title = ResourceStringHelper.GetResourceString(Constants.ResourceKeys.HVAC_INTRO_TITLE);
                                    model.Content = ResourceStringHelper.GetResourceString(Constants.ResourceKeys.HVAC_INTRO_CONTENT);
                                    break;
                                }
                            case (int)HVAC.Advanced:
                                {
                                    break;
                                }
                            case (int)HVAC.ChilledWater:
                                {
                                    break;
                                }
                        }
                        break;
                    }

                case (int)TrainingType.FGas:
                    {
                        switch (courseId)
                        {
                            case (int)FGas.Overview:
                            {
                                model.Title = ResourceStringHelper.GetResourceString(Constants.ResourceKeys.FGAS_OVERVIEW_TITLE);
                                model.Content = ResourceStringHelper.GetResourceString(Constants.ResourceKeys.FGAS_OVERVIEW_CONTENT);
                                model.Content = PlaceholderHelper.FgasOverviewPlaceholders(model.Content);
                                break;
                            }
                            case (int)FGas.Cat1:
                                {
                                    break;
                                }
                            case (int)FGas.Cat4:
                                {
                                    break;
                                }
                        }
                        break;
                    }
            }

            return model;
        }

        private ServiceModel GetServiceModel(int id)
        {
            var model = new ServiceModel();
            model.Id = id;
            switch (id)
            {
                case (int)Infrastructure.Service.Bespoke:
                {
                    model.Title = ResourceStringHelper.GetResourceString(Constants.ResourceKeys.BESPOKE_SERVICES_TITLE);
                    model.Content = ResourceStringHelper.GetResourceString(Constants.ResourceKeys.BESPOKE_SERVICES_CONTENT);
                    break;
                    }
                case (int)Infrastructure.Service.Employability:
                    {
                        model.Title = ResourceStringHelper.GetResourceString(Constants.ResourceKeys.EMPLOYABILITY_SERVICES_TITLE);
                        model.Content = ResourceStringHelper.GetResourceString(Constants.ResourceKeys.EMPLOYABILITY_SERVICES_CONTENT);
                        break;
                    }
            }

            return model;

        }
        #endregion
    }
}