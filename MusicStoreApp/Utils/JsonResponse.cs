using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicStoreApp.Utils
{
    /// <summary>
    /// JsonResponse
    /// </summary>
    public class JsonResponse
    {
        /// <summary>
        /// Gets or sets the success.
        /// </summary>
        /// <value>
        /// The success.
        /// </value>
        public int Success { get; set; }
        /// <summary>
        /// Gets or sets the failure.
        /// </summary>
        /// <value>
        /// The failure.
        /// </value>
        public int Failure { get; set; }
        /// <summary>
        /// Gets or sets the nologin.
        /// </summary>
        /// <value>
        /// The nologin.
        /// </value>
        public int Nologin { get; set; }
        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public object Data { get; set; }
    }
}