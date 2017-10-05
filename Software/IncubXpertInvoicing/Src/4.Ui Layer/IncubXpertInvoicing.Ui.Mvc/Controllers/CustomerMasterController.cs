using IncubXpertInvoicing.Bl;
using IncubXpertInvoicing.Cmn.AppUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IncubXpertInvoicing.Ui.Mvc.Controllers
{
    public class CustomerMasterController : Controller
    {
        //
        // GET: /CustomerMaster/

        public ActionResult Index()
        {
            return View("CustomerMasterSearch");
        }

        public ActionResult CustomerMasterDetail()
        {
            return View("CustomerMasterDetail");
        }

        public JsonResult GetCustomerMasterList(DataTableRequest dtParam)
        {
            var dtResponse = CustomerMasterBl.GetCustomerMasterList(dtParam);
            return Json(dtResponse, JsonRequestBehavior.AllowGet);
        }

    }
}
