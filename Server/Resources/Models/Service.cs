using Server.Resources.Models.Core;

namespace Server.Resources.Models
{
    public class Service : Profile<Service>
    {
        public int? CompanyId { get; set; }
        public int? ProductId { get; set; }
        public int? SoftwareId { get; set; }
        public virtual Company Company { get; set; }
        public virtual Product Product { get; set; }
        public virtual Software Software { get; set; }
    }
}