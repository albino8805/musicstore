using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicStoreApp.ViewModel
{
    /// <summary>
    /// BaseViewModel
    /// </summary>
    public class BaseViewModel
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="BaseViewModel"/> is active.
        /// </summary>
        /// <value>
        ///   <c>true</c> if active; otherwise, <c>false</c>.
        /// </value>
        public bool Active { get; set; }
        /// <summary>
        /// Gets or sets the created.
        /// </summary>
        /// <value>
        /// The created.
        /// </value>
        public Nullable<System.DateTime> Created { get; set; }
        /// <summary>
        /// Gets or sets the updated.
        /// </summary>
        /// <value>
        /// The updated.
        /// </value>
        public Nullable<System.DateTime> Updated { get; set; }
    }
}