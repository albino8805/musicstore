using MusicStoreApp.Models;
using MusicStoreApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStoreApp.Manager.IManager
{
    /// <summary>
    /// ICategoryManager
    /// </summary>
    /// <seealso cref="MusicStoreApp.Manager.IManager.IBaseManager{MusicStoreApp.Models.Category, MusicStoreApp.ViewModel.CategoryViewModel}" />
    public interface ICategoryManager : IBaseManager<Category, CategoryViewModel>
    {
    }
}
