using System;
using System.Collections.Generic;
using System.Text;
using TcarSystem.Model;
using TcarSystem.DAL;

namespace TcarSystem.BLL
{
    public class JobInfoManager
    {
        public static IList<JobInfo> GetAllJobInfos()
        {
            UserInfor user = UserInforBLL.CurrentUser;
            string sql = "";
            if (user.Identity == "mananger")
            {
                sql = string.Format("select * from jobs where outlet ='{0}'", user.outlet);
//                return TcarSystem.DAL.JobInfoService.GetAllJobInfos(UserInforBLL.CurrentUser.outlet);
            }
            else 
            {
                sql = string.Format("select * from jobs where userid ={0}", user.UserId);
            }
            return TcarSystem.DAL.JobInfoService.GetJobsBySQL(sql);

        }


        /// <summary>
        /// get a particular jobs
        /// </summary>
        /// <param name="strsql">sql sentence</param>
        /// <returns>a job</returns>
        public static JobInfo GetJobById(int id)
        {

            return TcarSystem.DAL.JobInfoService.GetJobById(id);

        }

        /// <summary>
        /// add a job
        /// </summary>
        /// <param name="strsql">sql sentence</param>
        /// <returns>0 or 1</returns>
        public static bool AddJob(JobInfo job)
        {

            return TcarSystem.DAL.JobInfoService.AddJob(job)>0;

        }

        /// <summary>
        /// update a job
        /// </summary>
        /// <param name="strsql">sql sentence</param>
        /// <returns>0 or 1</returns>
        public static bool ModifyJob(JobInfo job)
        {

            return TcarSystem.DAL.JobInfoService.ModifyJob(job)>0;
        }

        /// <summary>
        /// delete a job
        /// </summary>
        /// <param name="strsql">sql sentence</param>
        /// <returns>0 or 1</returns>
        public static bool DelJob(int id)
        {

            return TcarSystem.DAL.JobInfoService.DelJob(id)>0;
        }

        /// <summary>
        /// close a job by Desk
        /// </summary>
        /// <param name="strsql">sql sentence</param>
        /// <returns>0 or 1</returns>
        public static bool closeByDesk(JobInfo job)
        {

            return TcarSystem.DAL.JobInfoService.closeByDesk(job)>0;
        }


        /// <summary>
        /// confirm a job
        /// </summary>
        /// <param name="strsql">sql sentence</param>
        /// <returns>0 or 1</returns>
        public static bool confirmById(JobInfo job)
        {

            return TcarSystem.DAL.JobInfoService.confirmById(job) > 0;
        }

        /// <summary>
        /// set a job's priority
        /// </summary>
        /// <param name="strsql">sql sentence</param>
        /// <returns>0 or 1</returns>
        public static bool setPriority(JobInfo job)
        {

            return TcarSystem.DAL.JobInfoService.setPriority(job) > 0;
        }

        /// <summary>
        /// assign a job
        /// </summary>
        /// <param name="strsql">sql sentence</param>
        /// <returns>0 or 1</returns>
        public static bool assign(JobInfo job)
        {

            return TcarSystem.DAL.JobInfoService.assign(job)>0;
        }


        /// <summary>
        /// close a job by worker
        /// </summary>
        /// <param name="strsql">sql sentence</param>
        /// <returns>0 or 1</returns>
        public static bool closeByWorker(JobInfo job)
        {

            return TcarSystem.DAL.JobInfoService.closeByDesk(job)>0;
        }


    }
}
