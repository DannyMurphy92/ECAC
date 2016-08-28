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
            return View();
        }
        #endregion

        #region Private Methods
        private CourseModel GetCourseModel(int typeId, int courseId)
        {
            var model = new CourseModel();
            switch (typeId)
            {
                case (int)TrainingType.Refrigeration:
                {
                    switch (courseId)
                    {
                        case (int) Refrigeration.Intro:
                        {
                            model.Intro =
                                @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque placerat lacinia ornare. Phasellus venenatis placerat nisl non auctor. Aenean bibendum et nisi quis sodales. Duis scelerisque est et ante consequat, vel sollicitudin nibh aliquet. Mauris ac neque tellus. Curabitur convallis dignissim risus, ac suscipit nisi elementum at. In hac habitasse platea dictumst. Proin egestas, est at auctor vestibulum, lectus sem imperdiet elit, at aliquet nunc diam et ex.";
                            model.Details =
                                @"Ut pharetra scelerisque augue vel ultrices. Fusce nec risus volutpat, ornare felis nec, scelerisque magna. Sed ultrices euismod consequat. Sed suscipit dui id urna sodales dignissim. Curabitur eget libero rhoncus, rhoncus lectus sed, malesuada metus. Mauris sit amet elit in arcu auctor rutrum sed consequat justo. Duis quis condimentum enim, nec suscipit magna. Pellentesque pretium massa dui, quis vestibulum quam imperdiet vel. Donec laoreet ipsum lorem. Cras pellentesque magna in leo posuere, et consequat massa porttitor. Vestibulum eu lectus orci. Vestibulum scelerisque, leo ac vehicula mollis, felis sem vulputate velit, et pulvinar nisl est a ex. Integer pharetra ultricies ornare.";
                            model.HeaderImgLocation = @"";
                            break;
                        }
                        case (int) Refrigeration.Advanced:
                        {
                            model.Intro =
                                @"Proin augue felis, ullamcorper et nulla quis, semper maximus justo. Vivamus sodales ex in tellus iaculis, vel pulvinar libero hendrerit. Nulla vitae euismod nunc. Quisque ac diam finibus, fringilla elit in, accumsan felis. Sed rutrum leo vitae leo placerat sagittis. Sed malesuada neque id velit facilisis auctor sed ut quam. Aliquam sed diam eu neque sollicitudin egestas. Vivamus non pulvinar ex. Donec sit amet gravida diam. Duis vitae tincidunt mauris, sit amet suscipit ligula. Integer volutpat viverra arcu, sed hendrerit felis sollicitudin eu. Aenean semper, urna id lacinia porttitor, leo ligula dictum tellus, et scelerisque mauris risus ac purus. Interdum et malesuada fames ac ante ipsum primis in faucibus.";
                            model.Details =
                                @"Etiam consequat, ex et ullamcorper tincidunt, ex nibh lacinia est, ac vulputate tortor quam in ante. Nunc tincidunt accumsan tortor eget ultrices. Morbi elementum iaculis leo eu suscipit. Morbi eget nisi eget quam pellentesque gravida non ac mauris. Nullam dignissim dolor eu magna lobortis commodo. Quisque eu malesuada lorem. Phasellus in enim pretium, cursus nisl quis, vehicula lorem. Donec nec feugiat odio. In hac habitasse platea dictumst.";
                            model.HeaderImgLocation = @"";
                            break;
                        }
                        case (int)Refrigeration.Ammonia:
                        {
                            model.Intro =
                                @"Proin augue felis, ullamcorper et nulla quis, semper maximus justo. Vivamus sodales ex in tellus iaculis, vel pulvinar libero hendrerit. Nulla vitae euismod nunc. Quisque ac diam finibus, fringilla elit in, accumsan felis. Sed rutrum leo vitae leo placerat sagittis. Sed malesuada neque id velit facilisis auctor sed ut quam. Aliquam sed diam eu neque sollicitudin egestas. Vivamus non pulvinar ex. Donec sit amet gravida diam. Duis vitae tincidunt mauris, sit amet suscipit ligula. Integer volutpat viverra arcu, sed hendrerit felis sollicitudin eu. Aenean semper, urna id lacinia porttitor, leo ligula dictum tellus, et scelerisque mauris risus ac purus. Interdum et malesuada fames ac ante ipsum primis in faucibus.";
                            model.Details =
                                @"Etiam consequat, ex et ullamcorper tincidunt, ex nibh lacinia est, ac vulputate tortor quam in ante. Nunc tincidunt accumsan tortor eget ultrices. Morbi elementum iaculis leo eu suscipit. Morbi eget nisi eget quam pellentesque gravida non ac mauris. Nullam dignissim dolor eu magna lobortis commodo. Quisque eu malesuada lorem. Phasellus in enim pretium, cursus nisl quis, vehicula lorem. Donec nec feugiat odio. In hac habitasse platea dictumst.";
                            model.HeaderImgLocation = @"";
                            break;
                        }
                    case (int)Refrigeration.Liquid:
                        {
                            model.Intro =
                                @"Proin augue felis, ullamcorper et nulla quis, semper maximus justo. Vivamus sodales ex in tellus iaculis, vel pulvinar libero hendrerit. Nulla vitae euismod nunc. Quisque ac diam finibus, fringilla elit in, accumsan felis. Sed rutrum leo vitae leo placerat sagittis. Sed malesuada neque id velit facilisis auctor sed ut quam. Aliquam sed diam eu neque sollicitudin egestas. Vivamus non pulvinar ex. Donec sit amet gravida diam. Duis vitae tincidunt mauris, sit amet suscipit ligula. Integer volutpat viverra arcu, sed hendrerit felis sollicitudin eu. Aenean semper, urna id lacinia porttitor, leo ligula dictum tellus, et scelerisque mauris risus ac purus. Interdum et malesuada fames ac ante ipsum primis in faucibus.";
                            model.Details =
                                @"Etiam consequat, ex et ullamcorper tincidunt, ex nibh lacinia est, ac vulputate tortor quam in ante. Nunc tincidunt accumsan tortor eget ultrices. Morbi elementum iaculis leo eu suscipit. Morbi eget nisi eget quam pellentesque gravida non ac mauris. Nullam dignissim dolor eu magna lobortis commodo. Quisque eu malesuada lorem. Phasellus in enim pretium, cursus nisl quis, vehicula lorem. Donec nec feugiat odio. In hac habitasse platea dictumst.";
                            model.HeaderImgLocation = @"";
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
                                    model.Intro =
                                        @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque placerat lacinia ornare. Phasellus venenatis placerat nisl non auctor. Aenean bibendum et nisi quis sodales. Duis scelerisque est et ante consequat, vel sollicitudin nibh aliquet. Mauris ac neque tellus. Curabitur convallis dignissim risus, ac suscipit nisi elementum at. In hac habitasse platea dictumst. Proin egestas, est at auctor vestibulum, lectus sem imperdiet elit, at aliquet nunc diam et ex.";
                                    model.Details =
                                        @"Ut pharetra scelerisque augue vel ultrices. Fusce nec risus volutpat, ornare felis nec, scelerisque magna. Sed ultrices euismod consequat. Sed suscipit dui id urna sodales dignissim. Curabitur eget libero rhoncus, rhoncus lectus sed, malesuada metus. Mauris sit amet elit in arcu auctor rutrum sed consequat justo. Duis quis condimentum enim, nec suscipit magna. Pellentesque pretium massa dui, quis vestibulum quam imperdiet vel. Donec laoreet ipsum lorem. Cras pellentesque magna in leo posuere, et consequat massa porttitor. Vestibulum eu lectus orci. Vestibulum scelerisque, leo ac vehicula mollis, felis sem vulputate velit, et pulvinar nisl est a ex. Integer pharetra ultricies ornare.";
                                    model.HeaderImgLocation = @"";
                                    break;
                                }
                            case (int)HVAC.Advanced:
                                {
                                    model.Intro =
                                        @"Proin augue felis, ullamcorper et nulla quis, semper maximus justo. Vivamus sodales ex in tellus iaculis, vel pulvinar libero hendrerit. Nulla vitae euismod nunc. Quisque ac diam finibus, fringilla elit in, accumsan felis. Sed rutrum leo vitae leo placerat sagittis. Sed malesuada neque id velit facilisis auctor sed ut quam. Aliquam sed diam eu neque sollicitudin egestas. Vivamus non pulvinar ex. Donec sit amet gravida diam. Duis vitae tincidunt mauris, sit amet suscipit ligula. Integer volutpat viverra arcu, sed hendrerit felis sollicitudin eu. Aenean semper, urna id lacinia porttitor, leo ligula dictum tellus, et scelerisque mauris risus ac purus. Interdum et malesuada fames ac ante ipsum primis in faucibus.";
                                    model.Details =
                                        @"Etiam consequat, ex et ullamcorper tincidunt, ex nibh lacinia est, ac vulputate tortor quam in ante. Nunc tincidunt accumsan tortor eget ultrices. Morbi elementum iaculis leo eu suscipit. Morbi eget nisi eget quam pellentesque gravida non ac mauris. Nullam dignissim dolor eu magna lobortis commodo. Quisque eu malesuada lorem. Phasellus in enim pretium, cursus nisl quis, vehicula lorem. Donec nec feugiat odio. In hac habitasse platea dictumst.";
                                    model.HeaderImgLocation = @"";
                                    break;
                                }
                            case (int)HVAC.ChilledWater:
                                {
                                    model.Intro =
                                        @"Proin augue felis, ullamcorper et nulla quis, semper maximus justo. Vivamus sodales ex in tellus iaculis, vel pulvinar libero hendrerit. Nulla vitae euismod nunc. Quisque ac diam finibus, fringilla elit in, accumsan felis. Sed rutrum leo vitae leo placerat sagittis. Sed malesuada neque id velit facilisis auctor sed ut quam. Aliquam sed diam eu neque sollicitudin egestas. Vivamus non pulvinar ex. Donec sit amet gravida diam. Duis vitae tincidunt mauris, sit amet suscipit ligula. Integer volutpat viverra arcu, sed hendrerit felis sollicitudin eu. Aenean semper, urna id lacinia porttitor, leo ligula dictum tellus, et scelerisque mauris risus ac purus. Interdum et malesuada fames ac ante ipsum primis in faucibus.";
                                    model.Details =
                                        @"Etiam consequat, ex et ullamcorper tincidunt, ex nibh lacinia est, ac vulputate tortor quam in ante. Nunc tincidunt accumsan tortor eget ultrices. Morbi elementum iaculis leo eu suscipit. Morbi eget nisi eget quam pellentesque gravida non ac mauris. Nullam dignissim dolor eu magna lobortis commodo. Quisque eu malesuada lorem. Phasellus in enim pretium, cursus nisl quis, vehicula lorem. Donec nec feugiat odio. In hac habitasse platea dictumst.";
                                    model.HeaderImgLocation = @"";
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
                                    model.Intro =
                                        @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque placerat lacinia ornare. Phasellus venenatis placerat nisl non auctor. Aenean bibendum et nisi quis sodales. Duis scelerisque est et ante consequat, vel sollicitudin nibh aliquet. Mauris ac neque tellus. Curabitur convallis dignissim risus, ac suscipit nisi elementum at. In hac habitasse platea dictumst. Proin egestas, est at auctor vestibulum, lectus sem imperdiet elit, at aliquet nunc diam et ex.";
                                    model.Details =
                                        @"Ut pharetra scelerisque augue vel ultrices. Fusce nec risus volutpat, ornare felis nec, scelerisque magna. Sed ultrices euismod consequat. Sed suscipit dui id urna sodales dignissim. Curabitur eget libero rhoncus, rhoncus lectus sed, malesuada metus. Mauris sit amet elit in arcu auctor rutrum sed consequat justo. Duis quis condimentum enim, nec suscipit magna. Pellentesque pretium massa dui, quis vestibulum quam imperdiet vel. Donec laoreet ipsum lorem. Cras pellentesque magna in leo posuere, et consequat massa porttitor. Vestibulum eu lectus orci. Vestibulum scelerisque, leo ac vehicula mollis, felis sem vulputate velit, et pulvinar nisl est a ex. Integer pharetra ultricies ornare.";
                                    model.HeaderImgLocation = @"";
                                    break;
                                }
                            case (int)FGas.Cat1:
                                {
                                    model.Intro =
                                        @"Proin augue felis, ullamcorper et nulla quis, semper maximus justo. Vivamus sodales ex in tellus iaculis, vel pulvinar libero hendrerit. Nulla vitae euismod nunc. Quisque ac diam finibus, fringilla elit in, accumsan felis. Sed rutrum leo vitae leo placerat sagittis. Sed malesuada neque id velit facilisis auctor sed ut quam. Aliquam sed diam eu neque sollicitudin egestas. Vivamus non pulvinar ex. Donec sit amet gravida diam. Duis vitae tincidunt mauris, sit amet suscipit ligula. Integer volutpat viverra arcu, sed hendrerit felis sollicitudin eu. Aenean semper, urna id lacinia porttitor, leo ligula dictum tellus, et scelerisque mauris risus ac purus. Interdum et malesuada fames ac ante ipsum primis in faucibus.";
                                    model.Details =
                                        @"Etiam consequat, ex et ullamcorper tincidunt, ex nibh lacinia est, ac vulputate tortor quam in ante. Nunc tincidunt accumsan tortor eget ultrices. Morbi elementum iaculis leo eu suscipit. Morbi eget nisi eget quam pellentesque gravida non ac mauris. Nullam dignissim dolor eu magna lobortis commodo. Quisque eu malesuada lorem. Phasellus in enim pretium, cursus nisl quis, vehicula lorem. Donec nec feugiat odio. In hac habitasse platea dictumst.";
                                    model.HeaderImgLocation = @"";
                                    break;
                                }
                            case (int)FGas.Cat4:
                                {
                                    model.Intro =
                                        @"Proin augue felis, ullamcorper et nulla quis, semper maximus justo. Vivamus sodales ex in tellus iaculis, vel pulvinar libero hendrerit. Nulla vitae euismod nunc. Quisque ac diam finibus, fringilla elit in, accumsan felis. Sed rutrum leo vitae leo placerat sagittis. Sed malesuada neque id velit facilisis auctor sed ut quam. Aliquam sed diam eu neque sollicitudin egestas. Vivamus non pulvinar ex. Donec sit amet gravida diam. Duis vitae tincidunt mauris, sit amet suscipit ligula. Integer volutpat viverra arcu, sed hendrerit felis sollicitudin eu. Aenean semper, urna id lacinia porttitor, leo ligula dictum tellus, et scelerisque mauris risus ac purus. Interdum et malesuada fames ac ante ipsum primis in faucibus.";
                                    model.Details =
                                        @"Etiam consequat, ex et ullamcorper tincidunt, ex nibh lacinia est, ac vulputate tortor quam in ante. Nunc tincidunt accumsan tortor eget ultrices. Morbi elementum iaculis leo eu suscipit. Morbi eget nisi eget quam pellentesque gravida non ac mauris. Nullam dignissim dolor eu magna lobortis commodo. Quisque eu malesuada lorem. Phasellus in enim pretium, cursus nisl quis, vehicula lorem. Donec nec feugiat odio. In hac habitasse platea dictumst.";
                                    model.HeaderImgLocation = @"";
                                    break;
                                }
                        }
                        break;
                    }
            }

            return model;
        }
        #endregion
    }
}