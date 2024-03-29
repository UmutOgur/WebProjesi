﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreSeminerWeb.Models;
using CoreSeminerWeb.Providers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreSeminerWeb.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        [AllowAnonymous]
        // GET: Product
        public ActionResult Index(int id = 0)
        {
            ApiProvider api = new ApiProvider();
            PagingModel model = api.GetService(id, 10);
            ViewData["id"] = id;
            return View(model);
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            ApiProvider api = new ApiProvider();
            return View(api.GetService(id));
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductModel model)
        {
            if(ModelState.IsValid)
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Product/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Product/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}