using System;
using System.Collections.Generic;
using System.Text;
using TcarSystem.Model;
using System.Data;

namespace TcarSystem.DAL
{
    public class sys_outletService
    {
        /// <summary>
        /// Get outlet talbe data and change it to object
        /// </summary>
        /// <param name="outletsql">pass the sql query in fucntion</param>
        /// <returns></returns>
        public static IList<Outlet> GetOutlets(string outletsql)
        {
            IList<Outlet> outlets = new List<Outlet>();

            DataTable dt = SqliteHelper.ExecuteTable(outletsql);
            if (dt != null)
            {
                for (int i = 0 ; i < dt.Rows.Count; i++)
                {
                    Outlet outlet = new Outlet();
                    outlet.Id = Convert.ToInt32(dt.Rows[i]["otID"]);
                    outlet.Name = dt.Rows[i]["otName"].ToString();
                    outlet.Address = dt.Rows[i]["otAddress"].ToString();
                    outlets.Add(outlet);
                }
            }

            return outlets;
        }

        public static Outlet GetOutletbyotID(int id)
        {
            string sql = string.Format("select * from {0} where otID='{1}'", "outlets", id.ToString());
            try
            {
                return GetOutlets(sql)[0];
            }
            catch
            {
                return null;
            }
            
        }

        public static IList<Outlet> GetAlloutlet(int id)
        {
            string sql = "select * from outlets where otID =" + id;

            return GetOutlets(sql);
        }

        public static IList<Outlet> GetOutlets()
        {
            string sql = "";
            sql = string.Format("select * from {0} ", "outlets");

            return GetOutlets(sql);
        }
    }
}
