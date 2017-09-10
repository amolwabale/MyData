using Accounting.Dl;
using Accounting.Dl.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Accounting.Bl
{
    public class VehicleBl
    {
        public static void SaveVehicle(VehicleInfo objVehicle)
        {
            Dictionary<string, object> ParamDict = new Dictionary<string, object>();
            ParamDict.Add("@VehicleNum", objVehicle.VehicleNum);
            ParamDict.Add("@VehicleBrand", objVehicle.VehicleBrand);
            ParamDict.Add("@DriverName", objVehicle.DriverName);
            ParamDict.Add("@ContactNum", objVehicle.ContactNum);

            DataAccess.ExecuteNonQuery(@"
                        INSERT INTO MastersVehicle (
                                VehicleNum,
                                VehicleBrand,
                                DriverName,
                                ContactNum)
                                    VALUES (
                                        @VehicleNum,
                                        @VehicleBrand,
                                        @DriverName,
                                        @ContactNum)
                        "
                , ParamDict, CommandType.Text);
        }

        public static void UpdateVehicle(VehicleInfo objVehicle)
        {
            Dictionary<string, object> ParamDict = new Dictionary<string, object>();
            ParamDict.Add("@VehicleNum", objVehicle.VehicleNum);
            ParamDict.Add("@VehicleBrand", objVehicle.VehicleBrand);
            ParamDict.Add("@DriverName", objVehicle.DriverName);
            ParamDict.Add("@ContactNum", objVehicle.ContactNum);
            ParamDict.Add("@ID", objVehicle.ID);

            DataAccess.ExecuteNonQuery(@"
                        UPDATE MastersVehicle SET
                                VehicleNum = @VehicleNum,
                                VehicleBrand = @VehicleBrand,
                                DriverName = @DriverName,
                                ContactNum = @ContactNum
                                    WHERE ID = @ID
                        "
                , ParamDict, CommandType.Text);
        }

        public static bool IsVehicleAlreadyPresent(string VehicleNum)
        {
            var Present = false;
            var dt = DataAccess.GetTableFromQuery("SELECT * FROM MastersVehicle where VehicleNum = '" + VehicleNum + "'", null, CommandType.Text);
            if (dt.Rows.Count > 0)
                Present = true;
            return Present;
        }

        public static VehicleInfo GetVehiclePerId(string Id)
        {
            var objVehicleInfo = new VehicleInfo();
            Dictionary<string, object> ParamDict = new Dictionary<string, object>();
            ParamDict.Add("@Id", Id);
            var dt = DataAccess.GetTableFromQuery("SELECT * FROM MastersVehicle where ID = @Id", ParamDict, CommandType.Text);
            if (dt.Rows.Count > 0)
            {
                objVehicleInfo.ID = dt.Rows[0]["ID"].ToString();
                objVehicleInfo.VehicleNum = dt.Rows[0]["VehicleNum"].ToString();
                objVehicleInfo.VehicleBrand = dt.Rows[0]["VehicleBrand"].ToString();
                objVehicleInfo.DriverName = dt.Rows[0]["DriverName"].ToString();
                objVehicleInfo.ContactNum = dt.Rows[0]["ContactNum"].ToString();
            }
            return objVehicleInfo;
        }

        public static void DeleteVehicle(string Id)
        {
            DataAccess.ExecuteNonQuery("Delete FROM MastersVehicle where ID = " + Id, null, CommandType.Text);
        }
    }
}
