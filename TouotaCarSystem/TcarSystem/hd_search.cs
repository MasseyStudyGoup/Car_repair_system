using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TcarSystem.Model;
using TcarSystem.BLL;

namespace TcarSystem
{
    public partial class hd_search : Form
    {
        private Dictionary<string, JobInfo> m_jobDict = new Dictionary<string, JobInfo>();
        public hd_search()
        {
            InitializeComponent();
        }

        private void hd_search_Load(object sender, EventArgs e)
        {
            cbStatus.DataSource = System.Enum.GetNames(typeof(JobStatus));
            cbResolve.DataSource = System.Enum.GetNames(typeof(ResolveStatus));


           // string sql = ""

            IList<JobInfo> jobs = JobInfoManager.GetAllJobByUid();

            RefreshJobList(jobs);
       
   
        }



        private void hdSearch_Click(object sender, EventArgs e)
        {

            JobStatus status = (JobStatus)Enum.Parse(typeof(JobStatus), cbStatus.Text);
            ResolveStatus resolve = (ResolveStatus)Enum.Parse(typeof(ResolveStatus), cbResolve.Text);
           
            IList<JobInfo> myJobs = JobInfoManager.GetMyJobshd((int)status, (int)resolve);
            RefreshJobList(myJobs);
        }



        private void RefreshJobList(IList<JobInfo> jobs)
        {
            dhSearcjJobList.Rows.Clear();
            m_jobDict.Clear();


            if (jobs != null)
            {
                foreach (JobInfo job in jobs)
                {
                    m_jobDict.Add("" + job.id, job);
                    dhSearcjJobList.Rows.Add(new string[] {

                    job.id.ToString(),
                    job.carNo,
                    (job.customer==null)?"":job.customer.UserName,
                    (job.outlet==null)?"":job.outlet.Name,
                    job.jobType.ToString(),
                    //(job.jobType==null)?"":job.jobType.ToString(),
                    //job.priority.ToString(),
                    job.jobStatus.ToString(),
                    job.jobDescription,
                    (job.desk==null)?"":job.desk.UserName,
                    job.resolve.ToString(),
                    job.comment,
                    job.createdate.ToString("yyyy-MM-dd HH:mm:ss")

                });
                }
            }

        }

    }
}
