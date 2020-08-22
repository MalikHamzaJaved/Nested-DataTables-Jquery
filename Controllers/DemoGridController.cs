using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoDataGridForSaad.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Dynamic.Core;
using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;

namespace DemoDataGridForSaad.Controllers
{
    public class DemoGridController : Controller
    {
        private ApplicationDbContext _context;

        public DemoGridController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult ShowGrid()
        {
            return View();
        }

        public IActionResult Edit(int  id)
        {

            return View();
        }

        public IActionResult LoadDataTest()
        {
            //For Test person either you can use this saad bhai yahan data backened say json form main arha hai or front end pay bhi demo data dala hoa hai you can test for that as well.
            try
            {
                var customerData = (from tempcustomer in _context.CustomerTB select tempcustomer);
                var data = customerData.Include(x => x.family).ToList();
                return Json(new { data = data });

            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
