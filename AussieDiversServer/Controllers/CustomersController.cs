using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Owin;
using AussieDiversServer.Models;
using AussieDiversDataMapping;
using AussieDiversDataMapping.Models;

namespace AussieDiversServer.Controllers
{
    public class CustomersController : ApiController
    {
        private ApplicationUserManager _userManager;

        public CustomersController()
        {
        }

        public CustomersController(ApplicationUserManager userManager)
        {
            UserManager = userManager;
        }

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }

        // GET api/Me
        public IHttpActionResult Get()
        {
            var repository = new CustomerRepository();
            IList<Person> people = repository.getCustomers();
            return Json(people);
        }
    }
}