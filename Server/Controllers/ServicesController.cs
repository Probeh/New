using Server.Controllers.Core;
using Server.Resources.DTOs.Request;
using Server.Resources.DTOs.Response;
using Server.Resources.Interfaces;
using Server.Resources.Models;

namespace Server.Controllers
{
    public class ServicesController : Controller<Service, ServiceRequestDTO, ServiceResponseDTO>
    {
        public ServicesController(ICrudRepository<Service> repo) : base(repo) { }
    }
}