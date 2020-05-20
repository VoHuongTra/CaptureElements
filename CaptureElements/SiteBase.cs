using CaptureElements.Models;
using CaptureElements.Models.Google;
using CaptureElements.Models.Youtube;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace CaptureElements
{
    public class SiteBase
    {
        private HttpClient _httpClient;
        private const string CHROME_API_URL = "http://localhost:11111/api/";
        protected TabInfo _tabInfo { get; set; }
        public SiteBase()
        {

            _httpClient = new HttpClient();
            _tabInfo = new TabInfo();
        }

        public Site GetSite(int tabId)
        {
            var url = CHROME_API_URL + "get-site/" + tabId.ToString();
            HttpResponseMessage response;
            try
            {
                response = _httpClient.GetAsync(url).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error when getting site of tab id '{tabId}'" + ex.Message);
            }

            if (response?.StatusCode == System.Net.HttpStatusCode.OK)
            {
                Site site = new Site();
                try
                {
                    var result = response?.Content?.ReadAsStringAsync()?.GetAwaiter().GetResult();
                    site = JsonConvert.DeserializeObject<Site>(result);
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error when getting site of tab id '{tabId}'" + ex.Message);
                }
                return site;
            }
            else
            {
                throw new Exception($"Error when getting site of tab id '{tabId}'" + response?.Content?.ReadAsStringAsync()?.GetAwaiter().GetResult());
            }
        }
        public int GetTabId(int? tabIndex)
        {
            var url = CHROME_API_URL + "get-tab-id/" + (tabIndex == null ? "" : tabIndex.ToString());
            HttpResponseMessage response = null;
            try
            {
                response = _httpClient.GetAsync(url).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error when getting tab id of {(tabIndex == null ? "active tab" : $"tab index '{tabIndex}'")}" + ex.Message);
            }

            if (response?.StatusCode == System.Net.HttpStatusCode.OK)
            {
                int id;
                try
                {
                    var result = response?.Content?.ReadAsStringAsync()?.GetAwaiter().GetResult();
                    id = int.Parse(result);
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error when getting tab id of {(tabIndex == null ? "active tab" : $"tab index '{tabIndex}'")}" + ex.Message);
                }

                return id;
            }
            else
            {
                throw new Exception($"Error when getting tab id of {(tabIndex == null ? "active tab" : $"tab index '{tabIndex}'")}" + response?.Content?.ReadAsStringAsync()?.GetAwaiter().GetResult());
            }
        }
    }
}
