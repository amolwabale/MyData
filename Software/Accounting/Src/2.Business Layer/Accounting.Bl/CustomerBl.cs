using Accounting.Dl;
using Accounting.Dl.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Accounting.Bl
{
    public class CustomerBl
    {
        public static void SaveCustomer(CustomerInfo objCustomerInfo)
        {
            Dictionary<string, object> ParamDict = new Dictionary<string, object>();
            ParamDict.Add("@CompanyName", objCustomerInfo.CompanyName);
            ParamDict.Add("@CompanyOwnerName", objCustomerInfo.CompanyOwnerName);
            ParamDict.Add("@Address", objCustomerInfo.Address);
            ParamDict.Add("@Contact", objCustomerInfo.Contact);
            ParamDict.Add("@Gst", objCustomerInfo.GST);
            ParamDict.Add("@Cin", objCustomerInfo.CIN);
            ParamDict.Add("@Pan", objCustomerInfo.PAN);
            ParamDict.Add("@StateName", objCustomerInfo.StateName);
            ParamDict.Add("@StateCode", objCustomerInfo.StateCode);

            DataAccess.ExecuteNonQuery(@"
                        INSERT INTO MastersCustomer (
                                CompanyName,
                                CompanyOwnerName,
                                Address,
                                Contact,
                                GST,
                                CIN,
                                PAN,
                                StateName,
                                StateCode)
                                    VALUES (
                                        @CompanyName,
                                        @CompanyOwnerName,
                                        @Address,
                                        @Contact,
                                        @Gst,
                                        @Cin,
                                        @Pan,
                                        @StateName,
                                        @StateCode)
                        "
                , ParamDict, CommandType.Text);
        }

        public static void UpdateCustomer(CustomerInfo objCustomerInfo)
        {
            Dictionary<string, object> ParamDict = new Dictionary<string, object>();
            ParamDict.Add("@CompanyName", objCustomerInfo.CompanyName);
            ParamDict.Add("@CompanyOwnerName", objCustomerInfo.CompanyOwnerName);
            ParamDict.Add("@Address", objCustomerInfo.Address);
            ParamDict.Add("@Contact", objCustomerInfo.Contact);
            ParamDict.Add("@Gst", objCustomerInfo.GST);
            ParamDict.Add("@Cin", objCustomerInfo.CIN);
            ParamDict.Add("@Pan", objCustomerInfo.PAN);
            ParamDict.Add("@StateName", objCustomerInfo.StateName);
            ParamDict.Add("@StateCode", objCustomerInfo.StateCode);

            DataAccess.ExecuteNonQuery(@"
                        Update MastersCustomer set
                                CompanyName = @CompanyName,
                                CompanyOwnerName = @CompanyOwnerName,
                                Address = @Address,
                                Contact = @Contact,
                                GST = @Gst,
                                CIN = @Cin,
                                PAN = @Pan,
                                StateName = @StateName,
                                StateCode = @StateCode
                                      Where ID = "+ objCustomerInfo.Id 
                , ParamDict, CommandType.Text);
        }

        public static CustomerInfo GetCustomerPerId(string Id)
        {
            var objCustomerInfo = new CustomerInfo();
            Dictionary<string, object> ParamDict = new Dictionary<string, object>();
            ParamDict.Add("@Id", Id);
            var dt = DataAccess.GetTableFromQuery("SELECT * FROM MastersCustomer where ID = @Id", ParamDict, CommandType.Text);
             if(dt.Rows.Count > 0)
            {
                objCustomerInfo.Id = dt.Rows[0]["ID"].ToString();
                objCustomerInfo.CompanyName = dt.Rows[0]["CompanyName"].ToString();
                objCustomerInfo.CompanyOwnerName = dt.Rows[0]["CompanyOwnerName"].ToString();
                objCustomerInfo.Address = dt.Rows[0]["Address"].ToString();
                objCustomerInfo.Contact = dt.Rows[0]["Contact"].ToString();
                objCustomerInfo.GST = dt.Rows[0]["GST"].ToString();
                objCustomerInfo.CIN = dt.Rows[0]["CIN"].ToString();
                objCustomerInfo.PAN = dt.Rows[0]["PAN"].ToString();
                objCustomerInfo.StateName = dt.Rows[0]["StateName"].ToString();
                objCustomerInfo.StateCode = dt.Rows[0]["StateCode"].ToString();
            }
            return objCustomerInfo;
        }

        public static void DeleteCustomer(string Id)
        {
            DataAccess.ExecuteNonQuery("Delete FROM MastersCustomer where ID = " + Id, null, CommandType.Text);
        }
    }
}

           