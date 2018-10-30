using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using TcarSystem.Model;

namespace TcarSystem.DAL
{
    public class Sys_roleService
    {
        /// <summary>
        /// get all the users
        /// </summary>
        /// <param name="strsql"></param>
        /// <returns></returns>
        private static IList<UserInfor> GetUsersBySQL(string strsql)
        {
            IList<UserInfor> users = new List<UserInfor>();
            DataTable dt = SqliteHelper.ExecuteTable(strsql);
            if (dt != null)
            {
                for (int i=0; i <  dt.Rows.Count ; i++)
                {
                    UserInfor user = new UserInfor();
                    user.UserId = int.Parse(dt.Rows[i]["userId"].ToString());
                    user.UserName = dt.Rows[i]["user_name"].ToString();
                    users.Add(user);

                }
            }
            return users;
        }


        /// <summary>
        /// 
        ///get  a user
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        public static UserInfor GetUserByiId(int id)
        {
            string strsql = "select * from user where userid=" + id.ToString();
            try
            {
                return GetUsersBySQL(strsql)[0];
            }
            catch
            {
                return null;
            }
           
        }

        

         
    }
}
