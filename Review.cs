using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_review_dotNetF
{
    class Review
    {
        private string _reviewerName; // field or variable
        private string _fileName = "Review.txt";

        public string ReviewerName { 
            get { return _reviewerName; }
            set { _reviewerName = value; }
        } // property or variable

        public string ReviewerEmail { get; set; }

        public string ReviewerPhone { get; set; }

        public int FoodRating { get; set; }

        public int ServiceRating {get;set; }

        public int EnviromentRating { get; set; }

        public string Suggestions { get; set; }

        public bool Save(Review r)
        {
            string data = JsonConvert.SerializeObject(r, Formatting.None);
            Utility.WriteToFile(_fileName, data);
            return true;
        }
    }
}
