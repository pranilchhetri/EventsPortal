using System;
using System.Collections.Generic;
using System.Text;

namespace EventPortal.Models
{
    public class NewsItems
    {

        private string newsTitle;
        private string newsPublishedTime;
        private string newsPublishedDate;
        private string newsImage;
        private string newsDetails;

        public string NewsTitle { get => newsTitle; set => newsTitle = value; }
        public string NewsDetails { get => newsDetails; set => newsDetails = value; }
        public string NewsImage { get => newsImage; set => newsImage = value; }
        public string NewsPublishedDate { get => newsPublishedDate; set => newsPublishedDate = value; }
        public string NewsPublishedTime { get => newsPublishedTime; set => newsPublishedTime = value; }

        
    }
}
