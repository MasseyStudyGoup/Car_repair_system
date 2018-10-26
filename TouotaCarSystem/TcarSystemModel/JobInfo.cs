using System;
using System.Collections.Generic;
using System.Text;

namespace TcarSystem.Model
{
    public class JobInfo
    {
        private string _id;
        private DateTime _createdate;
        private string _customer;
        private string _carNo;
        private UserInfor _desk;
        private UserInfor _manager;
        private UserInfor _worker;
        private string _jobDescription;
        private ResolveStatus _resolve;
        private Priority _priority;
        private JobStatus _jobStatus;

        private string _comment;
        private Outlet _outlet;

        public string id
        {
            get { return _id; }
            set { _id = value; }
        }

        public DateTime createdate
        {
            get { return _createdate; }
            set { _createdate = value; }
        }

        public string customer
        {
            get { return _customer; }
            set { _customer = value; }

        }

        public string carNo
        {
            get { return _carNo; }
            set { _carNo = value; }

        }

        public UserInfor desk
        {
            get { return _desk; }
            set { _desk = value; } 

        }

        public UserInfor manager
        {
            get { return _manager; }
            set { _manager = value; }

        }

        public UserInfor worker
        {
            get { return _worker; }
            set { _worker = value; }

        }

        public string jobDescription
        {
            get { return _jobDescription; }
            set { _jobDescription = value; }

        }

        public JobStatus jobStatus
        {
            get { return _jobStatus; }
            set { _jobStatus = value; }

        }

        public ResolveStatus resolve
        {
            get { return _resolve; }
            set { _resolve = value; }

        }

        public Priority priority
        {
            get { return _priority; }
            set { _priority = value; }

        }

        public Outlet outlet
        {
            get { return _outlet; }
            set { _outlet = value; }

        }

        public string comment
        {
            get { return _comment; }
            set { _comment = value; }

        }



    }




}
