using System;
using System.Collections.Generic;
using System.Text;
using TcarSystem.Model;
using System.Data;
using System.Data.SQLite;

namespace TcarSystem.DAL
{
    public class UserReportDAL
    {
        public List<ReportInfo> GetUserReports(int userid)
        {
            string sql = "SELECT * FROM jobs LEFT JOIN user ON jobs.customer = user.userId WHERE userId = @userId";
            DataTable dt = SqliteHelper.ExecuteTable(sql, new SQLiteParameter("@userId", userid));
            List<ReportInfo> list = new List<ReportInfo>();

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    ReportInfo userepor = RowToReport(dr);
                    list.Add(userepor);
                }
            }

            return list;
        }

        private ReportInfo RowToReport(DataRow dr)
        {
            ReportInfo userport = new ReportInfo();

            userport.Carno = Convert.ToInt32(dr[""]);
            userport.Closedata = Convert.ToDateTime(dr[""]);
            userport.Createdate = Convert.ToDateTime(dr[""]);
            userport.Customer = dr[""].ToString();
            userport.Jobid = Convert.ToInt32(dr[""]);
            userport.Jobdescription = dr[""].ToString();
            userport.Outletname = dr[""].ToString();
            //userport.Jobstatus = dr[""].ToString();



            return userport;
        }
    }
}
