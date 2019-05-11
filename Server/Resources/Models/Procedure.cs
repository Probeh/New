using Server.Resources.Models.Core;

namespace Server.Resources.Models
{
    public class Procedure : Profile<Procedure>
    {
        public int? SolutionId { get; set; }
        public virtual Solution Solution { get; set; }
    }
}