using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDeveloper.DataAccess;

namespace WebDeveloper.Areas.Personal.Controllers
{
    public class AddressController : Controller
    {
        private AddressRepository _address;
        // GET: Personal/Address
        public AddressController(AddressRepository address)
        {
            _address = address;
        }

        public ActionResult Index()
        {
            return View(_address.GetListDto());
        }
    }
}