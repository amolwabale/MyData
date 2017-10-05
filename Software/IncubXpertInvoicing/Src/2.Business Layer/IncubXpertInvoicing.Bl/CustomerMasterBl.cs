using IncubXpertInvoicing.Cmn.AppUtils;
using IncubXpertInvoicing.Dl.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.Migrations;

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

        public static void SaveCustomerMaster(MasterCustomer objMasterCustomer)
        {
            using (var dbInvoice = new IncubXpertInvoicingDb())
            {
                dbInvoice.MasterCustomers.AddOrUpdate(objMasterCustomer);
                dbInvoice.SaveChanges();
            }
        }

        public static void DeleteCustomer(int Id)
        {
            using (var dbInvoice = new IncubXpertInvoicingDb())
            {
                var query = from s in dbInvoice.MasterCustomers
                            where s.Id == Id
                            select s;
                var result = query.FirstOrDefault();
                if (result != null)
                {
                    dbInvoice.MasterCustomers.Remove(result);
                    dbInvoice.SaveChanges();
                }
            }
        }

        public static MasterCustomer GetCustomer(int Id)
        {
            using (var dbInvoice = new IncubXpertInvoicingDb())
            {
                var query = from s in dbInvoice.MasterCustomers
                            where s.Id == Id
                            select s;
                var result = query.FirstOrDefault();
                return result;
            }
        }
    }
}
