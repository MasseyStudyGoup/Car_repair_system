using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using TcarSystem.DAL;
using TcarSystem.Model;
//using System.Data.SQLite;
using System.Data;
//
namespace TcarSystem.BLL
{
    public class UserInforBLL
    {
        UserInforDAL dal = new UserInforDAL();
        private static UserInfor _user = null;

        public bool IsLoginByLoginName(string loginName, string Userpwd, out string msg)
        {
            bool flag = false;
            _user = dal.IsLoginByLoginName(loginName);//get name object

            if (_user != null)
            {
                if (Userpwd == _user.User_password)
                {
                    flag = true;
                    msg = "Welcome" +  " " + _user.UserName + "!";
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
        public string checkUtype(string loginName)
        {
            UserInfor user = dal.IsLoginByLoginName(loginName);
            string gettype = user.Identity;

            return gettype;
        }
        public static UserInfor CurrentUser
        {
            get => _user;
        }
    }
}
