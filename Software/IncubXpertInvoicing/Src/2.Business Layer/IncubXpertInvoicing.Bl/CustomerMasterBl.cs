using IncubXpertInvoicing.Cmn.AppUtils;
using IncubXpertInvoicing.Dl.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IncubXpertInvoicing.Bl
{
    public class CustomerMasterBl
    {
        public static DataTableResponse GetCustomerMasterList(DataTableRequest dtParam)
        {
            using (var dbInvoice = new IncubXpertInvoicingDb())
            {
                IQueryable<MasterCustomer> OrdersQuery = dbInvoice.MasterCustomers.AsNoTracking();

                OrdersQuery = OrdersQuery.OrderByDescending(m => m.Id);

                var totalCount = OrdersQuery.Count();

                var OrderList = OrdersQuery.Skip(dtParam.start)
                                                    .Take(dtParam.length).ToList();

                var List = OrderList.Select(c => new[] {
                                                    c.Id.ToString(),
                                                    c.Name,
                                                    c.Address, 
                                                    c.City,
                                                    c.Pincode,
                                                    c.ContactNo,
                                                    c.EmailId});

                var dtResponse = new DataTableResponse()
                {
                    draw = dtParam.draw,
                    recordsTotal = totalCount,
                    recordsFiltered = totalCount,
                    data = List.ToList()
                };
                return dtResponse;
            }

        }
    }
}
