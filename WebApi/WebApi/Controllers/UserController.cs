using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApi.DTOs.Requests;
using WebApi.Helpers.Constants;
using WebApi.Infrastructure.Repositories;
using WebApi.Models;
using WebApi.Models.Enums;

namespace WebApi.Controllers
{
    [Authorize(Policy = Constant.PolicyTypes.Admin)]
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : GenericController<User, UserReqDTO, UserResDTO>
    {
        public UserController(IUserRepository repo, IMapper mapper, ILogger<UserController> logger) : base(repo, mapper, logger)
        {
        }
    }
}