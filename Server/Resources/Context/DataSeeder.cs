using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Server.Resources.Enums;
using Server.Resources.Models;

namespace Server.Resources.Context
{
    public partial class DataSeeder
    {
        private readonly ApplicationDBContext context;

        public DataSeeder(ApplicationDBContext context)
        {
            this.context = context;
        }

        public void SeedData()
        {
            // if (this.context.Set<Company>().ToList().Count() == 0)
            // {
            //     await this.SeedCompanies();
            //     if (this.context.Set<Product>().ToList().Count() == 0)
            //     {
            //         await this.SeedProducts();
            //         if (this.context.Set<Software>().ToList().Count() == 0)
            //         {
            //             await this.SeedSoftware();
            //             if (this.context.Set<Service>().ToList().Count() == 0)
            //             {
            //                 await this.SeedServices();
            //             }
            //         }
            //     }
            // }
        }
    }
}