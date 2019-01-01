using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyApp.Models;
using VidlyApp.ViewModels;

namespace VidlyApp.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Customer
        //vidly/customers
        public ViewResult Index()
        {

            //var customers = _context.Customers.ToList();
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();

            var viewModel = new CustomerMovieViewModel
            {
                Customer = customers,
                //Movies = new Movies() {Id = 1, Name = "Bunny The Bunny"}
            };
            return View(viewModel);

        }

        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
            return RedirectToAction("Index", "Customers");
        }

        //vidly/details/id/name
        public ActionResult Details(int id)
        {
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);

        }


        [HttpDelete]
        public ActionResult Delete(int id)
        {
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);


            _context.Remove(customer);
            _context.SaveChanges();


            return View("Index");
        }

        public ActionResult New()
        {
            var membershipTypes = _context.MembershipType.ToList();
            var viewModel = new NewCustomerViewModel
            {
                MembershipTypes = membershipTypes
            };
            return View("New", viewModel);



        }
    }
}