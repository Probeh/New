using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Server.Resources.Context;
using Server.Resources.DTOs.Request;
using Server.Resources.DTOs.Response;
using Server.Resources.Interfaces;
using Server.Resources.Models.Core;

namespace Server.Resources.Services
{
    public class CrudRepository<TEntity> : ICrudRepository<TEntity> where TEntity : Model<TEntity>
    {
        private readonly ApplicationDBContext context;
        private readonly IMapper mapper;

        public CrudRepository(ApplicationDBContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<TEntity> CreateModel<TRequest, TResponse>(TRequest request) where TRequest : RequestDTO where TResponse : ResponseDTO
        {
            EntityEntry<TEntity> model = await this.context.Set<TEntity>().AddAsync(this.mapper.Map<TRequest, TEntity>(request));
            await this.context.SaveChangesAsync();
            return model.Entity;
        }

        public async Task<TEntity> DeleteModel<TResponse>(int id) where TResponse : ResponseDTO
        {
            EntityEntry<TEntity> model = this.context.Set<TEntity>().Remove(await this.context.Set<TEntity>().SingleAsync(x => x.Id == id));
            await this.context.SaveChangesAsync();
            return model.Entity;
        }

        public async Task<TEntity> GetModel<TResponse>(int id) where TResponse : ResponseDTO
        {
            return await this.context.Set<TEntity>().FirstAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<TEntity>> GetModels<TResponse>() where TResponse : ResponseDTO
        {
            return await this.context.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> UpdateModel<TRequest, TResponse>(TRequest request) where TRequest : RequestDTO where TResponse : ResponseDTO
        {
            TEntity model = await this.context.Set<TEntity>().FirstAsync(x => x.Id == request.Id);
            model = this.mapper.Map<TEntity>(request);
            await this.context.SaveChangesAsync();
            return await this.context.Set<TEntity>().FirstAsync(x => x.Id == request.Id);
        }

        public async Task<IEnumerable<TEntity>> GetList()
        {
            return await this.context.Set<TEntity>().ToListAsync();
        }
    }
}