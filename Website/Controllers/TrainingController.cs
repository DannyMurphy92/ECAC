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
                            model.Content = Resources.Pages.REFRIG_INTRO;
                            break;
                        }
                        case (int) Refrigeration.Advanced:
                        {

                                model.Content = Resources.Pages.REFRIG_ADVANCED;
                                break;
                        }
                        case (int)Refrigeration.Ammonia:
                        {

                                model.Content = Resources.Pages.REFRIG_AMONIA;
                                break;
                        }
                    case (int)Refrigeration.Liquid:
                        {

                                model.Content = Resources.Pages.REFRIG_LIQUID;
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

                                    model.Content = Resources.Pages.HVAC_INTRO;
                                    break;
                                }
                            case (int)HVAC.Advanced:
                                {
                                    model.Content = Resources.Pages.HVAC_ADVANCED;
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

                                    model.Content = Resources.Pages.FGAS_OVERVIEW;
                                    break;
                            }
                            case (int)FGas.Cat1:
                            {

                                    model.Content = Resources.Pages.FGAS_CAT1;
                                    break;
                                }
                            case (int)FGas.Cat2:
                                {

                                    model.Content = Resources.Pages.FGAS_CAT2;
                                    break;
                                }
                            case (int)FGas.Cat3:
                                {

                                    model.Content = Resources.Pages.FGAS_CAT3;
                                    break;
                                }
                            case (int)FGas.Cat4:
                                {

                                    model.Content = Resources.Pages.FGAS_CAT4;
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
                    model.Content = Resources.Pages.BESPOKE_SERVICES;
                    break;
                    }
                case (int)Infrastructure.Service.Career:
                    {
                        model.Content = Resources.Pages.CAREER_SERVICES;
                        break;
                    }
            }

            return model;

        }
        #endregion
    }
}