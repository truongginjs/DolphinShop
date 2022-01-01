using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApi.DTOs.Requests;
using WebApi.DTOs.Responses;
using WebApi.Infrastructure.Repositories;
using WebApi.Models;

namespace WebApi.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class CommentController : GenericController<Comment, CommentReqDTO, CommentResDTO>
    {
        public CommentController(ICommentRepository repo, IMapper mapper, ILogger<CommentController> logger) : base(repo, mapper, logger)
        {
        }
    }
}