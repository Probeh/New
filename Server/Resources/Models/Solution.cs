using System.Collections.Generic;
using Server.Resources.Models.Core;

namespace Server.Resources.Models
{
    public class Solution : Profile<Solution>
    {
        public int? SoftwareId { get; set; }
        public virtual Software Software { get; set; }
        public virtual List<Procedure> Procedures { get; set; }

        public Solution()
        {
            this.Procedures = new List<Procedure>();
        }
    }
}