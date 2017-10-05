using IncubXpertInvoicing.Cmn.AppUtils;
using IncubXpertInvoicing.Dl.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IncubXpertInvoicing.Bl
{
    public class OrderBl
    {

        public static DataTableResponse GetClientAuditTableList(DataTableRequest dtParam)
        {
            using (var dbInvoice = new IncubXpertInvoicingDb())
            {
                IQueryable<Order> OrdersQuery = dbInvoice.Orders.AsNoTracking();

                OrdersQuery = OrdersQuery.OrderByDescending(m => m.Id);

                var totalCount = OrdersQuery.Count();

                var OrderList = OrdersQuery.Skip(dtParam.start)
                                                    .Take(dtParam.length).ToList();

                var List = OrderList.Select(c => new[] {
                                                    c.Id.ToString(),
                                                    c.OrderDate,
                                                    c.ScheduledDeliveryDate.ToString(), 
                                                    c.TotalGst.ToString()});

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
