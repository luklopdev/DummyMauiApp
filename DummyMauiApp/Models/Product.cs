using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyMauiApp.Models
{
    public class Dimensions
    {
        public double width { get; set; }
        public double height { get; set; }
        public double depth { get; set; }
    }

    public class Meta
    {
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public string barcode { get; set; } = string.Empty;
        public string qrCode { get; set; } = string.Empty;
    }

    public class Product
    {
        public int id { get; set; }
        public string title { get; set; } = string.Empty;
        public string description { get; set; } = string.Empty;
        public string category { get; set; } = string.Empty;
        public double price { get; set; }
        public double discountPercentage { get; set; }
        public double rating { get; set; }
        public int stock { get; set; }
        public List<string> tags { get; set; } = new();
        public string brand { get; set; } = string.Empty;
        public string sku { get; set; } = string.Empty;
        public int weight { get; set; }
        public Dimensions dimensions { get; set; } = new();
        public string warrantyInformation { get; set; } = string.Empty;
        public string shippingInformation { get; set; } = string.Empty;
        public string availabilityStatus { get; set; } = string.Empty;
        public List<Review> reviews { get; set; } = new();
        public string returnPolicy { get; set; } = string.Empty;
        public int minimumOrderQuantity { get; set; }
        public Meta meta { get; set; } = new();
        public List<string> images { get; set; } = new();
        public string thumbnail { get; set; } = string.Empty;
    }

    public class Review
    {
        public int rating { get; set; }
        public string comment { get; set; } = string.Empty;
        public DateTime date { get; set; }
        public string reviewerName { get; set; } = string.Empty;
        public string reviewerEmail { get; set; } = string.Empty;
    }

    public class ProductsResponse : Response
    {
        public List<Product> products { get; set; } = new();

    }
}
