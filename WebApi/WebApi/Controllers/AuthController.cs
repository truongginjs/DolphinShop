using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApi.DTOs.Requests;
using WebApi.DTOs.Requests.Auth;
using WebApi.DTOs.Responses;
using WebApi.Infrastructure.Repositories;
using WebApi.Infrastructure.Services;
using WebApi.Models;

namespace WebApi.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("[controller]/[action]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        private readonly IMapper _mapper;

        public AuthController(IAuthService authService, IMapper mapper)
        {
            _authService = authService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult<UserResDTO>> Login([FromBody] UserLoginReqDTO user)
        {
            var result = await _authService.LoginAsync(user);
            return Ok(result);
        }


        [HttpPost]
        public async Task<ActionResult<UserResDTO>> Register([FromBody] UserRegisterReqDTO user)
        {
            var result = await _authService.RegisterAsync(user);
            return Ok(result);
        }

        [Authorize]
        [HttpPost]
        public async Task<ActionResult<bool>> Logout()
        {
            var result = await Task.FromResult(true);

            return Ok(result);
        }
    }
}