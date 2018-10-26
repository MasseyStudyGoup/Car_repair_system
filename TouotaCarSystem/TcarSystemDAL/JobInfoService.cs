using System;
using System.Collections.Generic;
using System.Text;
using TcarSystem.Model;
using System.Data;



namespace TcarSystem.DAL
{
    public class JobInfoService
    {
        private static IList<JobInfo> GetJobsBySQL(string strsql)
        {
            IList<JobInfo> jobs = new List<JobInfo>();
            DataTable dt = SqliteHelper.ExecuteTable(strsql);
            if (dt != null)
            {
                for(int i=0; i<dt.Rows.Count; i++)
                {
                    JobInfo job = new JobInfo();
                    job.id = dt.Rows[i]["id"].ToString();
                    job.carNo = dt.Rows[i]["carNo"].ToString();
                    job.customer = dt.Rows[i]["customer"].ToString();
                    job.jobDescription = dt.Rows[i]["jobDescription"].ToString();
                    job.createdate = new DateTime (long.Parse(dt.Rows[i]["createdate"].ToString()));
                    job.jobStatus = (JobStatus) int.Parse(dt.Rows[i]["jobStatus"].ToString());
                    job.priority = (Priority)int.Parse(dt.Rows[i]["priority"].ToString());
                    job.resolve = (ResolveStatus)int.Parse(dt.Rows[i]["resovle"].ToString());
                    job.desk = null;
                    job.manager = null;
                    job.worker = null;
                    job.closedate = new DateTime(long.Parse(dt.Rows[i]["dateClose"].ToString()));
                    job.comment = dt.Rows[i]["comment"].ToString();


                }
            }

            return jobs;
             
        }
        public static IList<JobInfo> GetAllJobInfos()
        {
            // TODO
            return null;
        }

        public static JobInfoService GetJobById(int id)
        {
            //TODO
            return null;
        }

        public static int AddJob(JobInfo job)
        {
            //
            return 0;
        }

        public static int ModifyJob(JobInfo job)
        {
            //
            return 0;
        }

        public static int DelJob(int id)
        {
            //todo
            return 0;
        }
    }
}
