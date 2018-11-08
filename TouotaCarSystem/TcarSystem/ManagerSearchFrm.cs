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
    public partial class ManagerSearchFrm : Form
    {
        private Dictionary<string, JobInfo> m_jobDict = new Dictionary<string, JobInfo>();
        UserInfor user = UserInforBLL.CurrentUser;
        public ManagerSearchFrm()
        {
            InitializeComponent();
        }

        private void ManagerSearchFrm_Load(object sender, EventArgs e)
        {
            //Get job status
            cbJobStatus.DataSource = System.Enum.GetNames(typeof(JobStatus));
            cbJobStatus.SelectedText = "All Status";

            //Get resolve job list
            cb_resolve.DataSource = System.Enum.GetNames(typeof(ResolveStatus));
            cb_resolve.SelectedText = "All Resolve";
            
            //Get and set worker value
            IList<UserInfor> userlist = UserInforBLL.GetAllWorkers(user.outlet);
            foreach (UserInfor worker in userlist)
            {

                ItemData item = new ItemData(worker.UserName, worker);
                cbWoker.SelectedItem = item;
                cbWoker.SelectedIndex = worker.UserId;

            }

            //Load jobs table
            IList<JobInfo> jobs = JobInfoManager.GetAllJobByUid();
            RefreshJobList(jobs);
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            int status = -1;
            try
            {
                status = (int)((JobStatus)Enum.Parse(typeof(JobStatus), cbJobStatus.Text));
            }
            catch
            {
                //do nothing
            }
            int resolve = -1;
            try
            {
                resolve = (int)(ResolveStatus)Enum.Parse(typeof(ResolveStatus), cb_resolve.Text);
            }
            catch{}
            int workertype = -1;
            try
            {
                workertype = cbWoker.SelectedIndex;
            }
            catch { }

            IList<JobInfo> myJobs = JobInfoManager.GetMyJobsManager(status, resolve, workertype);
            RefreshJobList(myJobs);

        }

        private void RefreshJobList(IList<JobInfo> jobs)
        {
            MSearcjJobList.Rows.Clear();
            m_jobDict.Clear();


            if (jobs != null)
            {
                foreach (JobInfo job in jobs)
                {
                    m_jobDict.Add("" + job.id, job);
                    MSearcjJobList.Rows.Add(new string[] {

                    job.id.ToString(),
                    job.carNo,
                    (job.customer==null)?"":job.customer.UserName,
                    (job.outlet==null)?"":job.outlet.Name,
                    job.jobType.ToString(),
                    //(job.jobType==null)?"":job.jobType.ToString(),
                    job.priority.ToString(),
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

        private void btn_changeWoker_Click(object sender, EventArgs e)
        {
            ManagerAssginFrm assginfrm = new ManagerAssginFrm();
            assginfrm.ShowDialog();
        }
    }
}
