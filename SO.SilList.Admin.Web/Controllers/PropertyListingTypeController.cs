﻿using SO.SilList.Manager.Managers;
using SO.SilList.Manager.Models.ValueObjects;
using SO.SilList.Manager.Models.ViewModels;
using SO.SilList.Utility.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SO.SilList.Admin.Web.Controllers
{
    public class PropertyListingTypeController : Controller
    {
        //
        // GET: /LeaseTermType/

        private LeaseTermTypeManager leaseTermTypeManager = new LeaseTermTypeManager();

        public ActionResult Index(PropertyListingTypeVm input = null, Paging paging = null)
        {
            if (input == null) input = new PropertyListingTypeVm();
            input.paging = paging;
            if (this.ModelState.IsValid)
            {
                if (input.submitButton != null)
                    input.paging.pageNumber = 1;
                input = leaseTermTypeManager.search(input);
                return View(input);
            }
            return View();
        }

        public ActionResult List()
        {
            var results = leaseTermTypeManager.getAll(null);
            return PartialView(results);
        }

        [HttpPost]
        public ActionResult Edit(int id, PropertyListingTypeVo input)
        {

            if (this.ModelState.IsValid)
            {
                var res = leaseTermTypeManager.update(input, id);
                return RedirectToAction("Index");
            }

            return View();

        }
        public ActionResult Edit(int id)
        {
            var result = leaseTermTypeManager.get(id);
            return View(result);
        }

        [HttpPost]
        public ActionResult Create(PropertyListingTypeVo input)
        {

            if (this.ModelState.IsValid)
            {

                var item = leaseTermTypeManager.insert(input);
                return RedirectToAction("Index");
            }


            return View();

        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Details(int id)
        {
            var result = leaseTermTypeManager.get(id);
            return View(result);
        }

        public ActionResult Menu()
        {
            return PartialView("../Rental/_Menu");
        }

        public ActionResult Delete(int id)
        {
            leaseTermTypeManager.delete(id);
            return RedirectToAction("Index");
        }
        public ActionResult DropDownList(int? id = null, string propertyName = null, string defaultValue = null)
        {
            ViewBag.leaseTermTypes = leaseTermTypeManager.getAll(null);
            var leaseType = new PropertyListingTypeVo();
            if (id != null)
            {
                leaseType = leaseTermTypeManager.get(id.Value);
            }

            if (propertyName == null)
                propertyName = "leaseTypeId";
            ViewBag.propertyName = propertyName;
            if (defaultValue == null)
                defaultValue = "Select One";
            ViewBag.defaultValue = defaultValue;
            return PartialView("_DropDownList", leaseType);
        }
        public ActionResult Filter(PropertyListingTypeVm Input)
        {
            return PartialView("_Filter", Input);
        }
        public ActionResult Pagination(Paging input)
        {
            return PartialView("_Pagination", input);
        }
    }
}