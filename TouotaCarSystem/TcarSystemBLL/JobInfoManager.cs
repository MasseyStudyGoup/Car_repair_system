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
                sql = string.Format("select * from jobs where outlet ='{0}'", user.outlet.Id);
                //                return TcarSystem.DAL.JobInfoService.GetAllJobInfos(UserInforBLL.CurrentUser.outlet);
            }
            else if (user.Identity == "hpdesk")
            {
                sql = string.Format("select * from jobs where jobStatus = 0");
            }

            else if (user.Identity == "work")
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
            if (user.Identity == "work")
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

        public static IList<JobInfo> GetMyJobshd(int status, int resolve)
        {
            string sql = "";

            UserInfor user = UserInforBLL.CurrentUser;
            if (status >= 0 && resolve >= 0)
            {
                sql = string.Format("select * from jobs where desk = '{0}' and jobStatus = '{1}' and resolve = '{2}' ", user.UserId, status, resolve);
            }
            else if (status < 0 && resolve < 0)
            {
                sql = string.Format("select * from jobs where desk = '{0}'", user.UserId);
            }
            else
            {
                if (status == -1)
                    sql = string.Format("select * from jobs where desk = '{0}' and resolve = '{1}' ", user.UserId, resolve);
                else
                    sql = string.Format("select * from jobs where desk = '{0}' and jobStatus = '{1}' ", user.UserId, status);
            }
            return TcarSystem.DAL.JobInfoService.GetJobsBySQL(sql);
        }


        public static IList<JobInfo> GetMyJobsWorker(int status, int resolve)
        {
            string sql = "";

            UserInfor user = UserInforBLL.CurrentUser;
            if (status >= 0 && resolve >= 0)
            {
                sql = string.Format("select * from jobs where worker = '{0}' and jobStatus = '{1}' and resolve = '{2}' ", user.UserId, status, resolve);
            }
            else if (status < 0 && resolve < 0)
            {
                sql = string.Format("select * from jobs where worker = '{0}'", user.UserId);
            }
            else
            {
                if (status == -1)
                    sql = string.Format("select * from jobs where worker = '{0}' and resolve = '{1}' ", user.UserId, resolve);
                else
                    sql = string.Format("select * from jobs where worker = '{0}' and jobStatus = '{1}' ", user.UserId, status);
            }
            return TcarSystem.DAL.JobInfoService.GetJobsBySQL(sql);
        }

        public static IList<JobInfo> GetMyJobsManager(int status, int resolve, int workerid)
        {
            string sql = "";

            UserInfor user = UserInforBLL.CurrentUser;

            sql = string.Format("select * from jobs where manager = '{0}' and jobStatus = '{1}' and resolve = '{2}' and worker = '{3}'", user.UserId, status, resolve ,workerid);

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
        public static IList<Outlet> GetOutlets(int id)
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
        public static bool UpdateJob(JobInfo job)
        {

            return TcarSystem.DAL.JobInfoService.ModifyJob(job)>0;
        }

       
        

        /// <summary>
        /// assign a job---used by Manager
        /// </summary>
        /// <param name="strsql">sql sentence</param>
        /// <returns>0 or 1</returns>
        public static bool assign(JobInfo job)
        {

            return TcarSystem.DAL.JobInfoService.assign(job)>0;
        }

        /// <summary>
        /// close a job---used by Worker
        /// </summary>
        /// <param name="strsql">sql sentence</param>
        /// <returns>0 or 1</returns>
        public static bool close(JobInfo job)
        {

            return TcarSystem.DAL.JobInfoService.closeByWorker(job) > 0;
        }


        public static IList<Outlet> getAllOutletsBycus()
        {

            return TcarSystem.DAL.sys_outletService.GetOutlets();
        }


        /// <summary>
        /// Get job statistic from JobInfoManager DAL
        /// </summary>
        /// <returns></returns>
        public static IList<JobStatistic> GetJobStatistics()
        {
            return TcarSystem.DAL.JobInfoService.GetJobStatistic();
        }

    }
}
