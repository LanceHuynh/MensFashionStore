using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MensFashionStore.Models
{
    public class Clothing
    {
        public int Id { get; set; }
        public String[] Infomation { get; set; }
        public string DescriptionHtml { get; set; }
        public string  Name { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public string CoverImageFileName
        {
            get
            {
                return Name.Replace(" ", "-").ToLower() + ".jpg";
            }
        }
    }
}