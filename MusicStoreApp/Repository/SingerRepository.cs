using MusicStoreApp.Models;
using MusicStoreApp.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicStoreApp.Repository
{
    /// <summary>
    /// SingerRepository
    /// </summary>
    /// <seealso cref="MusicStoreApp.Repository.BaseRepository{MusicStoreApp.Models.Singer}" />
    /// <seealso cref="MusicStoreApp.Repository.IRepository.ISingerRepository{MusicStoreApp.Models.Singer}" />
    public class SingerRepository : BaseRepository<Singer>, ISingerRepository
    {
        private readonly MusicStoreEntities context;
        private const bool FalseValue = false;
        private const bool TrueValue = true;

        /// <summary>
        /// Initializes a new instance of the <see cref="SingerRepository"/> class.
        /// </summary>
        /// <param name="_context">The context.</param>
        public SingerRepository(MusicStoreEntities _context) : base(_context)
        {
            context = _context;
        }

        /// <summary>
        /// Patches the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        public override Singer Update(Singer entity)
        {
            var oldEntity = context.Singer.Where(p => p.Id == entity.Id && p.Active == TrueValue).FirstOrDefault();

            oldEntity.Name = entity.Name;
            oldEntity.Updated = entity.Updated;

            context.SaveChanges();

            return oldEntity;
        }

        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public override void Delete(int id)
        {
            var entity = context.Singer.Find(id);

            entity.Active = FalseValue;
            entity.Updated = DateTime.Now;

            context.SaveChanges();
        }
    }
}