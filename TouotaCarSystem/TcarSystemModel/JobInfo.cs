using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace TcarSystem.Model
{
    public class JobInfo
    {
        private string _id;
        private DateTime _createdate;
        private DateTime _closedate;
        private DateTime _opendate;
        private DateTime _assingdate;
        private UserInfor _customer;
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
        private string _jobType;
        private string _jobHistory;
        public static string[] COLUMNS = { "id", "closedate", "createdate", "carNo", "desk", "manager", "worker", "jobDescription", "resolve", "priority", "comment", "outlet", "customer", "jobStatus", "opendate", "assigndate", "jobType", "jobHistory" };
        public static string[] COLUMNS_NO_ID = { "closedate", "createdate", "carNo", "desk", "manager", "worker", "jobDescription", "resolve", "priority", "comment", "outlet", "customer", "jobStatus", "opendate", "assigndate", "jobType", "jobHistory" };

        public JobInfo()
        {
            _closedate = DateTime.Now;
            _createdate = DateTime.Now;
            _assingdate = DateTime.Now;
        }

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

        public DateTime opendate
        {
            get { return _opendate; }
            set { _opendate = value; }
        }
        public DateTime assigndate
        {
            get { return _assingdate; }
            set { _assingdate = value; }
        }


        public UserInfor customer
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

        public DateTime closedate
        {
            get { return _closedate; }
            set { _closedate = value; }

        }
        public string jobType
        {
            get { return _jobType; }
            set { _jobType = value; }

        }
        public string jobHistory
        {
            get { return _jobHistory; }
            set { _jobHistory = value; }

        }
    }




}
