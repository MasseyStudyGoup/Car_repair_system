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
    public partial class wSearch : Form
    {
        private Dictionary<string, JobInfo> m_jobDict = new Dictionary<string, JobInfo>();
        public wSearch()
        {
            InitializeComponent();
        }

        private void wSearch_Load(object sender, EventArgs e)
        {

            string[] status = System.Enum.GetNames(typeof(JobStatus));
            cbStatus.Items.Add("All status");
            foreach (string s in status)
                cbStatus.Items.Add(s);
            cbStatus.SelectedIndex = 0;
            string[] resolve = System.Enum.GetNames(typeof(ResolveStatus));
            cbResolve.Items.Add("All");
            foreach (string r in resolve)
                cbResolve.Items.Add(r);
            cbResolve.SelectedIndex = 0;

            IList<JobInfo> jobs = JobInfoManager.GetAllJobByUid();

            RefreshJobList(jobs);
        }


        private void RefreshJobList(IList<JobInfo> jobs)
        {
            WorkJobList.Rows.Clear();
            m_jobDict.Clear();


            if (jobs != null)
            {
                foreach (JobInfo job in jobs)
                {
                    m_jobDict.Add("" + job.id, job);
                    WorkJobList.Rows.Add(new string[] {
                    job.id.ToString(),
                    job.carNo,
                    (job.customer==null)?"":job.customer.UserName,
                    job.priority.ToString(),
                    //(job.outlet==null)?"":job.outlet.Name,
                    job.jobType.ToString(),
                    job.jobStatus.ToString(),
                    job.jobDescription,
                    //job.desk.UserName,
                    
                    job.resolve.ToString(),
                    job.comment,
                    job.createdate.ToString("yyyy-MM-dd HH:mm:ss"),
                    job.assigndate.ToString("yyyy-MM-dd HH:mm:ss")

                });
                }
            }

        }
       
        private void btSearch_Click(object sender, EventArgs e)
        {
            
                int status = -1;
                try
                {
                    status = (int)((JobStatus)Enum.Parse(typeof(JobStatus), cbStatus.Text));
                }
                catch
                {
                    //do nothing
                }
                int resolve = -1;
                try
                {
                    resolve = (int)(ResolveStatus)Enum.Parse(typeof(ResolveStatus), cbResolve.Text);
                }
                catch
                {

                }
                IList<JobInfo> myJobs = JobInfoManager.GetMyJobsWorker(status, resolve);
                RefreshJobList(myJobs);
            
        }
    }
}
