using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using TcarSystem.DAL;
using TcarSystem.Model;

namespace TcarSystem.BLL
{
    public class UserInforBLL
    {
        UserInforDAL dal = new UserInforDAL();
        
        public bool IsLoginByLoginName(string loginName, string Userpwd, out string msg)
        {
            bool flag = false;
            UserInfor user = dal.IsLoginByLoginName(loginName);//get name object

            if (user!=null)
            {
                if (Userpwd == user.User_password)
                {
                    flag = true;
                    msg = "Welcome" +  " " +user.UserName + "!";
                }
                else
                {
                    msg = "Password is worrg, please check it again!";
                }
            }
            else
            {
                msg = "Sorry, the account does not exist!";
            }
            return flag;
        }
    }
}
