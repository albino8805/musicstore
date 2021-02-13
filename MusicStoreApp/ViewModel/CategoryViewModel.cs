using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MusicStoreApp.ViewModel
{
    /// <summary>
    /// CategoryViewModel
    /// </summary>
    public class CategoryViewModel : BaseViewModel
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [Required(ErrorMessage = "Requerido")]
        [StringLength(100)]
        public string Name { get; set; }
    }
}