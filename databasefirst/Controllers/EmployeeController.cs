using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using databasefirst.Models;

namespace databasefirst.Controllers
{
    public class EmployeeController : Controller
    {
        private databasefirstContext employee;
        public EmployeeController(databasefirstContext db )
        {
            this.employee = db;
        }
        public IActionResult Index()
        {
            List<Employee> emp = employee.Employees.ToList();
            return View(emp);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create( Employee emp)
        {
           if (ModelState.IsValid)
            { 
            employee.Employees.Add(emp);
            employee.SaveChanges();
            return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        public IActionResult Delete(int id)
        {
            var emp = employee.Employees.SingleOrDefault(e => e.Id == id);
            if (emp != null)
            {
                employee.Employees.Remove(emp);
                employee.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index");
            }
            
        }

        public IActionResult Edit(int id)
        {
            var emp = employee.Employees.SingleOrDefault(e => e.Id == id);
            return View(emp);
        }

        [HttpPost]
        public IActionResult Edit(Employee emp)
        {
            employee.Employees.Update(emp);
            employee.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
