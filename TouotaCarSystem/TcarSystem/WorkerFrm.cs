using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TcarSystem.BLL;
using TcarSystem.Model;

namespace TcarSystem
{
    public partial class WorkerFrm : Form
    {
        private Dictionary<string, JobInfo> m_jobDict = new Dictionary<string, JobInfo>();

        public WorkerFrm()
        {
            InitializeComponent();
        }

        private void WorkerFrm_Load(object sender, EventArgs e)
        {
            WorkJobList.Rows.Clear();
            m_jobDict.Clear();

            UserInfor user = UserInforBLL.CurrentUser;
            labelWelcome.Text = "Welcome" + " " + user.UserName + "!";


            IList<JobInfo> jobs = JobInfoManager.GetAllJobInfos();

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



        private void btClose_Click(object sender, EventArgs e)
        {
            CloseJob();
        }

        private void WorkJobList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CloseJob();
        }

        private void CloseJob()
        {
            JobInfo job = m_jobDict[WorkJobList.SelectedRows[0].Cells[0].Value.ToString()];
            if (job != null)
            {
                closeJob jobForm = new closeJob(job);
                jobForm.ShowDialog();
                WorkerFrm_Load(null, null);

            }
        }

        private void btWsearch_Click(object sender, EventArgs e)
        {
            wSearch jobForm = new wSearch();
            jobForm.ShowDialog();
           

        }
    }
}
