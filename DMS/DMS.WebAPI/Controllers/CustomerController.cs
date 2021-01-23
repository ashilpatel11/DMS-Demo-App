using DMS.Business.Interface;
using DMS.BusinessEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DMS.WebAPI.Controllers
{
    public class CustomerController : ApiController
    {
        private ICustomerManager _customerManager;

        public CustomerController() { }

        public CustomerController(ICustomerManager customerManager)
        {
            _customerManager = customerManager;
        }

        public IHttpActionResult GetAllCustomers()
        {
            var customers = _customerManager.GetAllCustomers();
            if (customers == null)
            {
                return NotFound();
            }
            return Ok(customers);
        }

        public IHttpActionResult GetCustomer(int id)
        {
            var user = _customerManager.GetCustomer(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        public bool InsertUser(CustomerViewModel customerView)
        {
            return _customerManager.InsertCustomer(customerView);
        }

        public bool UpdateUser(CustomerViewModel customerView)
        {
            return _customerManager.UpdateCustomer(customerView);
        }

        public bool DeleteUser(int id)
        {
            return _customerManager.DeleteCustomer(id);
        }
    }
}
