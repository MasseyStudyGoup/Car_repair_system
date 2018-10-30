using System;
using System.Collections.Generic;
using System.Text;

namespace TcarSystem.Model
{
    public enum JobStatus { Unconfirmed, Open, Assigned, Closed }
    //Desk can confirm/update/close a job. if confirm, the job's status is changed to open
    //if close, the job's status is changed to close, resolve status needs to be changed.

}
