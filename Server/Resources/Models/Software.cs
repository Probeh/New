using System.Collections.Generic;
using Server.Resources.Enums;
using Server.Resources.Models.Core;

namespace Server.Resources.Models
{
    public class Software : Profile<Software>
    {
        public SoftwareKey Key { get; set; }
        public CompanyKey? CompanyKey { get; set; }
        public OSystemKey? OSystemKey { get; set; }
        public PlatformKey? PlatformKey { get; set; }
        public ProductKey? ProductKey { get; set; }

        public virtual Company Company { get; set; }
        public virtual Platform Platform { get; set; }
        public virtual Product Product { get; set; }
        public virtual List<Service> Services { get; set; }

        public Software()
        {
            this.Services = new List<Service>();
        }
    }
}