using MusicStoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStoreApp.Repository.IRepository
{
    /// <summary>
    /// ICategoryRepository
    /// </summary>
    /// <seealso cref="MusicStoreApp.Repository.IRepository.IBaseRepository" />
    public interface ICategoryRepository : IBaseRepository<Category>
    {
    }
}
