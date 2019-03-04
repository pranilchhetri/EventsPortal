using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EventPortal.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string Author { get; set; }
        public string Location { get; set; }
        public string ImageSource { get; set; }
        public DateTime Published { get; set; }

    }
}
