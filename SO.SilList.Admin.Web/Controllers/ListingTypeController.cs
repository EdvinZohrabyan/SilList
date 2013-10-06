﻿using SO.SilList.Manager.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SO.SilList.Manager.Models.ValueObjects;
using SO.SilList.Manager.Models.ViewModels;
using SO.SilList.Utility.Classes;

namespace SO.SilList.Admin.Web.Controllers
{
    public class ListingTypeController : Controller
    {
        private ListingTypeManager listingTypeManager = new ListingTypeManager();

        public ActionResult Index(ListingTypeVm input = null, Paging paging = null)
        {
            if (input == null) input = new ListingTypeVm();
            input.paging = paging;
            if (this.ModelState.IsValid)
            {
                if (input.submitButton != null)
                    input.paging.pageNumber = 1;
                input = listingTypeManager.search(input);
                return View(input);
            }

            return View();
        }

        public ActionResult Filter(ListingTypeVm input)
        {
            return PartialView("_Filter", input);
        }

        public ActionResult List()
        {
            var results = listingTypeManager.getAll(null);
            return PartialView(results);
        }


        public ActionResult Menu()
        {
            return PartialView("../Listing/_Menu");
        }


        [HttpPost]
        public ActionResult Create(ListingTypeVo input)
        {

            if (this.ModelState.IsValid)
            {

                var item = listingTypeManager.insert(input);
                return RedirectToAction("Index");
            }

            return View();

        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(int id, ListingTypeVo input)
        {

            if (this.ModelState.IsValid)
            {
                var res = listingTypeManager.update(input, id);
                return RedirectToAction("Index");
            }

            return View();

        }
        public ActionResult Edit(int id)
        {
            var result = listingTypeManager.get(id);
            return View(result);
        }

        public ActionResult Details(int id)
        {
            var result = listingTypeManager.get(id);
            return View(result);
        }

        public ActionResult Pagination(Paging input)
        {
            return PartialView("_Pagination", input);
        }

        public ActionResult Delete(int id)
        {
            listingTypeManager.delete(id);
            return RedirectToAction("Index");
        }

        public ActionResult DropDownList(int? id = null)
        {
            ViewBag.listingTypes = listingTypeManager.getAll(null);
            var listingType = new ListingTypeVo();
            if (id != null)
            {
                listingType = listingTypeManager.get(id.Value);
            }
            return PartialView("_DropDownList", listingType);
        }

    }
}