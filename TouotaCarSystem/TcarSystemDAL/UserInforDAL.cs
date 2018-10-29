using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using TcarSystem.Model;
using System.Data.SQLite;
using System.Data;


namespace TcarSystem.DAL
{
    public class UserInforDAL
    {
        /// <summary>
        /// This function is search in database by user acount number 
        /// check user name and password is correct, retrun is object
        /// </summary>
        /// <param name="loginName">Lgoin account</param>
        /// <returns>UserInfo object</returns>
        //fuction for check login success
        public UserInfor IsLoginByLoginName(string loginName)
        {
            string sql = "select * from user where user_name=@user_name";
            //string sql = "select * from user";
            //return a data table
            DataTable dt = SqliteHelper.ExecuteTable(sql, new SQLiteParameter("@user_name", loginName));
            UserInfor user = null;

            if (dt.Rows.Count>0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    user = RowToUserInfo(dr);
                }
            }
            return user;
        }

        //change data to object
        private UserInfor RowToUserInfo(DataRow dr)
        {
            UserInfor user = new UserInfor();
            user.UserId = Convert.ToInt32(dr["userId"]);
            user.UserName = dr["user_name"].ToString();
            user.CarNo = dr["carNo"].ToString();
            user.User_password = dr["user_password"].ToString();
            user.Identity = dr["identity"].ToString();

            return user;
            //throw new NotImplementedException();
        }
    }
}
