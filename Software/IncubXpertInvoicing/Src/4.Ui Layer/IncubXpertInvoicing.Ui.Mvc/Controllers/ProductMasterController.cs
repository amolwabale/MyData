using IncubXpertInvoicing.Bl;
using IncubXpertInvoicing.Cmn.AppUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IncubXpertInvoicing.Ui.Mvc.Controllers
{
    public class ProductMasterController : Controller
    {
        //
        // GET: /ProductMaster/

        public ActionResult Index()
        {
            return View("ProductMasterSearch");
        }

        public ActionResult ProductMasterDetail()
        {
            return View("ProductMasterDetail");
        }

        public JsonResult GetProductMasterList(DataTableRequest dtParam)
        {
            var dtResponse = ProductMasterBl.GetProductMasterList(dtParam);
            return Json(dtResponse, JsonRequestBehavior.AllowGet);
        }

    }
}
