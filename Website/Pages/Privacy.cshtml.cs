/*
 * Author: Riley Smith
 * Class: Privacy.cshtml.cs
 * Purpose: Contains the functionality for the Privacy page. 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Website.Pages
{
    public class PrivacyModel : PageModel
    {
        /// <summary>
        /// A readonly logger.
        /// </summary>
        private readonly ILogger<PrivacyModel> _logger;

        /// <summary>
        /// Sets _logger equal to a new ILogger.
        /// </summary>
        /// <param name="logger"></param>
        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Method that's called upon starting up this page.
        /// </summary>
        public void OnGet()
        {
        }
    }
}
