using Accounting.Dl;
using Accounting.Dl.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Accounting.Bl
{
    public class InvoiceBl
    {
        public static void SaveCustomer(InvoiceMasterInfo objInvoiceMasterInfo)
        {

           


            Dictionary<string, object> ParamDict = new Dictionary<string, object>();
            ParamDict.Add("@InvoiceDate", objInvoiceMasterInfo.InvoiceDate);
            ParamDict.Add("@BilledTo", objInvoiceMasterInfo.BilledTo);
            ParamDict.Add("@ShippedTo", objInvoiceMasterInfo.ShippedTo);
            ParamDict.Add("@Discount", objInvoiceMasterInfo.Discount);
            ParamDict.Add("@OtherCharges", objInvoiceMasterInfo.OtherCharges);
            ParamDict.Add("@TransportMode", objInvoiceMasterInfo.TransportMode);
            ParamDict.Add("@VehicleNumber", objInvoiceMasterInfo.VehicleNumber);
            ParamDict.Add("@PoNum", objInvoiceMasterInfo.PoNum);
            ParamDict.Add("@PoDate", objInvoiceMasterInfo.PoDate);

            DataAccess.ExecuteNonQuery(@"
                        INSERT INTO InvoiceMaster (
                                InvoiceDate,
                                BilledTo,
                                ShippedTo,
                                Discount,
                                OtherCharges,
                                TransportMode,
                                VehicleNumber,
                                PoNum,
                                PoDate)
                                    VALUES (
                                        @InvoiceDate,
                                        @BilledTo,
                                        @ShippedTo,
                                        @Discount,
                                        @OtherCharges,
                                        @TransportMode,
                                        @VehicleNumber,
                                        @PoNum,
                                        @PoDate)
                        "
                , ParamDict, CommandType.Text);

            var A = DataAccess.GetTableFromQuery("SELECT @@Identity", null, CommandType.Text);
        }
    }
}
