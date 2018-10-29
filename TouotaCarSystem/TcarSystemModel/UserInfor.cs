using System;
using System.Collections.Generic;
using System.Text;

namespace TcarSystem.Model
{
    public class UserInfor
    {
        private int _userId;
        private string _userName;
        private string _carNo;
        private string _pwd;
        private string _identity;

        public int UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }
        public string User_password
        {
            get { return _pwd; }
            set { _pwd = value; }
        }
        public string CarNo { get => _carNo; set => _carNo = value; }
        public string UserName { get => _userName; set => _userName = value; }
        public string Identity { get => _identity; set => _identity = value; }
    }
}
