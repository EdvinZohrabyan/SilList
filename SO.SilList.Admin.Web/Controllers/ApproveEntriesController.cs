﻿using SO.SilList.Manager.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SO.SilList.Manager.Managers;
using SO.SilList.Manager.Models.ValueObjects;
using SO.SilList.Utility.Classes;
using SO.SilList.Manager.Models.ViewModels;

namespace SO.SilList.Admin.Web.Controllers
{
    public class ApproveEntriesController : Controller
    {
        private ApproveEntriesManager approveEntriesManager = new ApproveEntriesManager();

        public ActionResult Index(ApproveEntriesVm input = null, Paging paging = null)
        {
            if (input == null)
                input = new ApproveEntriesVm();
            input.paging = paging;
            if (this.ModelState.IsValid)
            {
                if (input.submitButton != null)
                    input.paging.pageNumber = 1;
                input = approveEntriesManager.search(input);
                return View(input);
            }
            return View();
        }


        public ActionResult _List()
        {
            var results = approveEntriesManager.getAll(null);
            return PartialView(results);
            //return PartialView("_List", results);
        }

        //[DontTrackVisit]
        //public ActionResult DropDownList(Guid? id = null,string propertyName = null,string defaultValue = null)
        //{
        //    ViewBag.sites = approveEntriesManager.getAll(null);
        //    //var site = new JobVo();
        //    //if (id != null)
        //    //{
        //    //    job = approveEntriesManager.get(id.Value);
        //    //}
        //    if (propertyName == null)
        //        propertyName = "siteId";
        //    ViewBag.propertyName = propertyName;
        //    if (defaultValue == null)
        //        defaultValue = "Select One";
        //    ViewBag.defaultValue = defaultValue;

        //    return PartialView("_DropDownList", site);
        //}

        [DontTrackVisit]
        public ActionResult Menu()
        {
            return PartialView("_Menu");
        }

        public ActionResult Details(Guid id)
        {
            var result = approveEntriesManager.get(id);
            return View(result);
        }
        [HttpPost]
        public ActionResult Edit(Guid id, JobVo input)
        {
            if (this.ModelState.IsValid)
            {
                var res = approveEntriesManager.update(input, id);
                return RedirectToAction("Index");
            }

            return View();

        }
        public ActionResult Edit(Guid id)
        {
            var result = approveEntriesManager.get(id);
            return View(result);
        }

        public ActionResult Delete(Guid id)
        {
            approveEntriesManager.delete(id);
            return RedirectToAction("Index");
        }

        public ActionResult Pagination(Paging input)
        {
            return PartialView("_Pagination", input);
        }

        public ActionResult Filter(ApproveEntriesVm input)
        {
            return PartialView("_Filter", input);
        }
    }    
}
