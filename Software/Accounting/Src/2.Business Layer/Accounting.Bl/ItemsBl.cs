using Accounting.Dl;
using Accounting.Dl.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Accounting.Bl
{
    public class ItemsBl
    {
        public static void SaveItem(ItemInfo objItemInfo)
        {
            Dictionary<string, object> ParamDict = new Dictionary<string, object>();
            ParamDict.Add("@Name", objItemInfo.Name);
            ParamDict.Add("@Description", objItemInfo.Description);
            ParamDict.Add("@PartNumber", objItemInfo.PartNumber);
            ParamDict.Add("@Unit", objItemInfo.Unit);
            ParamDict.Add("@Hsn", objItemInfo.Hsn);
            ParamDict.Add("@Rate", objItemInfo.Rate);
            ParamDict.Add("@Weight", objItemInfo.Weight);
            ParamDict.Add("@Remark", objItemInfo.Remark);
            ParamDict.Add("@SGST", objItemInfo.SGST);
            ParamDict.Add("@CGST", objItemInfo.CGST);
            ParamDict.Add("@IGST", objItemInfo.IGST);

            DataAccess.ExecuteNonQuery(@"
                        INSERT INTO MastersItem (
                                Name,
                                Description,
                                PartNumber,
                                Unit,
                                Hsn,
                                Rate,
                                Weight,
                                Remark,
                                SGST,
                                CGST,
                                IGST)
                                    VALUES (
                                        @Name,
                                        @Description,
                                        @PartNumber,
                                        @Unit,
                                        @Hsn,
                                        @Rate,
                                        @Weight,
                                        @Remark,
                                        @SGST,
                                        @CGST,
                                        @IGST)
                        "
                , ParamDict, CommandType.Text);
        }

        public static void UpdateItem(ItemInfo objItemInfo)
        {
            Dictionary<string, object> ParamDict = new Dictionary<string, object>();
            ParamDict.Add("@Name", objItemInfo.Name);
            ParamDict.Add("@Description", objItemInfo.Description);
            ParamDict.Add("@PartNumber", objItemInfo.PartNumber);
            ParamDict.Add("@Unit", objItemInfo.Unit);
            ParamDict.Add("@Hsn", objItemInfo.Hsn);
            ParamDict.Add("@Rate", objItemInfo.Rate);
            ParamDict.Add("@Weight", objItemInfo.Weight);
            ParamDict.Add("@Remark", objItemInfo.Remark);
            ParamDict.Add("@SGST", objItemInfo.SGST);
            ParamDict.Add("@CGST", objItemInfo.CGST);
            ParamDict.Add("@IGST", objItemInfo.IGST);
            ParamDict.Add("@ID", objItemInfo.ID);

            DataAccess.ExecuteNonQuery(@"
                        UPDATE MastersItem SET
                                Name = @Name,
                                Description = @Description,
                                PartNumber = @PartNumber,
                                Unit = @Unit,
                                Hsn = @Hsn,
                                Rate = @Rate,
                                Weight = @Weight,
                                Remark = @Remark,
                                SGST = @SGST,
                                CGST = @CGST,
                                IGST = @IGST
                                    WHERE ID = @ID
                        "
                , ParamDict, CommandType.Text);
        }

        public static bool IsItemAlreadyPresent(string Name)
        {
            var Present = false;
            var dt = DataAccess.GetTableFromQuery("SELECT * FROM MastersItem where Name = '" + Name +"'", null, CommandType.Text);
            if (dt.Rows.Count > 0)
                Present = true;
            return Present;
        }

        public static ItemInfo GetItemPerId(string Id)
        {
            var objItemInfo = new ItemInfo();
            Dictionary<string, object> ParamDict = new Dictionary<string, object>();
            ParamDict.Add("@Id", Id);
            var dt = DataAccess.GetTableFromQuery("SELECT * FROM MastersItem where ID = @Id", ParamDict, CommandType.Text);
            if (dt.Rows.Count > 0)
            {
                objItemInfo.ID = dt.Rows[0]["ID"].ToString();
                objItemInfo.Name = dt.Rows[0]["Name"].ToString();
                objItemInfo.Description = dt.Rows[0]["Description"].ToString();
                objItemInfo.PartNumber = dt.Rows[0]["PartNumber"].ToString();
                objItemInfo.Unit = dt.Rows[0]["Unit"].ToString();
                objItemInfo.Hsn = dt.Rows[0]["Hsn"].ToString();
                objItemInfo.Rate = dt.Rows[0]["Rate"].ToString();
                objItemInfo.Weight = dt.Rows[0]["Weight"].ToString();
                objItemInfo.Remark = dt.Rows[0]["Remark"].ToString();
                objItemInfo.SGST = dt.Rows[0]["SGST"].ToString();
                objItemInfo.CGST = dt.Rows[0]["CGST"].ToString();
                objItemInfo.IGST = dt.Rows[0]["IGST"].ToString();
            }
            return objItemInfo;
        }

        public static void DeleteItem(string Id)
        {
            DataAccess.ExecuteNonQuery("Delete FROM MastersItem where ID = " + Id, null, CommandType.Text);
        }
    }
}
