using Server.Controllers.Core;
using Server.Resources.DTOs.Request;
using Server.Resources.DTOs.Response;
using Server.Resources.Interfaces;
using Server.Resources.Models;

namespace Server.Controllers
{
    public class ProductsController : Controller<Product, ProductRequestDTO, ProductResponseDTO>
    {
        public ProductsController(ICrudRepository<Product> repo) : base(repo) { }
    }
}