using IncubXpertInvoicing.Bl;
using IncubXpertInvoicing.Cmn.AppUtils;
using IncubXpertInvoicing.Dl.Context;
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
            return View("CustomerMasterDetail", new MasterCustomer());
        }

        public JsonResult GetCustomerMasterList(DataTableRequest dtParam)
        {
            var dtResponse = CustomerMasterBl.GetCustomerMasterList(dtParam);
            return Json(dtResponse, JsonRequestBehavior.AllowGet);
        }

        public ActionResult SaveCustomerMaster(MasterCustomer objMasterCustomer)
        {
            if(ModelState.IsValid)
            {
                CustomerMasterBl.SaveCustomerMaster(objMasterCustomer);
                return Redirect("~/CustomerMaster");
            }
            else
            {
                return View("CustomerMasterDetail", objMasterCustomer);
            }
        }

        public ActionResult DeleteCustomer(int Id)
        {
            CustomerMasterBl.DeleteCustomer(Id);
            return Redirect("~/CustomerMaster");
        }

        public ActionResult ViewCustomer(int Id)
        {
            var cust = CustomerMasterBl.GetCustomer(Id);
            return View("CustomerMasterDetail", cust);
        }

    }
}
