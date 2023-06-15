using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using RestSharp;
using Newtonsoft.Json;

namespace VoyceCheckGooglePlay
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var client = new RestClient("https://store-apps.p.rapidapi.com/app-details?app_id=com.weyimobile.weyiandroid.weyiVoycecustomer&region=us&language=en");
            var request = new RestRequest();
            request.Method = Method.Get;
            request.AddHeader("X-RapidAPI-Key", "509c5182c1mshd4530463ca5d3fep12b82cjsn969a65423e3a");
            request.AddHeader("X-RapidAPI-Host", "store-apps.p.rapidapi.com");
            var response = client.Execute(request);
            GooglePlayResponseRoot myDeserializedClass = JsonConvert.DeserializeObject<GooglePlayResponseRoot>(response.Content);

            Console.Write(myDeserializedClass.ToString());
            Console.Write(myDeserializedClass.data[0].current_version);
        }
    }
    
    public class GooglePlayResponse
    {
        public string app_id { get; set; }
        public string app_name { get; set; }
        public string app_category { get; set; }
        public string app_developer { get; set; }
        public string num_downloads { get; set; }
        public string app_description { get; set; }
        public string app_page_link { get; set; }
        public int price { get; set; }
        public object price_currency { get; set; }
        public bool is_paid { get; set; }
        public object rating { get; set; }
        public List<string> photos { get; set; }
        public string app_icon { get; set; }
        public object trailer { get; set; }
        public int num_downloads_exact { get; set; }
        public string app_content_rating { get; set; }
        public object chart_label { get; set; }
        public object chart_rank { get; set; }
        public int app_updated_at_timestamp { get; set; }
        public DateTime app_updated_at_datetime_utc { get; set; }
        public object num_reviews { get; set; }
        public object reviews_per_rating { get; set; }
        public DateTime app_first_released_at_datetime_utc { get; set; }
        public int app_first_released_at_timestamp { get; set; }
        public string current_version { get; set; }
        public object current_version_released_at_timestamp { get; set; }
        public object current_version_released_at_datetime_utc { get; set; }
        public object current_version_whatsnew { get; set; }
        public object data_shared_by_app_and_why { get; set; }
        public object data_collected_by_app_and_why { get; set; }
        public object security_practices { get; set; }
        public bool contains_ads { get; set; }
        public string privacy_policy_link { get; set; }
        public List<string> app_permissions { get; set; }
        public string app_developer_website { get; set; }
        public string app_developer_email { get; set; }
        public string min_android_version { get; set; }
        public int min_android_api_level { get; set; }
        public string max_android_version { get; set; }
        public int max_android_api_level { get; set; }
    }

    public class GooglePlayResponseRoot
    {
        public string status { get; set; }
        public string request_id { get; set; }
        public List<GooglePlayResponse> data { get; set; }
    }


}
