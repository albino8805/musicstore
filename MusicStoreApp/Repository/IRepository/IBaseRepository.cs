using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicStoreApp.Repository.IRepository
{
    /// <summary>
    /// IBaseRepository
    /// </summary>
    /// <typeparam name="TEntity">The type of the model.</typeparam>
    public interface IBaseRepository<TEntity>
    {
        /// <summary>
        /// Gets this instance.
        /// </summary>
        /// <returns></returns>
        List<TEntity> Get();
        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        TEntity GetById(int id);
        /// <summary>
        /// Adds the specified model.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        int Add(TEntity model);
        /// <summary>
        /// Updates the specified model.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        TEntity Update(TEntity model);
        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        void Delete(int id);
    }
}