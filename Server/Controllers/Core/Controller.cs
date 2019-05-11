using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Server.Resources.DTOs.Request;
using Server.Resources.DTOs.Response;
using Server.Resources.Interfaces;
using Server.Resources.Models.Core;

namespace Server.Controllers.Core
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseController<TEntity> : ControllerBase where TEntity : Model<TEntity>
    {
        internal readonly ICrudRepository<TEntity> repo;

        public BaseController(ICrudRepository<TEntity> repo)
        {
            this.repo = repo;
        }

        internal virtual async Task<IActionResult> Process<T>([Optional] Func<Task<T>> function)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                T result = await function();
                return Ok(result);
            }
            catch (Exception ex) { throw ex; }
        }
    }

    public class Controller<TEntity> : BaseController<TEntity> where TEntity : Model<TEntity>
    {
        public Controller(ICrudRepository<TEntity> repo) : base(repo) { }

        [HttpGet]
        public virtual async Task<IActionResult> GetModels<TResponse>() where TResponse : ResponseDTO
        {
            return await base.Process(
                async() =>
                {
                    return await base.repo.GetModels<TResponse>();
                });
        }

        [HttpGet("{id}")]
        public virtual async Task<IActionResult> GetModel<TResponse>([FromRoute] int id) where TResponse : ResponseDTO
        {
            return await base.Process(
                async() =>
                {
                    return await base.repo.GetModel<TResponse>(id);
                });
        }

        [HttpPost]
        public virtual async Task<IActionResult> CreateModel<TRequest, TResponse>([FromBody] TRequest request) where TRequest : RequestDTO where TResponse : ResponseDTO
        {
            return await base.Process(
                async() =>
                {
                    return await base.repo.CreateModel<TRequest, TResponse>(request);
                });
        }

        [HttpPut]
        public virtual async Task<IActionResult> UpdateModel<TRequest, TResponse>([FromBody] TRequest request) where TRequest : RequestDTO where TResponse : ResponseDTO
        {
            return await base.Process(
                async() =>
                {
                    return await base.repo.UpdateModel<TRequest, TResponse>(request);
                });
        }

        [HttpDelete("{id}")]
        public virtual async Task<IActionResult> DeleteModel<TResponse>([FromRoute] int id) where TResponse : ResponseDTO
        {
            return await base.Process(
                async() =>
                {
                    return await base.repo.DeleteModel<TResponse>(id);
                });
        }
    }

    public class Controller<TEntity, TRequest, TResponse> : BaseController<TEntity> where TEntity : Model<TEntity> where TRequest : RequestDTO where TResponse : ResponseDTO
    {
        public Controller(ICrudRepository<TEntity> repo) : base(repo) { }

        [HttpGet]
        public virtual async Task<IActionResult> GetModels()
        {
            return await base.Process(
                async() =>
                {
                    return await base.repo.GetModels<TResponse>();
                });
        }

        [HttpGet("{id}")]
        public virtual async Task<IActionResult> GetModel([FromRoute] int id)
        {
            return await base.Process(
                async() =>
                {
                    return await base.repo.GetModel<TResponse>(id);
                });
        }

        [HttpPost]
        public virtual async Task<IActionResult> CreateModel([FromBody] TRequest request)
        {
            return await base.Process(
                async() =>
                {
                    return await base.repo.CreateModel<TRequest, TResponse>(request);
                });
        }

        [HttpPut]
        public virtual async Task<IActionResult> UpdateModel([FromBody] TRequest request)
        {
            return await base.Process(
                async() =>
                {
                    return await base.repo.UpdateModel<TRequest, TResponse>(request);
                });
        }

        [HttpDelete("{id}")]
        public virtual async Task<IActionResult> DeleteModel([FromRoute] int id)
        {
            return await base.Process(
                async() =>
                {
                    return await base.repo.DeleteModel<TResponse>(id);
                });
        }
    }
}