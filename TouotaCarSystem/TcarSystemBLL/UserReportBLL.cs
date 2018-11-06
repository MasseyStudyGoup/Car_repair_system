using System;
using System.Collections.Generic;
using System.Text;
using TcarSystem.DAL;
using TcarSystem.Model;

namespace TcarSystem.BLL
{
    public class UserReportBLL
    {
        public static IList<JobInfo> GetAllJobInfos()
        {
            UserInfor user = UserInforBLL.CurrentUser;
            string sql = "";
            if (user.Identity == "user")
            {
                sql = string.Format("select * from jobs where customer = '{0}'", user.UserId);
            }
            return TcarSystem.DAL.JobInfoService.GetJobsBySQL(sql);
        }
    }
}
