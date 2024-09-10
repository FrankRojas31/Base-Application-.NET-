using System.Linq.Expressions;

namespace Base.Infraestructura.Data.Repositorios.Contrato
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IBaseRepository<T> where T : class
    {
        /// <summary>
        /// Inserts the asynchronous.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        Task<int> InsertAsync(T entity);

        /// <summary>
        /// Updates the asynchronous.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        Task<int> UpdateAsync(T entity, T entityOld = null);

        /// <summary>
        /// Removes the asynchronous.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        Task<int> RemoveAsync(T entity);

        /// <summary>
        /// Removes the asynchronous.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <returns></returns>
        Task<int> RemoveAsync(int Id);

        /// <summary>
        /// Gets all asynchronous.
        /// </summary>
        /// <param name="filter">The filter.</param>
        /// <returns></returns>
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> filter = null);


        /// <summary>
        /// Inserta varios registros en la base de datos en una sola transacción.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        Task<int> InsertRangeAsync(IEnumerable<T> entities);


        /// <summary>
        /// Gets the single asynchronous.
        /// </summary>
        /// <param name="filter">The filter.</param>
        /// <returns></returns>
        Task<T> GetSingleAsync(Expression<Func<T, bool>> filter = null);

        /// <summary>
		/// gets the asynchronous.
		/// </summary>
		/// <param name="Id">The identifier.</param>
		/// <returns></returns>
        Task<T> GetById(int Id);


        /// <summary>
        /// Gets the single asynchronous.
        /// </summary>
        /// <param name="filter">The filter.</param>
        /// <returns></returns>
        Task<bool> ExistSingleAsync(Expression<Func<T, bool>> filter = null);


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<int> CountRow(string filter);
        /// 

        string ObtenerIdUsario();
        string ObtenerRol();
    }
}
