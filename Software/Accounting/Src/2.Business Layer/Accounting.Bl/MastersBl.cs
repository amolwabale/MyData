using Accounting.Dl;
using Accounting.Dl.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace Accounting.Bl
{
    public class MastersBl
    {
        #region MASTERS UNIT

        public static DataTable GetMasterUnitList()
        {
            var dt = DataAccess.GetTableFromQuery("SELECT * FROM MastersUnit", null, CommandType.Text);
            return dt;
        }

        public static void AddNewUnit(string Unit)
        {
            Dictionary<string, object> ParamDict = new Dictionary<string, object>();
            ParamDict.Add("@Unit", Unit);
            DataAccess.ExecuteNonQuery("INSERT INTO MastersUnit (Unit)VALUES (@Unit)", ParamDict, CommandType.Text);
        }

        public static void DeleteUnit(string id)
        {
            Dictionary<string, object> ParamDict = new Dictionary<string, object>();
            ParamDict.Add("@Unit", id);
            DataAccess.ExecuteNonQuery("DELETE from MastersUnit where Id = @Unit", ParamDict, CommandType.Text);
        }

        public static bool IfUnitAlreadyExist(string Unit)
        {
            bool Exist = false;
            Dictionary<string, object> ParamDict = new Dictionary<string, object>();
            ParamDict.Add("@Unit", Unit);
            var dt = DataAccess.GetTableFromQuery("SELECT * FROM MastersUnit where Unit = @Unit", ParamDict, CommandType.Text);

            if (dt.Rows.Count > 0)
                Exist = true;
            return Exist;
        }
        #endregion

        #region MASTERS ITEM

        public static DataTable GetMasterItemList()
        {
            var dt = DataAccess.GetTableFromQuery("SELECT * FROM MastersItem", null, CommandType.Text);
            return dt;
        }

        public static DataTable GetFilteredItemsList(string ColumnName, string Value)
        {
            Dictionary<string, object> ParamDict = new Dictionary<string, object>();
            ParamDict.Add("@ColumnName", ColumnName);
            ParamDict.Add("@Value", Value);
            var dt = DataAccess.GetTableFromQuery("SELECT * FROM MastersItem where " + ColumnName + " like '%" + Value + "%'", null, CommandType.Text);
            return dt;
        }

        #endregion

        #region MASTERS COMPANY

        public static CompanyInfo GetCompanyInfo()
        {
            var dt = DataAccess.GetTableFromQuery("Select * from MastersCompany where Id = 1", null, CommandType.Text);
            var objCompanyInfo = new CompanyInfo();
            if (dt.Rows.Count > 0)
            {
                objCompanyInfo.Id = dt.Rows[0]["Id"].ToString();
                objCompanyInfo.CompanyName = dt.Rows[0]["CompanyName"].ToString();
                objCompanyInfo.CompanyOwnerName = dt.Rows[0]["CompanyOwnerName"].ToString();
                objCompanyInfo.Address = dt.Rows[0]["Address"].ToString();
                objCompanyInfo.Contact = dt.Rows[0]["Contact"].ToString();
                objCompanyInfo.Gst = dt.Rows[0]["Gst"].ToString();
                objCompanyInfo.Cin = dt.Rows[0]["Cin"].ToString();
                objCompanyInfo.Pan = dt.Rows[0]["Pan"].ToString();
                objCompanyInfo.StateName = dt.Rows[0]["StateName"].ToString();
                objCompanyInfo.StateCode = dt.Rows[0]["StateCode"].ToString();
                objCompanyInfo.BankName = dt.Rows[0]["BankName"].ToString();
                objCompanyInfo.BankAccountNumber = dt.Rows[0]["BankAccountNum"].ToString();
                objCompanyInfo.BankIfscNumber = dt.Rows[0]["BankIfscCode"].ToString();
                objCompanyInfo.CompanyLogo = dt.Rows[0]["CompanyLogo"].ToString();

            }
            return objCompanyInfo;
        }

        public static void SaveCompanyInfo(CompanyInfo objCompanyInfo)
        {
            Dictionary<string, object> ParamDict = new Dictionary<string, object>();
            ParamDict.Add("@CompanyName", objCompanyInfo.CompanyName);
            ParamDict.Add("@CompanyOwnerName", objCompanyInfo.CompanyOwnerName);
            ParamDict.Add("@Address", objCompanyInfo.Address);
            ParamDict.Add("@Contact", objCompanyInfo.Contact);
            ParamDict.Add("@Gst", objCompanyInfo.Gst);
            ParamDict.Add("@Cin", objCompanyInfo.Cin);
            ParamDict.Add("@Pan", objCompanyInfo.Pan);
            ParamDict.Add("@StateName", objCompanyInfo.StateName);
            ParamDict.Add("@StateCode", objCompanyInfo.StateCode);
            ParamDict.Add("@BankName", objCompanyInfo.BankName);
            ParamDict.Add("@BankAccountNumber", objCompanyInfo.BankAccountNumber);
            ParamDict.Add("@BankIfscNumber", objCompanyInfo.BankIfscNumber);
            ParamDict.Add("@CompanyLogo", objCompanyInfo.CompanyLogo);

            DataAccess.ExecuteNonQuery(@"
                        INSERT INTO MastersCompany (
                                CompanyName,
                                CompanyOwnerName,
                                Address,
                                Contact,
                                GST,
                                CIN,
                                PAN,
                                StateName,
                                StateCode,
                                BankName,
                                BankAccountNum,
                                BankIfscCode,
                                CompanyLogo)
                                    VALUES (
                                        @CompanyName,
                                        @CompanyOwnerName,
                                        @Address,
                                        @Contact,
                                        @Gst,
                                        @Cin,
                                        @Pan,
                                        @StateName,
                                        @StateCode,
                                        @BankName,
                                        @BankAccountNumber,
                                        @BankIfscNumber,
                                        @CompanyLogo)
                        "
                , ParamDict, CommandType.Text);
        }

        public static void UpdateCompanyInfo(CompanyInfo objCompanyInfo)
        {
            Dictionary<string, object> ParamDict = new Dictionary<string, object>();
            ParamDict.Add("@CompanyName", objCompanyInfo.CompanyName);
            ParamDict.Add("@CompanyOwnerName", objCompanyInfo.CompanyOwnerName);
            ParamDict.Add("@Address", objCompanyInfo.Address);
            ParamDict.Add("@Contact", objCompanyInfo.Contact);
            ParamDict.Add("@Gst", objCompanyInfo.Gst);
            ParamDict.Add("@Cin", objCompanyInfo.Cin);
            ParamDict.Add("@Pan", objCompanyInfo.Pan);
            ParamDict.Add("@StateName", objCompanyInfo.StateName);
            ParamDict.Add("@StateCode", objCompanyInfo.StateCode);
            ParamDict.Add("@BankName", objCompanyInfo.BankName);
            ParamDict.Add("@BankAccountNumber", objCompanyInfo.BankAccountNumber);
            ParamDict.Add("@BankIfscNumber", objCompanyInfo.BankIfscNumber);
            ParamDict.Add("@CompanyLogo", objCompanyInfo.CompanyLogo);

            DataAccess.ExecuteNonQuery(@"
                        UPDATE MastersCompany SET
                                CompanyName = @CompanyName,
                                CompanyOwnerName  = @CompanyOwnerName,
                                Address  = @Address,
                                Contact  = @Contact,
                                GST  = @Gst,
                                CIN  = @Cin,
                                PAN  = @Pan,
                                StateName  = @StateName,
                                StateCode  = @StateCode,
                                BankName  = @BankName,
                                BankAccountNum  = @BankAccountNum,
                                BankIfscCode  = @BankIfscCode,
                                CompanyLogo  = @CompanyLogo
                                        Where ID = 1
                                            "
                , ParamDict, CommandType.Text);
        }

        #endregion

        #region MASTERS CUSTOMERS

        public static DataTable GetMasterCustomerList()
        {
            var dt = DataAccess.GetTableFromQuery("SELECT * FROM MastersCustomer", null, CommandType.Text);
            return dt;
        }

        public static DataTable GetFilteredCustomerList(string ColumnName, string Value)
        {
            Dictionary<string, object> ParamDict = new Dictionary<string, object>();
            ParamDict.Add("@ColumnName", ColumnName);
            ParamDict.Add("@Value", Value);
            var dt = DataAccess.GetTableFromQuery("SELECT * FROM MastersCustomer where " + ColumnName + " like '%" + Value + "%'", null, CommandType.Text);
            return dt;
        }

        #endregion

        #region MASTERS TAX

        public static TaxInfo GetTaxInfo()
        {
            var dt = DataAccess.GetTableFromQuery("Select * from MastersTax where Id = 1", null, CommandType.Text);
            var objTaxInfo = new TaxInfo();
            if (dt.Rows.Count > 0)
            {
                objTaxInfo.ID = dt.Rows[0]["ID"].ToString();
                objTaxInfo.SGST = dt.Rows[0]["SGST"].ToString();
                objTaxInfo.CGST = dt.Rows[0]["CGST"].ToString();
                objTaxInfo.IGST = dt.Rows[0]["IGST"].ToString();
            }
            return objTaxInfo;
        }

        public static void SaveTaxInfo(TaxInfo objTaxInfo)
        {
            Dictionary<string, object> ParamDict = new Dictionary<string, object>();
            ParamDict.Add("@SGST", objTaxInfo.SGST);
            ParamDict.Add("@CGST", objTaxInfo.CGST);
            ParamDict.Add("@IGST", objTaxInfo.IGST);
            DataAccess.ExecuteNonQuery(@"
                        INSERT INTO MastersTax (
                                SGST,
                                CGST,
                                IGST)
                                    VALUES (
                                        @SGST,
                                        @CGST,
                                        @IGST)
                        "
          , ParamDict, CommandType.Text);
        }

        public static void UpdateTaxInfo(TaxInfo objTaxInfo)
        {
            Dictionary<string, object> ParamDict = new Dictionary<string, object>();
            ParamDict.Add("@SGST", objTaxInfo.SGST);
            ParamDict.Add("@CGST", objTaxInfo.CGST);
            ParamDict.Add("@IGST", objTaxInfo.IGST);
            DataAccess.ExecuteNonQuery(@"
                        Update MastersTax SET
                                SGST = @SGST,
                                CGST = @CGST,
                                IGST = @IGST
                                    WHERE ID = 1
                        "
          , ParamDict, CommandType.Text);
        }

        #endregion

        #region MASTERS VEHICLE

        public static DataTable GetMasterVehicleList()
        {
            var dt = DataAccess.GetTableFromQuery("SELECT * FROM MastersVehicle", null, CommandType.Text);
            return dt;
        }

        public static DataTable GetFilteredVehicleList(string ColumnName, string Value)
        {
            var dt = DataAccess.GetTableFromQuery("SELECT * FROM MastersVehicle where " + ColumnName + " like '%" + Value + "%'", null, CommandType.Text);
            return dt;
        }

        #endregion

        #region MASTERS TRANSPORT MODE

        public static DataTable GetMasterTransportModeList()
        {
            var dt = DataAccess.GetTableFromQuery("SELECT * FROM MastersTransportMode", null, CommandType.Text);
            return dt;
        }

        public static bool IfTransportModeAlreadyExist(string Mode)
        {
            bool Exist = false;
            Dictionary<string, object> ParamDict = new Dictionary<string, object>();
            ParamDict.Add("@Mode", Mode);
            var dt = DataAccess.GetTableFromQuery("SELECT * FROM MastersTransportMode where Mode = @Mode", ParamDict, CommandType.Text);

            if (dt.Rows.Count > 0)
                Exist = true;
            return Exist;
        }

        public static void AddNewMode(string Mode)
        {
            Dictionary<string, object> ParamDict = new Dictionary<string, object>();
            ParamDict.Add("@Mode", Mode);
            DataAccess.ExecuteNonQuery("INSERT INTO MastersTransportMode (Mode)VALUES (@Mode)", ParamDict, CommandType.Text);
        }

        public static void DeleteMode(string id)
        {
            Dictionary<string, object> ParamDict = new Dictionary<string, object>();
            ParamDict.Add("@ID", id);
            DataAccess.ExecuteNonQuery("DELETE from MastersTransportMode where Id = @ID", ParamDict, CommandType.Text);
        }

        #endregion


    }
}
