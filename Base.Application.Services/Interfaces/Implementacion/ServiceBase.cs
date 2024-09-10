using AutoMapper;
using System.Linq.Expressions;
using Base.Domain.ViewModels;
using Base.Infraestructura.Data.Repositorios.Contrato;
using Base.Application.Service;
using Base.Domain.DTO.Core;
using Base.Application.Services.Interfaces.Contrato;

namespace Base.Application.Services.Interfaces.Implementacion
{
    public class ServiceBase<T, TDto> : IServiceBase<T, TDto> where T : class where TDto : BaseDTO
    {
        private readonly IMapper _mapper;
        private readonly IBaseRepository<T> _repository;
        public ServiceBase(IMapper mapper, IBaseRepository<T> baseRepository)
        {
            _mapper = mapper;
            _repository = baseRepository;
        }

        public virtual async Task<ResponseHelper> GetAllAsync(Expression<Func<T, bool>> filter = null)
        {
            ResponseHelper response = new ResponseHelper();
            try
            {
                var data = await _repository.GetAllAsync(filter);

                response.Message = "Listado correcto.";
                response.Success = true;
                response.Data = data;
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }

            return response;
        }

        public virtual async Task<ResponseHelper> InsertAsync(T entity)
        {
            ResponseHelper response = new ResponseHelper();
            try
            {

                var result = await _repository.InsertAsync(entity);

                if (result != 0)
                {
                    response.Message = $"El elemento {typeof(T).GetDisplayName()} fue insertado con éxito.";
                    response.Success = true;
                    // verificación de que entity tiene una propiedad Id y es modificable, si es asi le asignamos el valor de result que traerá el nuevo Id
                    var idProperty = entity.GetType().GetProperty("Id");
                    if (idProperty != null && idProperty.CanWrite)
                    {
                        idProperty.SetValue(entity, result, null);
                    }
                    response.Data = entity;

                }
            }
            catch (Exception e)
            {

                response.Message = e.Message;
            }
            return response;
        }

        public virtual async Task<ResponseHelper> UpdateAsync(T entity, T entityOld = null)
        {
            ResponseHelper response = new ResponseHelper();
            try
            {

                var result = await _repository.UpdateAsync(entity, entityOld);

                if (result > 0)
                {
                    response.Message = $"El elemento {typeof(T).GetDisplayName()} fue actualizado con éxito.";
                    response.Success = true;
                    response.Data = entity; // Puedes proporcionar la entidad actualizada en la respuesta si es necesario.
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }

            return response;
        }

        public virtual async Task<ResponseHelper> RemoveAsync(T entity)
        {
            ResponseHelper response = new ResponseHelper();
            try
            {

                var result = await _repository.RemoveAsync(entity);

                if (result > 0)
                {
                    response.Message = $"El elemento  {typeof(T).GetDisplayName()} fue eliminado con éxito.";
                    response.Success = true;
                    response.Data = entity; // Puedes proporcionar la entidad eliminada en la respuesta si es necesario.
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }

            return response;
        }

        public virtual async Task<ResponseHelper> RemoveAsync(int id)
        {
            ResponseHelper response = new ResponseHelper();
            try
            {
                var result = await _repository.RemoveAsync(id);

                if (result > 0)
                {
                    response.Message = $"El elemento  {typeof(T).GetDisplayName()} fue eliminado con éxito.";
                    response.Success = true;
                    response.Data = result; // Puedes proporcionar la entidad eliminada en la respuesta si es necesario.
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }

            return response;
        }

        public virtual async Task<ResponseHelper> GetById(Expression<Func<T, bool>> filter = null)
        {
            ResponseHelper response = new ResponseHelper();
            try
            {
                var data = await _repository.GetSingleAsync(filter);

                response.Message = "Elemento correcto.";
                response.Success = true;
                response.Data = data;
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }

            return response;
        }

        public async Task<TDto> ConvertToDto(T entity)
        {
            return await Task.FromResult(_mapper.Map<TDto>(entity));
        }
        public async Task<T> ConvertToEntity(TDto dto)
        {
            return await Task.FromResult(_mapper.Map<T>(dto));
        }
        public async Task<List<TDto>> ConvertToDto(List<T> entities)
        {
            return await Task.FromResult(_mapper.Map<List<TDto>>(entities));
        }
        public async Task<List<T>> ConvertToEntity(List<TDto> dto)
        {
            return await Task.FromResult(_mapper.Map<List<T>>(dto));
        }


    }
}
