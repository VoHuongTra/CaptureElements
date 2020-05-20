using CaptureElements.Models;
using CaptureElements.Models.Elements;
using CaptureElements.Models.Google;
using CaptureElements.Models.Google.Account;
using CaptureElements.Models.Google.Search;
using CaptureElements.Models.Google.Translate;
using CaptureElements.Models.Youtube;
using CaptureElements.Models.Youtube.Guide;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;
using System.Text;

namespace CaptureElements
{
    public static class TaskManager
    {
        public static void Action(int tabIndex)
        {
            try
            {
                var filePath = @"E:\CaptureElement";
                if (!Directory.Exists(filePath))
                {
                    Directory.CreateDirectory(filePath);
                }
                SiteBase siteBase = new SiteBase();
                var tabId = siteBase.GetTabId(tabIndex);
                var site = siteBase.GetSite(tabId);
                if (site.SiteType == SiteType.Google)
                {
                    var path = Path.Combine(filePath, "Google");
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    var siteModelStr = site?.SiteModel?.ToString();
                    var googleModel = JsonConvert.DeserializeObject<GoogleModel>(siteModelStr);
                    if (googleModel == null)
                    {
                        throw new Exception("Google model null");
                    }
                    else
                    {
                        Google(googleModel);
                    }
                }
                else if (site.SiteType == SiteType.Youtube)
                {
                    var siteModelStr = site?.SiteModel?.ToString();
                    var youtubeModel = JsonConvert.DeserializeObject<YoutubeModel>(siteModelStr);
                    var path = Path.Combine(filePath, "Youtube");
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    if (youtubeModel == null)
                    {
                        throw new Exception("Youtube model null");
                    }
                    else
                    {
                        Youtube(youtubeModel);
                    }
                }
                else
                {
                    throw new Exception("Site type not correct");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static void CaptureAllElements(Object parent, string filePath, string inforName = null)
        {
            string path = filePath;
            CaptureElement captureEle = new CaptureElement();
            if (parent == null)
            {
                var element = GetBaseElement();
                var image = captureEle.CaptureEle(element);
                image.Save(path + inforName + "_NULL_" + ".jpg", ImageFormat.Jpeg);
            }
            else
            {
                Type types = parent.GetType();
                bool checks = typeof(BaseElement).IsAssignableFrom(types);
                if (types == typeof(string) || types == typeof(int) || types == typeof(bool) || types == typeof(Enum)
                    || types == typeof(Position) || types == typeof(CaptureElements.Models.Elements.Size))
                {
                    return;
                }
                if (checks)
                {
                    Position postion = parent.GetType().GetProperty("Position").GetValue(parent) as Position;
                    CaptureElements.Models.Elements.Size size = parent.GetType().GetProperty("Size").GetValue(parent) as CaptureElements.Models.Elements.Size;
                    var item = new BaseElement
                    {
                        Position = postion,
                        Size = size
                    };
                    if (postion != null && size != null)
                    {

                        string name = inforName == null ? parent.GetType().Name : inforName;
                        try
                        {
                            var image = captureEle.CaptureEle(item as BaseElement);
                            if(image!= null)
                            {
                                image.Save(path + name + ".jpg", ImageFormat.Jpeg);
                            }                          
                        }
                        catch (Exception ex)
                        {
                            throw new Exception("Error save image" + ex.Message);
                        }

                    }
                }
                PropertyInfo[] propertyInfos = parent.GetType().GetProperties();
                foreach (var infor in propertyInfos)
                {
                    var prop = infor.GetValue(parent);
                    var tyepValue = infor.PropertyType;
                    if (tyepValue == typeof(string) || tyepValue == typeof(int) || tyepValue == typeof(bool) || tyepValue == typeof(Enum)
                     || tyepValue == typeof(Position) || tyepValue == typeof(CaptureElements.Models.Elements.Size))
                    {
                        continue;
                    }
                    if (prop == null)
                    {
                        var element = GetBaseElement();
                        var image = captureEle.CaptureEle(element);
                        if (image != null)
                        {
                            image.Save(path + inforName + "_NULL_" + infor.Name + ".jpg", ImageFormat.Jpeg);
                        }
                           
                        continue;
                    }
                    if ((prop is IEnumerable) && infor.PropertyType.IsGenericType == true)
                    {
                        int count = 0;
                        foreach (var listitem in prop as IEnumerable)
                        {
                            Type itemType = listitem.GetType();
                            if (itemType != typeof(Button) && itemType != typeof(TextBox) && itemType != typeof(SwitchButton))
                            {
                                string name = inforName == null ? "" : inforName + "_";
                                CaptureAllElements(listitem, path, name + infor.Name + "_" + count.ToString());
                                count++;
                            }
                            else
                            {
                                bool check = typeof(BaseElement).IsAssignableFrom(itemType);
                                if (check)
                                {
                                    if (listitem != null)
                                    {
                                        try
                                        {
                                            var image = captureEle.CaptureEle(listitem as BaseElement);
                                            string name = inforName == null ? "" : inforName + "_";
                                            if(image != null)
                                            {
                                                image.Save(path + name + infor.Name + "_" + count.ToString() + ".jpg", ImageFormat.Jpeg);
                                            }                                           
                                            count++;
                                        }
                                        catch (Exception ex)
                                        {
                                            throw new Exception("Error when save image of item in list" + ex.Message);
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        Type typeItem = prop.GetType();
                        if (typeItem != typeof(Button) && typeItem != typeof(TextBox) && typeItem != typeof(SwitchButton))
                        {
                            string name = inforName == null ? "" : inforName + "_";
                            CaptureAllElements(infor.GetValue(parent), path, name + infor.Name);
                        }
                        else
                        {
                            bool checkBaseElement = typeof(BaseElement).IsAssignableFrom(typeItem);
                            if (checkBaseElement)
                            {
                                var element = prop as BaseElement;
                                if (element.Position != null && element.Size != null)
                                {
                                    try
                                    {
                                        var image = captureEle.CaptureEle(element);
                                        string name = inforName == null ? "" : inforName + "_";
                                        if(image!= null)
                                        {
                                            image.Save(path + name + infor.Name + ".jpg", ImageFormat.Jpeg);
                                        }
                                        
                                    }
                                    catch (Exception ex)
                                    {
                                        throw new Exception("Error when save image of item" + ex.Message);
                                    }

                                }
                            }

                        }

                    }

                }


            }
        }
        private static void Google(GoogleModel googleModel)
        {

            if (googleModel.GoogleAccount != null)
            {
                var filePath = @"E:\CaptureElement\Google\GoogleAccount\";
                if (!Directory.Exists(filePath))
                {
                    Directory.CreateDirectory(filePath);
                }

                CaptureAllElements(googleModel.GoogleAccount, filePath);

            }
            else if (googleModel.GoogleHome != null)
            {
                var filePath = @"E:\CaptureElement\Google\GoogleHome\";
                if (!Directory.Exists(filePath))
                {
                    Directory.CreateDirectory(filePath);
                }

                CaptureAllElements(googleModel.GoogleHome, filePath);

            }
            else if (googleModel.GoogleSearchResult != null)
            {
                var filePath = @"E:\CaptureElement\Google\GoogleSearchResult\";
                if (!Directory.Exists(filePath))
                {
                    Directory.CreateDirectory(filePath);
                }

                CaptureAllElements(googleModel.GoogleSearchResult, filePath);

            }
            else if (googleModel.GoogleTranslate != null)
            {
                var filePath = @"E:\CaptureElement\Google\GoogleTranslate\";
                if (!Directory.Exists(filePath))
                {
                    Directory.CreateDirectory(filePath);
                }

                CaptureAllElements(googleModel.GoogleTranslate, filePath);
            }
            else
            {
                throw new Exception("All properties of google model is null");
            }
        }
        private static void Youtube(YoutubeModel youtubeModel)
        {

            if (youtubeModel.Guide != null)
            {
                var filePath = @"E:\CaptureElement\Youtube\Guide\";
                if (!Directory.Exists(filePath))
                {
                    Directory.CreateDirectory(filePath);
                }
                //else
                //{
                //    string[] files = Directory.GetFiles(filePath);
                //    foreach(var file in files)
                //    {
                //        File.Delete(file);
                //    }
                //}

                CaptureAllElements(youtubeModel.Guide, filePath);

            }
            if (youtubeModel.Header != null)
            {
                var filePath = @"E:\CaptureElement\Youtube\Header\";
                if (!Directory.Exists(filePath))
                {
                    Directory.CreateDirectory(filePath);
                }
                CaptureAllElements(youtubeModel.Header, filePath);

            }
            if (youtubeModel.PageChannel != null)
            {
                var filePath = @"E:\CaptureElement\Youtube\PageChannel\";
                if (!Directory.Exists(filePath))
                {
                    Directory.CreateDirectory(filePath);
                }
                CaptureAllElements(youtubeModel.PageChannel, filePath);

            }
            if (youtubeModel.PageHome != null)
            {
                var filePath = @"E:\CaptureElement\Youtube\PageHome\";
                if (!Directory.Exists(filePath))
                {
                    Directory.CreateDirectory(filePath);
                }
                CaptureAllElements(youtubeModel.PageHome, filePath);

            }
            if (youtubeModel.PageHome != null)
            {
                var filePath = @"E:\CaptureElement\Youtube\PageHome\";
                if (!Directory.Exists(filePath))
                {
                    Directory.CreateDirectory(filePath);
                }

                CaptureAllElements(youtubeModel.PageHome, filePath);

            }
            if (youtubeModel.PageSearch != null)
            {
                var filePath = @"E:\CaptureElement\Youtube\PageSearch\";
                if (!Directory.Exists(filePath))
                {
                    Directory.CreateDirectory(filePath);
                }

                CaptureAllElements(youtubeModel.PageSearch, filePath);

            }
            if (youtubeModel.PageSubscription != null)
            {
                var filePath = @"E:\CaptureElement\Youtube\PageSubscription\";
                if (!Directory.Exists(filePath))
                {
                    Directory.CreateDirectory(filePath);
                }

                CaptureAllElements(youtubeModel.PageSubscription, filePath);

            }
            if (youtubeModel.PageTrending != null)
            {
                var filePath = @"E:\CaptureElement\Youtube\PageTrending\";
                if (!Directory.Exists(filePath))
                {
                    Directory.CreateDirectory(filePath);
                }

                CaptureAllElements(youtubeModel.PageTrending, filePath);

            }
            if (youtubeModel.PageWatching != null)
            {
                var filePath = @"E:\CaptureElement\Youtube\PageWatching\";
                if (!Directory.Exists(filePath))
                {
                    Directory.CreateDirectory(filePath);
                }


                CaptureAllElements(youtubeModel.PageWatching, filePath);
            }
        }
        public static BaseElement GetBaseElement()
        {
            int width = 10;
            int height = 10;
            int left = 0;
            int top = 0;
            Position position = new Position { Left = left, Top = top, RelatedToWindow = 0 };
            Size size = new Size { Height = height, Width = width };
            var item = new BaseElement { Position = position, Size = size };
            return item;
        }
    }
}

