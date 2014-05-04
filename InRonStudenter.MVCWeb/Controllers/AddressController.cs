﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using InRonStudenter.ModelLibrary;
using InRonStudenter.ModelLibrary.EFContext;

namespace InRonStudenter.MVCWeb.Controllers
{
    public class AddressController : Controller
    {
        private StudenterContext db = new StudenterContext();

        // GET: /Address/
        public async Task<ActionResult> Index()
        {
            return View(await db.Addresses.ToListAsync());
        }

        // GET: /Address/Details/5
        public async Task<ActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Address address = await db.Addresses.FindAsync(id);
            if (address == null)
            {
                return HttpNotFound();
            }
            return View(address);
        }

        // GET: /Address/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Address/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include="AddressID,StreetAddress,Area,CityTownVillage,State,Country,AddressPINCode,ContactNumber,Email")] Address address)
        {
            if (ModelState.IsValid)
            {
                address.AddressID = Guid.NewGuid();
                db.Addresses.Add(address);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(address);
        }

        // GET: /Address/Edit/5
        public async Task<ActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Address address = await db.Addresses.FindAsync(id);
            if (address == null)
            {
                return HttpNotFound();
            }
            return View(address);
        }

        // POST: /Address/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include="AddressID,StreetAddress,Area,CityTownVillage,State,Country,AddressPINCode,ContactNumber,Email")] Address address)
        {
            if (ModelState.IsValid)
            {
                db.Entry(address).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(address);
        }

        // GET: /Address/Delete/5
        public async Task<ActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Address address = await db.Addresses.FindAsync(id);
            if (address == null)
            {
                return HttpNotFound();
            }
            return View(address);
        }

        // POST: /Address/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(Guid id)
        {
            Address address = await db.Addresses.FindAsync(id);
            db.Addresses.Remove(address);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
