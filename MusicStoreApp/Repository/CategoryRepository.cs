using MusicStoreApp.Models;
using MusicStoreApp.Repository.IRepository;
using MusicStoreApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicStoreApp.Repository
{
    /// <summary>
    /// CategoryRepository
    /// </summary>
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        private readonly MusicStoreEntities context;
        private const bool FalseValue = false;
        private const bool TrueValue = true;

        public CategoryRepository(MusicStoreEntities _context) : base(_context)
        {
            context = _context;
        }

        /// <summary>
        /// Updates the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        public override Category Update(Category entity)
        {
            var oldEntity = context.Category.Where(p => p.Id == entity.Id && p.Active == TrueValue).FirstOrDefault();

            oldEntity.Name = entity.Name;
            oldEntity.Updated = entity.Updated;

            context.SaveChanges();

            return oldEntity;
        }

        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public override void Delete(int id)
        {
            var entity = context.Category.Find(id);

            entity.Active = FalseValue;
            entity.Updated = DateTime.Now;

            context.SaveChanges();
        }
    }
}