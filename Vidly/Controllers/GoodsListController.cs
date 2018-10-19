using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Vidly.Controllers
{
    public class GoodsListController : Controller
    {
        // GET: GoodsList
        [Route("GoodsList/List")]
        // The View MUST be the same as the function name.
        public ActionResult GoodsList()
        {
            return View();
        }
    }
}