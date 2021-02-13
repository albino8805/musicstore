using MusicStoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStoreApp.Repository.IRepository
{
    /// <summary>
    /// IAlbumRepository
    /// </summary>
    /// <typeparam name="TEntity">The type of the entity.</typeparam>
    /// <seealso cref="MusicStoreApp.Repository.IRepository.IBaseRepository{TEntity}" />
    public interface IAlbumRepository : IBaseRepository<Album>
    {
    }
}
