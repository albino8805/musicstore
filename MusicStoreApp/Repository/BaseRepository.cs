using MusicStoreApp.Models;
using MusicStoreApp.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace MusicStoreApp.Repository
{
    /// <summary>
    /// BaseRepository
    /// </summary>
    /// <typeparam name="TEntity">The type of the entity.</typeparam>
    /// <seealso cref="MusicStoreApp.Repository.IRepository.IBaseRepository{TEntity}" />
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly MusicStoreEntities _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseRepository{TEntity}"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public BaseRepository(MusicStoreEntities context)
        {
            _context = context;
        }

        /// <summary>
        /// Gets this instance.
        /// </summary>
        /// <returns></returns>
        public List<TEntity> Get()
        {
            return _context.Set<TEntity>().ToList();
        }

        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public TEntity GetById(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        /// <summary>
        /// Posts the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        public int Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);

            return _context.SaveChanges();
        }

        /// <summary>
        /// Patches the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        public virtual TEntity Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <exception cref="NotImplementedException"></exception>
        public virtual void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}