using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicStoreApp.ViewModel
{
    /// <summary>
    /// SingerViewModel
    /// </summary>
    /// <seealso cref="MusicStoreApp.ViewModel.BaseViewModel" />
    public class SingerViewModel : BaseViewModel
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }
    }
}