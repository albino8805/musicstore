using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicStoreApp.ViewModel
{
    /// <summary>
    /// AlbumViewModel
    /// </summary>
    /// <seealso cref="MusicStoreApp.ViewModel.BaseViewModel" />
    public class AlbumViewModel : BaseViewModel
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the year.
        /// </summary>
        /// <value>
        /// The year.
        /// </value>
        public Nullable<int> Year { get; set; }
        /// <summary>
        /// Gets or sets the price sale.
        /// </summary>
        /// <value>
        /// The price sale.
        /// </value>
        public Nullable<decimal> PriceSale { get; set; }
        /// <summary>
        /// Gets or sets the singer fk.
        /// </summary>
        /// <value>
        /// The singer fk.
        /// </value>
        public int SingerFK { get; set; }
        /// <summary>
        /// Gets or sets the category fk.
        /// </summary>
        /// <value>
        /// The category fk.
        /// </value>
        public int CategoryFK { get; set; }
        /// <summary>
        /// Gets or sets the category.
        /// </summary>
        /// <value>
        /// The category.
        /// </value>
        public CategoryViewModel Category { get; set; }
        /// <summary>
        /// Gets or sets the singer.
        /// </summary>
        /// <value>
        /// The singer.
        /// </value>
        public SingerViewModel Singer { get; set; }
    }
}