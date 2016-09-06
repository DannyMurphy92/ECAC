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

            string title = "";
            string content = "";
            switch (typeId)
            {
                case (int)TrainingType.Refrigeration:
                {
                    switch (courseId)
                    {
                        case (int) Refrigeration.Intro:
                        {
                            title = ResourceStringHelper.GetResourceString(Constants.ResourceKeys.REFRIG_INTRO_TITLE);
                            content = ResourceStringHelper.GetResourceString(Constants.ResourceKeys.REFRIG_INTRO_CONTENT);
                            break;
                        }
                        case (int) Refrigeration.Advanced:
                        {
                            title = ResourceStringHelper.GetResourceString(Constants.ResourceKeys.REFRIG_ADVANCED_TITLE);
                            content = ResourceStringHelper.GetResourceString(Constants.ResourceKeys.REFRIG_ADVANCED_CONTENT);
                            break;
                        }
                        case (int)Refrigeration.Ammonia:
                        {
                            title = ResourceStringHelper.GetResourceString(Constants.ResourceKeys.REFRIG_AMMONIA_TITLE);
                            content = ResourceStringHelper.GetResourceString(Constants.ResourceKeys.REFRIG_AMMONIA_CONTENT);
                            break;
                        }
                    case (int)Refrigeration.Liquid:
                        {
                            title = ResourceStringHelper.GetResourceString(Constants.ResourceKeys.REFRIG_LIQUID_TITLE);
                            content = ResourceStringHelper.GetResourceString(Constants.ResourceKeys.REFRIG_LIQUID_CONTENT);
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
                                    title = ResourceStringHelper.GetResourceString(Constants.ResourceKeys.HVAC_INTRO_TITLE);
                                    content = ResourceStringHelper.GetResourceString(Constants.ResourceKeys.HVAC_INTRO_CONTENT);
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
                                title = ResourceStringHelper.GetResourceString(Constants.ResourceKeys.FGAS_OVERVIEW_TITLE);
                                content = ResourceStringHelper.GetResourceString(Constants.ResourceKeys.FGAS_OVERVIEW_CONTENT);
                                content = PlaceholderHelper.FgasOverviewPlaceholders(content);
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
            model.DesktopTitle = title;
            model.MobileTitle = title;
            model.DesktopContent = content;
            model.MobileContent = content;
            return model;
        }

        private ServiceModel GetServiceModel(int id)
        {
            var model = new ServiceModel();
            model.Id = id;

            string title = "";
            string content = "";
            switch (id)
            {
                case (int)Infrastructure.Service.Bespoke:
                {
                    title = ResourceStringHelper.GetResourceString(Constants.ResourceKeys.BESPOKE_SERVICES_TITLE);
                    content = ResourceStringHelper.GetResourceString(Constants.ResourceKeys.BESPOKE_SERVICES_CONTENT);
                    break;
                    }
                case (int)Infrastructure.Service.Employability:
                    {
                        title = ResourceStringHelper.GetResourceString(Constants.ResourceKeys.EMPLOYABILITY_SERVICES_TITLE);
                        content = ResourceStringHelper.GetResourceString(Constants.ResourceKeys.EMPLOYABILITY_SERVICES_CONTENT);
                        break;
                    }
            }

            model.DesktopTitle = title;
            model.MobileTitle = title;
            model.DesktopContent = content;
            model.MobileContent = content;
            return model;

        }
        #endregion
    }
}