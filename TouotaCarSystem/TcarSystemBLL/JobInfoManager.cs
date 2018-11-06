using System;
using System.Collections.Generic;
using System.Text;
using TcarSystem.Model;
using TcarSystem.DAL;
//
namespace TcarSystem.BLL
{
    public class JobInfoManager
    {
        public static IList<JobInfo> GetAllJobInfos()
        {
            UserInfor user = UserInforBLL.CurrentUser;
            //Outlet outlets = new Outlet();
            string sql = "";
            if (user.Identity == "manager")
            {
                sql = string.Format("select * from jobs where outlet ='{0}'", user.outlet);
                //                return TcarSystem.DAL.JobInfoService.GetAllJobInfos(UserInforBLL.CurrentUser.outlet);
            }
            else if (user.Identity == "hpdesk")
            {
                sql = string.Format("select * from jobs where jobStatus = 0");
            }

            else if (user.Identity == "worker")
            {
                sql = string.Format("select * from jobs where worker = '{0}' and jobStatus = 1", user.UserId);
            }

            else
            {
                sql = string.Format("select * from jobs where customer = '{0}'", user.UserId);
            }
            return TcarSystem.DAL.JobInfoService.GetJobsBySQL(sql);

        }


        public static IList<JobInfo> GetAllJobByUid()
        {
            string sql = "";
            UserInfor user = UserInforBLL.CurrentUser;
            if (user.Identity == "worker")
            {
                sql = string.Format("select * from jobs where worker = '{0}'", user.UserId);
            }

            else if (user.Identity == "hpdesk")
            {
                sql = string.Format("select * from jobs where desk = '{0}'", user.UserId);
            }

            else if (user.Identity == "mananger")
            {
                sql = string.Format("select * from jobs where mananger = '{0}'", user.UserId);
            }


            return TcarSystem.DAL.JobInfoService.GetJobsBySQL(sql);
        }


        public static IList<JobInfo> SearchJobInfos(string sql)
        {
          
            return TcarSystem.DAL.JobInfoService.GetJobsBySQL(sql);
        }


        /// <summary>
        /// get outlet information by outlet id in sys_outletService
        /// </summary>
        /// <param name="id">outlet id</param>
        /// <returns></returns>
        public static List<Outlet> GetOutlets(int id)
        {
            return TcarSystem.DAL.sys_outletService.GetAlloutlet(id);
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
