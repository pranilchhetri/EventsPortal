using EventPortal.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EventPortal.Data
{
    public class RestServices
    {
        HttpClient client;
        public static List<Event> events { get; set; }

        //Fetch Item from the server
        public async Task<bool> FetchItemAsync(string url)
        {

            client = new HttpClient();
            var uri = new Uri(string.Format(url, string.Empty));

            try
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    events = JsonConvert.DeserializeObject<List<Event>>(content);
                    Console.WriteLine("EventPortal : Successfully Fetched Data...");
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("EventPortal : Error occured when Item is fetch : ", ex.Message);
            }
            return false;
        }

        //Save Item to the server
        public async Task<bool> SaveItemAsync(Event item, bool isNewItem = true)
        {
            client = new HttpClient();
            var uri = new Uri(string.Format(Constants.SaveEventUrl, string.Empty));

            try
            {
                var json = JsonConvert.SerializeObject(item);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = null;
                if (isNewItem)
                {
                    response = await client.PostAsync(uri, content);
                }
                else
                {
                    response = await client.PutAsync(uri, content);
                }

                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("EventPortal : Successfully saved");
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("EventPortal : Error occured while posting : " + ex.Message);
                
            }
            return false;
        }
    }
}
