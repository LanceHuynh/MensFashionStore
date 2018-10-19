using MensFashionStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MensFashionStore.Data
{
    public class ClothingRepository
    {
        private static Clothing[] _clothing = new Clothing[]
        {
            new Clothing()
            {
                Id = 1,
                Infomation = new String[]
                {
                    "Size: XL",
                    "Blue",
                    "Comfortable"
                },
                DescriptionHtml  = "<p>Show this to your friend!</p>",
                Name = "Black Big Shirt",
                Category = "Shirt",
                Price = 20.00
            },
            new Clothing()
            {
                Id = 2,
                Infomation = new String[]
                {
                    "Size: SM",
                    "Grey",
                    "Stylish"
                },
                DescriptionHtml  = "<p>You may wnat to check this out!</p>",
                Name = "Grey Small Shirt",
                Category = "Shirt",
                Price = 15.00
            },
            new Clothing()
            {
                Id = 3,
                Infomation = new String[]
                {
                    "Size: SM",
                    "Red",
                    "Snazzy"
                },
                DescriptionHtml  = "<p>Show this to your friend!</p>",
                Name = "Red Small Shirt",
                Category = "Shirt",
                Price = 34.65
            },
            new Clothing()
            {
                Id = 4,
                Infomation = new String[]
                {
                    "Size: XL",
                    "Blue",
                    "Comfortable"
                },
                DescriptionHtml  = "<p>Show this to your friend!</p>",
                Name = "White Medium Shirt",
                Category = "Shirt",
                Price = 38.99
            },
            new Clothing()
            {
                Id = 5,
                Infomation = new String[]
                {
                    "Size: XL",
                    "Blue",
                    "Comfortable"
                },
                DescriptionHtml  = "<p>Show this to your friend!</p>",
                Name = "BLue Big Pants",
                Category = "Pants",
                Price = 38.99
            },
            new Clothing()
            {
                Id = 6,
                Infomation = new String[]
                {
                    "Size: XL",
                    "Blue",
                    "Comfortable"
                },
                DescriptionHtml  = "<p>Show this to your friend!</p>",
                Name = "Blue Medium Pants",
                Category = "Pants",
                Price = 38.99
            },
            new Clothing()
            {
                Id = 7,
                Infomation = new String[]
                {
                    "Size: XL",
                    "Blue",
                    "Comfortable"
                },
                DescriptionHtml  = "<p>Show this to your friend!</p>",
                Name = "Blue Small Pants",
                Category = "Pants",
                Price = 38.99
            },
            new Clothing()
            {
                Id = 8,
                Infomation = new String[]
                {
                    "Size: XL",
                    "Blue",
                    "Comfortable"
                },
                DescriptionHtml  = "<p>Show this to your friend!</p>",
                Name = "Grey Big Pants",
                Category = "Pants",
                Price = 38.99
            },
        };

        public IEnumerable<Clothing> GetAllClothing()
        {
            return _clothing;
        }

        public IEnumerable<Clothing> GetClothing(string category)
        {
            List<Clothing> clothingToBeReturned = new List<Clothing>();
            foreach(var clothing in _clothing)
            {
                if(clothing.Category == category)
                {
                    clothingToBeReturned.Add(clothing);
                }
            }
            return clothingToBeReturned;
        }

        public Clothing GetClothing(int id)
        {
            foreach(var clothing in _clothing)
            {
                if (clothing.Id == id)
                {
                    return clothing;
                }
            }
            return null;
        }
    }
}