using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Server.Controllers.Core;
using Server.Resources.Context;
using Server.Resources.DTOs.Request;
using Server.Resources.DTOs.Response;
using Server.Resources.Interfaces;
using Server.Resources.Models;

namespace Server.Controllers
{
    public class CompaniesController : Controller<Company, CompanyRequestDTO, CompanyResponseDTO>
    {
        public CompaniesController(ICrudRepository<Company> repo) : base(repo) { }
    }
}