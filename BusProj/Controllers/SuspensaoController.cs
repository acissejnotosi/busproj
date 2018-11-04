using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BusCore.Controllers
{
    public class SuspensaoController : Controller
    {
        // GET: RPN
        public ActionResult Index()
        {
            return View();
        }

        // GET: RPN/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RPN/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RPN/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RPN/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RPN/Edit/5
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

        // GET: RPN/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RPN/Delete/5
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