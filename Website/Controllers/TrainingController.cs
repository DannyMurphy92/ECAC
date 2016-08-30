using System.Web.Mvc;
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
        private TrainingModel GetCourseModel(int typeId, int courseId)
        {
            var model = new TrainingModel();
            switch (typeId)
            {
                case (int)TrainingType.Refrigeration:
                {
                    switch (courseId)
                    {
                        case (int) Refrigeration.Intro:
                        {
                            
                            break;
                        }
                        case (int) Refrigeration.Advanced:
                        {
                            break;
                        }
                        case (int)Refrigeration.Ammonia:
                        {
                            break;
                        }
                    case (int)Refrigeration.Liquid:
                        {
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
                                model.Title = Helper.GetResourceString(Constants.ResourceKeys.FGAS_OVERVIEW_TITLE);
                                model.Content = Helper.GetResourceString(Constants.ResourceKeys.FGAS_OVERVIEW_CONTENT);
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

        private TrainingModel GetServiceModel(int id)
        {
            var model = new TrainingModel();

            switch (id)
            {
                case (int)Infrastructure.Service.Bespoke:
                {
                    model.Title = Helper.GetResourceString(Constants.ResourceKeys.BESPOKE_SERVICES_TITLE);
                    model.Content = Helper.GetResourceString(Constants.ResourceKeys.BESPOKE_SERVICES_CONTENT);
                    break;
                    }
                case (int)Infrastructure.Service.Employability:
                    {
                        model.Title = Helper.GetResourceString(Constants.ResourceKeys.EMPLOYABILITY_SERVICES_TITLE);
                        model.Content = Helper.GetResourceString(Constants.ResourceKeys.EMPLOYABILITY_SERVICES_CONTENT);
                        break;
                    }
            }

            return model;

        }
        #endregion
    }
}