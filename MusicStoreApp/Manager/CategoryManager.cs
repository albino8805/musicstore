using MusicStoreApp.Manager.IManager;
using MusicStoreApp.Models;
using MusicStoreApp.Repository;
using MusicStoreApp.Repository.IRepository;
using MusicStoreApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicStoreApp.Manager
{
    /// <summary>
    /// CategoryManager
    /// </summary>
    public class CategoryManager : BaseManager<Category, CategoryViewModel>, ICategoryManager
    {
        private ICategoryRepository repository;

        private const bool FalseValue = false;
        private const bool TrueValue = true;

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryManager"/> class.
        /// </summary>
        public CategoryManager(ICategoryRepository _repository) : base(_repository)
        {
            repository = _repository;
        }

        /// <summary>
        /// Updates the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="category">The category.</param>
        public void Update(int id, CategoryViewModel category)
        {
            var entity = repository.GetById(id);

            repository.Update(this.PrepareUpdateData(entity, category));
        }

        /// <summary>
        /// Prepares the add data.
        /// </summary>
        /// <param name="viewModel">The view model.</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override Category PrepareAddData(CategoryViewModel viewModel)
        {
            return new Category()
            {
                Name = viewModel.Name,
                Active = TrueValue,
                Created = DateTime.Now
            };
        }

        /// <summary>
        /// Prepares the update data.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <param name="viewModel">The view model.</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override Category PrepareUpdateData(Category entity, CategoryViewModel viewModel)
        {
            entity.Name = viewModel.Name;
            entity.Updated = DateTime.Now;

            return entity;
        }

        /// <summary>
        /// Prepares the single return.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override CategoryViewModel PrepareSingleReturn(Category entity)
        {
            return new CategoryViewModel()
            {
                Id = entity.Id,
                Name = entity.Name,
                Active = entity.Active,
                Created = entity.Created,
                Updated = entity.Updated
            };
        }

        /// <summary>
        /// Prepares the multiple return.
        /// </summary>
        /// <param name="entities">The entities.</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override List<CategoryViewModel> PrepareMultipleReturn(List<Category> entities)
        {
            return entities.Select(p => new CategoryViewModel()
            {
                Id = p.Id,
                Name = p.Name,
                Active = p.Active,
                Created = p.Created,
                Updated = p.Updated
            }).ToList();
        }
    }
}