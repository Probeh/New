using System.Collections.Generic;
using System.Threading.Tasks;
using Server.Resources.DTOs.Request;
using Server.Resources.DTOs.Response;
using Server.Resources.Models.Core;

namespace Server.Resources.Interfaces
{
    public interface ICrudRepository<TEntity> where TEntity : Model<TEntity>
    {
        Task<IEnumerable<TEntity>> GetList();
        Task<IEnumerable<TEntity>> GetModels<TResponse>() where TResponse : ResponseDTO;
        Task<TEntity> GetModel<TResponse>(int id) where TResponse : ResponseDTO;
        Task<TEntity> CreateModel<TRequest, TResponse>(TRequest request) where TRequest : RequestDTO where TResponse : ResponseDTO;
        Task<TEntity> UpdateModel<TRequest, TResponse>(TRequest request) where TRequest : RequestDTO where TResponse : ResponseDTO;
        Task<TEntity> DeleteModel<TResponse>(int id) where TResponse : ResponseDTO;
    }
}