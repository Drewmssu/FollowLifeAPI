﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace FollowLifeAPI.Helpers
{
    public static class ImageHelper
    {
        public static string GetImageURL(string fileName) => string.IsNullOrEmpty(fileName) ? null : HttpContext.Current.Server.MapPath("~\\Upload\\ProfileImages\\" + fileName);

        public static string UploadImage(HttpPostedFileBase file)
        {
            try
            {
                var extension = file.FileName.Split('.').Last();
                string[] allowedExtensions = { "JPG", "PNG" };

                if (!allowedExtensions.Contains(extension.ToUpper()))
                    return null;

                var basePath = HttpContext.Current.Server.MapPath("~\\Upload\\ProfileImages\\");
                var fileName = $"{Guid.NewGuid().ToString().Split('-')[1]}_{file.FileName}";
                var path = basePath + fileName;
                file.SaveAs(path);

                return fileName;
            }
            catch
            {
                return null;
            }
        }

        //public static string UploadImage(HttpPostedFileBase file)
        //{
        //    using (var client = new HttpClient())
        //    {
        //        var request = new HttpRequestMessage
        //        {
        //            RequestUri = new Uri(HttpContext.Current.Server.MapPath("~\\Upload\\ProfileImages\\")),
        //            Method = HttpMethod.Post,
        //            Content = new StreamContent(file.InputStream)
        //        };

        //        request.Content.Headers.ContentType = new MediaTypeHeaderValue(file.ContentType);

        //        using (var response = client.SendAsync(request).Result)
        //        {
        //            using (var content = response.Content)
        //            {
        //                return JsonConvert.DeserializeObject<string>(content.ReadAsStringAsync().Result);
        //            }
        //        }
        //    }
        //}

    }
}