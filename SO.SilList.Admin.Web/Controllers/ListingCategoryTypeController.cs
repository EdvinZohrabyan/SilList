﻿using SO.SilList.Manager.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SO.SilList.Admin.Web.Controllers
{
    public class ListingCategoryTypeController : Controller
    {
        private ListingCategoryTypeManager listingCategoryTypeManager = new ListingCategoryTypeManager();

        //
        // GET: /ListingCategoryType/

        public ActionResult Index()
        {
            return View();
        }


        public ActionResult List()
        {
            var results = listingCategoryTypeManager.getAll(null);
            return PartialView(results);
        }


        public ActionResult Menu()
        {
           return PartialView("../Listing/_Menu");
        }
    }
}
