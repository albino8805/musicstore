using MusicStoreApp.Models;
using MusicStoreApp.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicStoreApp.Repository
{
    /// <summary>
    /// AlbumRepository
    /// </summary>
    /// <seealso cref="MusicStoreApp.Repository.BaseRepository{MusicStoreApp.Models.Album}" />
    /// <seealso cref="MusicStoreApp.Repository.IRepository.IAlbumRepository{MusicStoreApp.Models.Album}" />
    public class AlbumRepository : BaseRepository<Album>, IAlbumRepository
    {
        private readonly MusicStoreEntities context;
        private const bool FalseValue = false;
        private const bool TrueValue = true;

        /// <summary>
        /// Initializes a new instance of the <see cref="AlbumRepository"/> class.
        /// </summary>
        /// <param name="_context">The context.</param>
        public AlbumRepository(MusicStoreEntities _context) : base(_context)
        {
            context = _context;
        }

        /// <summary>
        /// Patches the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        public override Album Update(Album entity)
        {
            var oldEntity = context.Album.Where(p => p.Id == entity.Id && p.Active == TrueValue).FirstOrDefault();

            oldEntity.Name = entity.Name;
            oldEntity.Year = entity.Year;
            oldEntity.PriceSale = entity.PriceSale;
            oldEntity.SingerFK = entity.SingerFK;
            oldEntity.CategoryFK = entity.CategoryFK;

            context.SaveChanges();

            return oldEntity;
        }

        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Delete(int id)
        {
            var entity = context.Album.Find(id);
            context.Album.Remove(entity);
            context.SaveChanges();
        }
    }
}