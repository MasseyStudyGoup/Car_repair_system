using System;
using System.Collections.Generic;
using System.Text;

namespace TcarSystem.Model
{
   public class JobStatistic
    {
        private UserInfor _worker;
        private int _closed;
        private int _open;

        public UserInfor Worker { get => _worker; set => _worker = value; }
        public int ClosedJob { get => _closed; set => _closed = value; }
        public int Open { get => _open; set => _open = value; }
    }
}
