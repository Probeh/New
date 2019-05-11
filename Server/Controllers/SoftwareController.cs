using Server.Controllers.Core;
using Server.Resources.DTOs.Request;
using Server.Resources.DTOs.Response;
using Server.Resources.Interfaces;
using Server.Resources.Models;

namespace Server.Controllers
{
    public class SoftwareController : Controller<Software, SoftwareRequestDTO, SoftwareResponseDTO>
    {
        public SoftwareController(ICrudRepository<Software> repo) : base(repo) { }
    }
}