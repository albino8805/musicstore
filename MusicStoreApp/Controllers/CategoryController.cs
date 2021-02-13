using MusicStoreApp.Manager;
using MusicStoreApp.Manager.IManager;
using MusicStoreApp.Utils;
using MusicStoreApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicStoreApp.Controllers
{
    /// <summary>
    /// CategoryController
    /// </summary>
    /// <seealso cref="System.Web.Mvc.Controller" />
    public class CategoryController : Controller
    {
        private ICategoryManager manager;

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryController"/> class.
        /// </summary>
        public CategoryController(ICategoryManager _manager)
        {
            manager = _manager;
        }

        /// <summary>
        /// Indexes this instance.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Index()
        {
            var categories = manager.Get();

            return View(categories);
        }


        /// <summary>
        /// Adds this instance.
        /// </summary>
        /// <returns></returns>
        public ActionResult Add()
        {
            return View();
        }

        /// <summary>
        /// Posts the specified category.
        /// </summary>
        /// <param name="category">The category.</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Post(CategoryViewModel category)
        {
            manager.Post(category);

            return Redirect("Index");
        }

        /// <summary>
        /// Adds this instance.
        /// </summary>
        /// <returns></returns>
        public ActionResult Edit(int id)
        {
            var model = manager.GetById(id);

            return View(model);
        }

        /// <summary>
        /// Patches the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="category">The category.</param>
        /// <returns></returns>
        [HttpPost]
        public RedirectResult Patch(int id, CategoryViewModel category)
        {
            manager.Patch(id, category);

            return Redirect("Index");
        }

        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Delete(int id)
        {
            JsonResponse jmResult = new JsonResponse();

            try
            {
                manager.Delete(id);

                jmResult.Success = (int)ResponseType.True;
                jmResult.Failure = (int)ResponseType.False;
                jmResult.Data = new { Message = "Categoría eliminada" };
            }
            catch (Exception ex)
            {
                jmResult.Success = (int)ResponseType.False;
                jmResult.Failure = (int)ResponseType.True;
                jmResult.Data = new { Message = "Ocurrío un error", Error = ex.Message };
            }

            return Json(jmResult);
        }
    }
}