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
                Name = "Shirt",
                Category = "Shirt",
                Price = 38.99
            },
            new Clothing()
            {
                Id = 2,
                Infomation = new String[]
                {
                    "Size: XL",
                    "Blue",
                    "Comfortable"
                },
                DescriptionHtml  = "<p>Show this to your friend!</p>",
                Name = "Shirt",
                Category = "Shirt",
                Price = 38.99
            },
            new Clothing()
            {
                Id = 3,
                Infomation = new String[]
                {
                    "Size: XL",
                    "Blue",
                    "Comfortable"
                },
                DescriptionHtml  = "<p>Show this to your friend!</p>",
                Name = "Shirt",
                Category = "Shirt",
                Price = 38.99
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
                Name = "Shirt",
                Category = "Shirt",
                Price = 38.99
            },
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
                Name = "Shirt",
                Category = "Shirt",
                Price = 38.99
            },
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
                Name = "Shirt",
                Category = "Shirt",
                Price = 38.99
            },
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
                Name = "Shirt",
                Category = "Shirt",
                Price = 38.99
            },
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
                Name = "Shirt",
                Category = "Pants",
                Price = 38.99
            },
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
                Name = "Shirt",
                Category = "Shirt",
                Price = 38.99
            },
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
                Name = "Shirt",
                Category = "Shirt",
                Price = 38.99
            },
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
                Name = "Shirt",
                Category = "Shirt",
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