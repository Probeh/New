using System.Collections.Generic;
using Server.Resources.Enums;
using Server.Resources.Models.Core;

namespace Server.Resources.Models
{
    public class Product : Profile<Product>
    {
        public ProductKey Key { get; set; }
        public CompanyKey? CompanyKey { get; set; }
        public virtual Company Company { get; set; }
        public virtual List<Software> Software { get; set; }
        public virtual List<Service> Services { get; set; }

        public Product()
        {
            this.Software = new List<Software>();
            this.Services = new List<Service>();
        }
    }
}