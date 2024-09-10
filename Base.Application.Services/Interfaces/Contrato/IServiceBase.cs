using Base.Domain.DTO.Core;
using Base.Domain.ViewModels;
using System.Linq.Expressions;

namespace Base.Application.Services.Interfaces.Contrato
{
    public interface IServiceBase<T, TDto> where T : class where TDto : BaseDTO
    {
        Task<ResponseHelper> GetAllAsync(Expression<Func<T, bool>> filter = null);
        Task<ResponseHelper> InsertAsync(T entity);
        Task<ResponseHelper> UpdateAsync(T entity, T entityOld = null);
        Task<ResponseHelper> GetById(Expression<Func<T, bool>> filter = null);
        Task<ResponseHelper> RemoveAsync(T entity);
        Task<ResponseHelper> RemoveAsync(int Id);

        Task<TDto> ConvertToDto(T entity);
        Task<T> ConvertToEntity(TDto dto);
        Task<List<TDto>> ConvertToDto(List<T> entity);
        Task<List<T>> ConvertToEntity(List<TDto> dto);

    }
}
