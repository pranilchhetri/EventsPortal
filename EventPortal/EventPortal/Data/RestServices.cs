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
        public static User user { get; set; }

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
                    events=null;
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

        public async Task<bool> FetchLoginAsync(string url, string password)
        {

            client = new HttpClient();
            var uri = new Uri(string.Format(url, string.Empty));

            try
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    user = null;
                    var content = await response.Content.ReadAsStringAsync();
                    user = JsonConvert.DeserializeObject<User>(content);
                    Console.WriteLine("EventPortal : Successfully Fetched Data...");
                    if (user.Password == password)
                    {
                        Helpers.Settings.LoginUser = user.Username;
                        return true;
                    } 
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("EventPortal : Error occured when Item is fetch : ", ex.Message);
            }
            return false;
        }
        public async Task<bool> SaveNewUserAsync(User item, bool isNewItem = true)
        {
            client = new HttpClient();
            var uri = new Uri(string.Format(Constants.SaveNewUserUrl, string.Empty));

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
