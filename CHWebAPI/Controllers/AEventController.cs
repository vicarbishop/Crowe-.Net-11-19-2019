using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CHWebAPI.Controllers
{
    public class AEventController : Controller
    {
        //
        // GET: /Event/
        //http://localhost:51474/AEvent/AEvent
        public ActionResult AEvent()
        {
            return View("AEventV");
        }

    }
}
