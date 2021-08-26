using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AspNetCoreAppRolesFineGrainedApi.WebApp.Models;
using AspNetCoreAppRolesFineGrainedApi.WebApp.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Identity.Web;

namespace AspNetCoreAppRolesFineGrainedApi.Controllers
{
    [Authorize]
    [AuthorizeForScopes(ScopeKeySection = "AspNetCoreAppRolesFineGrainedApi.Api:SaleScope")]
    public class SalesController : Controller
    {
        private readonly ISaleApiService saleApiService;
        public SalesController(ISaleApiService saleApiService)
        {
           this.saleApiService = saleApiService; 
        }

        // GET: Sales
        // public async Task<IActionResult> Index()
        // {
        //     var AspNetCoreAppRolesFineGrainedApiDbContext = _context.Sales.Include(s => s.Employee);
        //     return View(await AspNetCoreAppRolesFineGrainedApiDbContext.ToListAsync());
        // }

        // // GET: Sales/Details/5
        // public async Task<IActionResult> Details(int? id)
        // {
        //     if (id == null)
        //     {
        //         return NotFound();
        //     }

        //     var sale = await _context.Sales
        //         .Include(s => s.Employee)
        //         .FirstOrDefaultAsync(m => m.SaleID == id);
        //     if (sale == null)
        //     {
        //         return NotFound();
        //     }

        //     return View(sale);
        // }

        // // GET: Sales/Create
        // public IActionResult Create()
        // {
        //     ViewData["EmployeeID"] = new SelectList(_context.Employees, "EmployeeID", "EmployeeID");
        //     return View();
        // }

        // // POST: Sales/Create
        // // To protect from overposting attacks, enable the specific properties you want to bind to.
        // // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        // [HttpPost]
        // [ValidateAntiForgeryToken]
        // public async Task<IActionResult> Create([Bind("SaleID,EmployeeID,Value")] Sale sale)
        // {
        //     if (ModelState.IsValid)
        //     {
        //         _context.Add(sale);
        //         await _context.SaveChangesAsync();
        //         return RedirectToAction(nameof(Index));
        //     }
        //     ViewData["EmployeeID"] = new SelectList(_context.Employees, "EmployeeID", "EmployeeID", sale.EmployeeID);
        //     return View(sale);
        // }

        // // GET: Sales/Edit/5
        // public async Task<IActionResult> Edit(int? id)
        // {
        //     if (id == null)
        //     {
        //         return NotFound();
        //     }

        //     var sale = await _context.Sales.FindAsync(id);
        //     if (sale == null)
        //     {
        //         return NotFound();
        //     }
        //     ViewData["EmployeeID"] = new SelectList(_context.Employees, "EmployeeID", "EmployeeID", sale.EmployeeID);
        //     return View(sale);
        // }

        // // POST: Sales/Edit/5
        // // To protect from overposting attacks, enable the specific properties you want to bind to.
        // // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        // [HttpPost]
        // [ValidateAntiForgeryToken]
        // public async Task<IActionResult> Edit(int id, [Bind("SaleID,EmployeeID,Value")] Sale sale)
        // {
        //     if (id != sale.SaleID)
        //     {
        //         return NotFound();
        //     }

        //     if (ModelState.IsValid)
        //     {
        //         try
        //         {
        //             _context.Update(sale);
        //             await _context.SaveChangesAsync();
        //         }
        //         catch (DbUpdateConcurrencyException)
        //         {
        //             if (!SaleExists(sale.SaleID))
        //             {
        //                 return NotFound();
        //             }
        //             else
        //             {
        //                 throw;
        //             }
        //         }
        //         return RedirectToAction(nameof(Index));
        //     }
        //     ViewData["EmployeeID"] = new SelectList(_context.Employees, "EmployeeID", "EmployeeID", sale.EmployeeID);
        //     return View(sale);
        // }

        // // GET: Sales/Delete/5
        // public async Task<IActionResult> Delete(int? id)
        // {
        //     if (id == null)
        //     {
        //         return NotFound();
        //     }

        //     var sale = await _context.Sales
        //         .Include(s => s.Employee)
        //         .FirstOrDefaultAsync(m => m.SaleID == id);
        //     if (sale == null)
        //     {
        //         return NotFound();
        //     }

        //     return View(sale);
        // }

        // // POST: Sales/Delete/5
        // [HttpPost, ActionName("Delete")]
        // [ValidateAntiForgeryToken]
        // public async Task<IActionResult> DeleteConfirmed(int id)
        // {
        //     var sale = await _context.Sales.FindAsync(id);
        //     _context.Sales.Remove(sale);
        //     await _context.SaveChangesAsync();
        //     return RedirectToAction(nameof(Index));
        // }

        // private bool SaleExists(int id)
        // {
        //     return _context.Sales.Any(e => e.SaleID == id);
        // }
    }
}
