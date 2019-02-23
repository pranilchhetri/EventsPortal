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
        private Guid newsGuid;
        private string newsAuthor;
        private string newsLocation;

        public string NewsTitle { get => newsTitle; set => newsTitle = value; }
        public string NewsDetails { get => newsDetails; set => newsDetails = value; }
        public string NewsImage { get => newsImage; set => newsImage = value; }
        public string NewsPublishedDate { get => newsPublishedDate; set => newsPublishedDate = value; }
        public string NewsPublishedTime { get => newsPublishedTime; set => newsPublishedTime = value; }
        public Guid NewsGuid { get => newsGuid; set => newsGuid=value; }
        public string NewsAuthor { get => newsAuthor; set => newsAuthor = value; }
        public string NewsLocation { get => newsLocation; set => newsLocation = value; }

       

    }
}
