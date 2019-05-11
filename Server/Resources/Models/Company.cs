using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using Server.Resources.Enums;
using Server.Resources.Interfaces;
using Server.Resources.Models.Core;

namespace Server.Resources.Models
{
    public partial class Company : Profile<Company>
    {
        public CompanyKey Key { get; set; }
        public virtual List<Software> Software { get; set; }
        public virtual List<Product> Products { get; set; }
        public virtual List<Service> Services { get; set; }

        public Company()
        {
            this.Software = new List<Software>();
            this.Products = new List<Product>();
            this.Services = new List<Service>();
        }
    }
}