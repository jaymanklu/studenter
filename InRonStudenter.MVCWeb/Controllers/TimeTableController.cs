using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using InRonStudenter.ModelLibrary;

namespace InRonStudenter.MVCWeb.Controllers
{
    public class TimeTableController : Controller
    {
        private StudenterContext db = new StudenterContext();

        // GET: /TimeTable/
        public async Task<ActionResult> Index()
        {
            return View(await db.TimeTables.ToListAsync());
        }

        // GET: /TimeTable/Details/5
        public async Task<ActionResult> Details(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TimeTable timetable = await db.TimeTables.FindAsync(id);
            if (timetable == null)
            {
                return HttpNotFound();
            }
            return View(timetable);
        }

        // GET: /TimeTable/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /TimeTable/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include="TimeTableID,Class")] TimeTable timetable)
        {
            if (ModelState.IsValid)
            {
                db.TimeTables.Add(timetable);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(timetable);
        }

        // GET: /TimeTable/Edit/5
        public async Task<ActionResult> Edit(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TimeTable timetable = await db.TimeTables.FindAsync(id);
            if (timetable == null)
            {
                return HttpNotFound();
            }
            return View(timetable);
        }

        // POST: /TimeTable/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include="TimeTableID,Class")] TimeTable timetable)
        {
            if (ModelState.IsValid)
            {
                db.Entry(timetable).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(timetable);
        }

        // GET: /TimeTable/Delete/5
        public async Task<ActionResult> Delete(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TimeTable timetable = await db.TimeTables.FindAsync(id);
            if (timetable == null)
            {
                return HttpNotFound();
            }
            return View(timetable);
        }

        // POST: /TimeTable/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(short id)
        {
            TimeTable timetable = await db.TimeTables.FindAsync(id);
            db.TimeTables.Remove(timetable);
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
