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
            IList<JobInfo> jobs = new List<JobInfo>;
            DataTable dt = SqliteHelper.ExecuteTable(strsql);
            if (dt != null)
            {
                for(int i=-; i<dt.Rows.Count; i++)
                {
                    JobInfo job = new JobInfo();
                    job.id = dt.Rows[i][]
                }
            }

            return jobs;
             
        }
        public static IList<JobInfo> GetAllJobInfos()
        {
            // TODO
        }

        public static JobInfoService GetJobById(int id)
        {
            //TODO
        }

        public static int AddJob(JobInfo job)
        {
            //
        }

        public static int ModifyJob(JobInfo job)
        {
            //
        }

        public static int DelJob(int id)
        {
            //todo
        }
    }
}
