using System;
using System.Collections.Generic;
using System.Text;
using TcarSystem.Model;
using System.Data;
using System.IO;
using System.Linq;

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
                    try
                    {
                        job.createdate = DateTime.Parse(dt.Rows[i]["createdate"].ToString());
                    }
                    catch
                    {
                        job.createdate = DateTime.Now;

                    }

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

                    try
                    {
                        job.closedate = DateTime.Parse(dt.Rows[i]["closedate"].ToString());
                    }
                    catch
                    {
                        job.closedate = DateTime.Now;
                    }

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
            const string DATE_FORMAT = "yyyy-MM-dd HH:mm:ss";
            StringBuilder sb = new StringBuilder();
            sb.Append("'").Append((job.closedate == null) ? "" : job.closedate.ToString(DATE_FORMAT)).Append("',");
            sb.Append("'").Append(job.createdate.ToString(DATE_FORMAT)).Append("',");
            sb.Append("'").Append(job.carNo).Append("',");
            sb.Append("'").Append((job.desk == null)?"":""+job.desk.UserId).Append("',");
            sb.Append("'").Append((job.manager == null)?"":""+job.manager.UserId).Append("',");
            sb.Append("'").Append((job.worker == null)?"":""+job.worker.UserId).Append("',");
            sb.Append("'").Append((job.jobDescription == null) ? "" : job.jobDescription).Append("',");
            sb.Append("'").Append((int)job.resolve).Append("',");
            sb.Append("'").Append((int)job.priority).Append("',");
            sb.Append("'").Append((job.comment == null) ? "" : job.comment).Append("',");
            sb.Append("'").Append((job.desk == null)?"":""+job.desk.outlet).Append("',");
            sb.Append("'").Append((job.customer == null)?"":""+job.customer.UserId).Append("',");
            sb.Append("'").Append((int)job.jobStatus).Append("',");
            sb.Append("'").Append((job.opendate == null) ? "" : job.assigndate.ToString(DATE_FORMAT)).Append("',");
            sb.Append("'").Append((job.assigndate== null)?"":job.assigndate.ToString(DATE_FORMAT)).Append("',");
            sb.Append("'").Append((job.jobType == null) ? "" : job.jobType).Append("',");
            sb.Append("'").Append((job.jobHistory == null) ? "" : job.jobHistory).Append("'");
            //JobStatus foo = (JobStatus)Enum.ToObject(typeof(JobStatus) , yourInt);


            string strsql = string.Format("INSERT INTO jobs ({0}) VALUES ({1})", string.Join(",",JobInfo.COLUMNS_NO_ID), sb.ToString()); 
                
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
           
            return SqliteHelper.ExecuteNoneQuery(strsql);
           
        }


        /// <summary>
        /// confirm a job
        /// </summary>
        /// <param name="strsql">sql sentence</param>
        /// <returns>0 or 1</returns>
        public static int confirmById(JobInfo job)
        {

            string strsql = string.Format("UPDATE `jobs` SET `desk`=0,`manager`=0 WHERE id = 2", job.desk, job.manager);
           
           
            return SqliteHelper.ExecuteNoneQuery(strsql);
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
