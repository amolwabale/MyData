using IncubXpertInvoicing.Bl;
using IncubXpertInvoicing.Cmn.AppUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IncubXpertInvoicing.Ui.Mvc.Controllers
{
    public class OrderController : Controller
    {
        //
        // GET: /Order/

        public ActionResult Index()
        {
            return View("OrderSearch");
        }

        public ActionResult OrderDetail()
        {
            return View("OrderDetail");
        }

        public JsonResult GetOrderList( DataTableRequest dtParam)
        {
            var dtResponse = OrderBl.GetOrderList(dtParam);
            return Json(dtResponse, JsonRequestBehavior.AllowGet);
        }

    }
}
