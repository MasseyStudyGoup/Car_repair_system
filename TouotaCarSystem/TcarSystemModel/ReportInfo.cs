using System;
using System.Collections.Generic;
using System.Text;

namespace TcarSystem.Model
{
    public class ReportInfo
    {
        private int _jobid;
        private int _jobstatus;
        private DateTime _createdate;
        private DateTime _closedata;
        private int _carno;
        private string _customer;
        private string _outletname;
        private string _jobdescription;

        public int Jobid { get => _jobid; set => _jobid = value; }
        public int Jobstatus { get => _jobstatus; set => _jobstatus = value; }
        public DateTime Createdate { get => _createdate; set => _createdate = value; }
        public string Customer { get => _customer; set => _customer = value; }
        public int Carno { get => _carno; set => _carno = value; }
        public string Outletname { get => _outletname; set => _outletname = value; }
        public string Jobdescription { get => _jobdescription; set => _jobdescription = value; }
        public DateTime Closedata { get => _closedata; set => _closedata = value; }
    }
}
