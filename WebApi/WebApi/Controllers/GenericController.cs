using AutoMapper;
using LapTrinhDotNet.EFCore.Initialize;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class GenericController<T, TRequest, TResponse> : ControllerBase where T : BaseModel
    {
        private readonly IRepository<T> _repo;
        private readonly IMapper _mapper;
        private readonly ILogger<GenericController<T, TRequest, TResponse>> _logger;

        public GenericController(IRepository<T> repo, IMapper mapper, ILogger<GenericController<T, TRequest, TResponse>> logger)
        {
            _repo = repo;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet]
        public virtual async Task<ActionResult<IEnumerable<TResponse>>> GetsAsync()
        {
            var data = await _repo.GetsAsync();
            try
            {
                var result = _mapper.Map<IEnumerable<TResponse>>(data);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpGet("{id}")]
        public virtual async Task<ActionResult<TResponse>> GetAsync(Guid id)
        {
            var data = await _repo.GetAsync(id);
            if (data == null) return NotFound();
            try
            {
                var result = _mapper.Map<TResponse>(data);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public virtual async Task<ActionResult<TResponse>> CreateAsync([FromBody] TRequest test)
        {
            var input = _mapper.Map<T>(test);
            // input.Id = Guid.NewGuid();
            var data = await _repo.CreateAsync(input);
            if (data == null) return BadRequest("Can't create");
            var result = _mapper.Map<TResponse>(data);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public virtual async Task<ActionResult<TResponse>> UpdateAsync(Guid id, [FromBody] TRequest test)
        {
            var input = _mapper.Map<T>(test);
            var data = await _repo.UpdateAsync(id, input);
            if (data == null) return BadRequest();
            var result = _mapper.Map<TResponse>(data);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public virtual async Task<ActionResult<TResponse>> DeleteAsync(Guid id)
        {
            var data = await _repo.DeleteAsync(id);
            if (data == null) return BadRequest();
            var result = _mapper.Map<TResponse>(data);
            return Ok(result);
        }
    }
}