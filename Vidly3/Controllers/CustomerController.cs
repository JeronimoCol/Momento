using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Mvc;
using Vidly3.Models;
using Vidly3.ViewModels;

namespace Vidly3.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext _context;

        public CustomerController()
        {
           _context =  new ApplicationDbContext();
        }

        public ActionResult Index()
        {
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();

            return View(customers);
        }

        public ActionResult New()
        {
            var membershipTypes = _context.MembershipTypes.ToList();
            var viewModel = new CustomerFormViewModel()
            {
                MembershipTypes = membershipTypes
            };
            return View("CustomerForm",viewModel);
        }

        [HttpPost]
        public ActionResult Create(Customer newCustomer)
        {
            _context.Customers.Add(newCustomer);
            _context.SaveChanges();

            return RedirectToAction("Index", "Customer");
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Customer
        //public ActionResult All()
        //{
        //    var customers = new List<Customer>()
        //    {
        //        new Customer {Name = "Lauren Jamensson"},
        //        new Customer {Name = "Jeronimo Colombo"},
        //        new Customer {Name = "Naomi Shiu"}
        //    };

        //    return View(customers);
        //}

        public ActionResult Details(int id)
        {
            var customer = _context.Customers.Include(x => x.MembershipType).ToList().SingleOrDefault(c => c.Id == id);

            return View(customer);
        }

        public ActionResult DetailsTest(int id)
        {
            string result = "";
            bool encontro = false;
            int posicion = 0;

            var customers = new List<Customer>()
            {
                new Customer {Name = "Lauren Jamensson", Id = 1},
                new Customer {Name = "Jeronimo Colombo", Id = 2},
                new Customer {Name = "Naomi Shiu", Id = 3}
            };

            for (int i = 0; i < customers.Count() && !encontro; i++)
            {
                if (customers[i].Id == id)
                {
                    encontro = true;
                    result = customers[i].Name;
                    posicion = i;
                }
            }

            if (encontro)
                return View ("All", new List<Customer>() { customers[posicion] } );
            else
                return View("All", new List<Customer>()
                {
                    new Customer()
                    {Name = "No se ha encontrado ningun cliente con el id " + id }
                });
        }

        public ViewResult All()
        {
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();

            return View(customers);

        }

        public ActionResult Edit(int id)
        {
            var cust = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (cust == null) return HttpNotFound();

            var viewModel = new CustomerFormViewModel
            {
                Customer = cust,
                MembershipTypes = _context.MembershipTypes.ToList()
            };

            return View("CustomerForm", viewModel); 
        }



        

        

    }
}