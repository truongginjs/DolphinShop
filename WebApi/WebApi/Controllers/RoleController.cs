using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApi.DTOs.Requests;
using WebApi.DTOs.Responses;
using WebApi.Infrastructure.Repositories;
using WebApi.Models;
using WebApi.Models.Enums;

namespace WebApi.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class RoleController : GenericController<Role, RoleReqDTO, RoleResDTO>
    {
        public RoleController(IRoleRepository repo, IMapper mapper, ILogger<RoleController> logger) : base(repo, mapper, logger)
        {
        }
    }
}