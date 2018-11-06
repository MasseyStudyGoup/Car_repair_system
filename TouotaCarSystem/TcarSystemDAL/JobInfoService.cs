using System;
using System.Collections.Generic;
using System.Text;
using TcarSystem.Model;
using System.Data;

//

namespace TcarSystem.DAL
{
    public class JobInfoService
    {
        public static IList<JobInfo> GetJobsBySQL(string strsql)
        {
            IList<JobInfo> jobs = new List<JobInfo>();
            DataTable dt = SqliteHelper.ExecuteTable(strsql);
            if (dt != null)
            {
                for(int i=0; i<dt.Rows.Count; i++)
                {

                    //to do: some fiels have been seperated from jobs

                    JobInfo job = new JobInfo();
                    job.id = dt.Rows[i]["id"].ToString();
                    job.carNo = dt.Rows[i]["carNo"].ToString();

                    string customerId = dt.Rows[i]["customer"].ToString();
                    if (customerId != null && customerId.Length > 0)
                        job.customer = Sys_roleService.GetUserByiId(int.Parse(customerId));
                    job.jobDescription = dt.Rows[i]["jobDescription"].ToString();
                    job.createdate = new DateTime (long.Parse(dt.Rows[i]["createdate"].ToString()));
                    job.jobStatus = (JobStatus)int.Parse(dt.Rows[i]["jobStatus"].ToString());
                    job.priority = (Priority)int.Parse(dt.Rows[i]["priority"].ToString());

                    string resolve = dt.Rows[i]["resolve"].ToString();
                    if (resolve != null && resolve.Length > 0)
                        job.resolve = (ResolveStatus)int.Parse(resolve);
                    //outer key
                    string deskId = dt.Rows[i]["desk"].ToString();
                    if (deskId != null && deskId.Length > 0)
                        job.desk = Sys_roleService.GetUserByiId(int.Parse(deskId));

                    string managerId = dt.Rows[i]["manager"].ToString();
                    if (managerId != null && managerId.Length > 0)
                        job.manager = Sys_roleService.GetUserByiId(int.Parse(managerId));

                    string workerId = dt.Rows[i]["worker"].ToString();
                    if (workerId != null && workerId.Length > 0)
                        job.worker = Sys_roleService.GetUserByiId(int.Parse(workerId));
                    //add outlet key
                    string outletID = dt.Rows[i]["outlet"].ToString();
                    if (outletID != null && outletID.Length > 0)
                        job.outlet = sys_outletService.GetOutletbyotID(int.Parse(outletID));

                    job.closedate = new DateTime(long.Parse(dt.Rows[i]["closedate"].ToString()));
                    job.comment = dt.Rows[i]["comment"].ToString();
                    jobs.Add(job);

                }
            }

            return jobs;
             
        }


        /// <summary>
        /// get all jobs
        /// </summary>
        /// <param name="strsql">sql sentence</param>
        /// <returns>a list of jobs</returns>
        public static IList<JobInfo> GetAllJobInfos(string outletId)
        {

            string strsql = string.Format("select * from jobs where outlet ='{0}'", outletId);

            return GetJobsBySQL(strsql);
        }


        public static IList<JobInfo> GetAllJobInfoByUser(int userId)
        {
            string strsql = string.Format("select * from jobs where userId ={0}", userId);
            return null;
        }

        /// <summary>
        /// get a particular jobs
        /// </summary>
        /// <param name="strsql">sql sentence</param>
        /// <returns>a job</returns>
        public static JobInfo GetJobById(int id)
        {
           
            string strsql = "select * from jobs where id=" + id.ToString();
            try
            {
                return GetJobsBySQL(strsql)[0];
            }
            catch
            {
                return null;
            }
            
        }

        /// <summary>
        /// add a job
        /// </summary>
        /// <param name="strsql">sql sentence</param>
        /// <returns>0 or 1</returns>
        public static int AddJob(JobInfo job)
        {
           
            string strsql = string.Format("INSERT INTO `jobs`(`createdate`,`carNo`,`desk`,`manager`,`worker`,`jobDescription`,`priority`,`outlet`,`customer`) VALUES (0,'','',NULL,NULL,NULL,'',0,NULL,NULL)", job.createdate,job.assigndate, job.carNo,job.desk.UserId, job.manager.UserId, job.worker.UserId,job.jobDescription,job.priority,job.outlet,job.customer);
            return SqliteHelper.ExecuteNoneQuery(strsql);
            
        }

        /// <summary>
        /// update a job
        /// </summary>
        /// <param name="strsql">sql sentence</param>
        /// <returns>0 or 1</returns>
        public static int ModifyJob(JobInfo job)
        {
            
            string strsql = string.Format("UPDATE `jobs` SET `createdate`=0,`carNo`='0',`desk`=0,`manager`=0,`worker`=0,`jobDescription`='0',`priority`=0,`outlet`='0',`customer`='0', WHERE id = 2",  job.createdate,  job.carNo, job.desk.UserId, job.manager.UserId, job.worker.UserId, job.jobDescription, job.priority, job.outlet, job.customer);

            return SqliteHelper.ExecuteNoneQuery(strsql);
        }

        /// <summary>
        /// delete a job
        /// </summary>
        /// <param name="strsql">sql sentence</param>
        /// <returns>0 or 1</returns>
        public static int DelJob(int id)
        {
          
            string strsql = "delete from jobs where id=" + id.ToString();
            string strsql1 = "delete from job_history where jobid=" + id.ToString();
            SqliteHelper.ExecuteNoneQuery(strsql);
            return SqliteHelper.ExecuteNoneQuery(strsql1);
        }

        /// <summary>
        /// close a job by Desk
        /// </summary>
        /// <param name="strsql">sql sentence</param>
        /// <returns>0 or 1</returns>
        public static int closeByDesk(JobInfo job)
        {

            string strsql = string.Format("UPDATE `jobs` SET `desk`=0 WHERE id = 2",  job.desk.UserId);
            string strsql1 = string.Format("INSERT INTO `job_history`(`jobid`,`jobStatus`,`assigndate`,`closedate`,`opendate`,`resolve`,`comment`) VALUES (0,0,0,0,0,0,'')", job.id, job.jobStatus, job.assigndate, job.closedate, job.opendate, job.resolve, job.comment);

            SqliteHelper.ExecuteNoneQuery(strsql);
            return SqliteHelper.ExecuteNoneQuery(strsql1);
        }


        /// <summary>
        /// confirm a job
        /// </summary>
        /// <param name="strsql">sql sentence</param>
        /// <returns>0 or 1</returns>
        public static int confirmById(JobInfo job)
        {

            string strsql = string.Format("UPDATE `jobs` SET `desk`=0,`manager`=0 WHERE id = 2", job.desk, job.manager);
            string strsql1 = string.Format("INSERT INTO `job_history`(`jobid`,`jobStatus`,`assigndate`,`closedate`,`opendate`,`resolve`,`comment`) VALUES (0,0,0,0,0,0,'')", job.id, job.jobStatus, job.assigndate, job.closedate, job.opendate, job.resolve, job.comment);

            SqliteHelper.ExecuteNoneQuery(strsql);
            return SqliteHelper.ExecuteNoneQuery(strsql1);
        }

        /// <summary>
        /// set a job's priority
        /// </summary>
        /// <param name="strsql">sql sentence</param>
        /// <returns>0 or 1</returns>
        public static int setPriority(JobInfo job)
        {

            string strsql = string.Format("UPDATE `jobs` SET `priority`=0, WHERE id = 2",  job.priority);

            return SqliteHelper.ExecuteNoneQuery(strsql);
        }

        /// <summary>
        /// assign a job
        /// </summary>
        /// <param name="strsql">sql sentence</param>
        /// <returns>0 or 1</returns>
        public static int assign(JobInfo job)
        {

            string strsql = string.Format("UPDATE `jobs` SET `worker`=0 WHERE id = 2",  job.worker);
            string strsql1 = string.Format("INSERT INTO `job_history`(`jobid`,`jobStatus`,`assigndate`,`closedate`,`opendate`,`resolve`,`comment`) VALUES (0,0,0,0,0,0,'')", job.id, job.jobStatus, job.assigndate, job.closedate, job.opendate, job.resolve, job.comment);
            SqliteHelper.ExecuteNoneQuery(strsql);
            return SqliteHelper.ExecuteNoneQuery(strsql1);
        }


        /// <summary>
        /// close a job by worker
        /// </summary>
        /// <param name="strsql">sql sentence</param>
        /// <returns>0 or 1</returns>
        public static int closeByWorker(JobInfo job)
        {

            string strsql = string.Format("UPDATE `jobs` SET `worker`=0 WHERE id = 2",  job.worker);
            string strsql1 = string.Format("INSERT INTO `job_history`(`jobid`,`jobStatus`,`assigndate`,`closedate`,`opendate`,`resolve`,`comment`) VALUES (0,0,0,0,0,0,'')", job.id, job.jobStatus, job.assigndate, job.closedate, job.opendate, job.resolve, job.comment);
            SqliteHelper.ExecuteNoneQuery(strsql);
            return SqliteHelper.ExecuteNoneQuery(strsql1);
        }

    }
}
