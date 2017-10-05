using IncubXpertInvoicing.Cmn.AppUtils;
using IncubXpertInvoicing.Dl.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IncubXpertInvoicing.Bl
{
    public class ProductMasterBl
    {
        public static DataTableResponse GetProductMasterList(DataTableRequest dtParam)
        {
            using (var dbInvoice = new IncubXpertInvoicingDb())
            {
                IQueryable<MasterProduct> MasterProductQuery = dbInvoice.MasterProducts.AsNoTracking();

                MasterProductQuery = MasterProductQuery.OrderByDescending(m => m.Id);

                var totalCount = MasterProductQuery.Count();

                var OrderList = MasterProductQuery.Skip(dtParam.start)
                                                    .Take(dtParam.length).ToList();

                var List = OrderList.Select(c => new[] {
                                                    c.Id.ToString(),
                                                    c.ProductName,
                                                    c.Category.ToString(), 
                                                    c.Rate.ToString(),
                                                    c.GstRate.ToString()});

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
