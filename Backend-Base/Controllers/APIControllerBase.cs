using Base.Application.Services.Interfaces.Contrato;
using Base.Domain.DTO.Core;
using Base.Domain.Entidades.Core;
using Microsoft.AspNetCore.Mvc;

namespace Base.API.Controllers
{
    /// <summary>
    /// MyControllerBase
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="TDto">The type of the dto.</typeparam>
    [ApiController]
	[Route("api/[controller]")]
	public class APIControllerBase<T, TDto> : ControllerBase where T : BaseEntity where TDto : BaseDTO
	{
		/// <summary>
		/// The service
		/// </summary>
		private readonly IServiceBase<T, TDto> _service;
        /// <summary>
        /// Initializes a new instance of the <see cref="APIControllerBase{T, TDto}"/> class.
        /// </summary>
        /// <param name="service">The service.</param>


        public APIControllerBase(IServiceBase<T, TDto> service)
		{
			_service = service;
        }

		/// <summary>
		/// Gets all.
		/// </summary>
		/// <returns></returns>
		[HttpGet]
		public virtual async Task<ActionResult<List<TDto>>> GetAll()
		{
			var result = await _service.GetAllAsync();
			
			return Ok(result);
		}

        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        [HttpGet("{id}")]
		public virtual async Task<ActionResult<TDto>> GetById(int id)
		{
			var result = await _service.GetById(x => x.Id == id);
			if (result.Data == null)
			{
				return NotFound();
			}
			
			return Ok(result);
		}

		/// <summary>
		/// Creates the specified dto.
		/// </summary>
		/// <param name="dto">The dto.</param>
		/// <returns></returns>
		[HttpPost]
		public virtual async Task<ActionResult<TDto>> Create(TDto dto)
		{
			

			var entity = await _service.ConvertToEntity(dto);
			var createdEntity = await _service.InsertAsync(entity);

			return Ok(createdEntity);
		}

		/// <summary>
		/// Updates the specified identifier.
		/// </summary>
		/// <param name="id">The identifier.</param>
		/// <param name="dto">The dto.</param>
		/// <returns></returns>
		[HttpPut("{id}")]
		public virtual async Task<ActionResult<TDto>> Update(int id, TDto dto)
		{
			if (id == 0)
			{
				return BadRequest();
			}

			var entity = await _service.GetById(x => x.Id == id);
			var entityOld = (T)entity.Data;
			if (entity.Data == null)
			{
				return NotFound();
			}

			var updatedEntity = await _service.ConvertToEntity(dto);
			var result = await _service.UpdateAsync(updatedEntity,entityOld);
	
			return Ok(result);
		}

		/// <summary>
		/// Deletes the specified identifier.
		/// </summary>
		/// <param name="id">The identifier.</param>
		/// <returns></returns>
		[HttpDelete("{id}")]
		public virtual async Task<IActionResult> Delete(int id)
		{
			var result = await _service.RemoveAsync(id);

			return Ok(result);
		}
    }
}
