using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography.Xml;
using System.Threading.Tasks;



namespace EMF.Models
{
    public class VerseModel
    {
        
        public async Task<Rootobject> GetVersesAsync(string startDate, string numVerses)
        {
            //these values would ideally be stored in a config somewhere
            string url = "https://emfservicesstage-api.azure-api.net/bible/v1/getversesbydate?siteId=1";
            string headerKey = "Ocp-Apim-Subscription-Key";
            string headerValue = "d10161af8cf44f0c8267d571c682fda4";
            string urlParameters = "&startDate=" + startDate + "&PageSize=" + numVerses;
            var ro = new Rootobject();

            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(url);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Add(headerKey, headerValue );

                    using (var response = await client.GetAsync(url + urlParameters))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        ro = JsonConvert.DeserializeObject<Rootobject>(apiResponse);
                    }

                }
            }
            catch (Exception e)
            {
                var err = e.Message;
            }

            return ro;
        }

    }


    public class Rootobject
    {
        public Vers[] Verses { get; set; }
        public int PageSize { get; set; }
        public int PageNumber { get; set; }
        public bool HasMorePages { get; set; }
        public object Id { get; set; }
        public object Url { get; set; }
    }

    public class Vers
    {
        public string VerseText { get; set; }
        public string ImageLink { get; set; }
        public DateTime VerseDate { get; set; }
        public string VideoLink { get; set; }
        public string ReferenceLink { get; set; }
        public string VerseNumbers { get; set; }
        public string Chapter { get; set; }
        public string Book { get; set; }
        public string ReferenceText { get; set; }
        public string BibleReferenceLink { get; set; }
        public string FacebookShareUrl { get; set; }
        public string TwitterShareUrl { get; set; }
        public string PinterestShareUrl { get; set; }
        public bool IsValid { get; set; }
        public string Id { get; set; }
        public string Url { get; set; }
    }


}