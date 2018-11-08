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
    public partial class ManagerFrm : Form
    {
        private Dictionary<string, JobInfo> m_jobDict = new Dictionary<string, JobInfo>();
        public ManagerFrm()
        {
            InitializeComponent();
        }

        //Loading datagraid
        private void ManagerFrm_Load(object sender, EventArgs e)
        {
            ManagerJobList.Rows.Clear();//load clean 
            m_jobDict.Clear();

            UserInfor user = UserInforBLL.CurrentUser;
            labelWelcome.Text = "Welcome" + " " + user.UserName + "!";


            IList<JobInfo> jobs = JobInfoManager.GetAllJobInfos();

            if (jobs != null)
            {
                foreach (JobInfo job in jobs)
                {
                    m_jobDict.Add("" + job.id, job);

                    ManagerJobList.Rows.Add(new string[] {
                    job.id.ToString(),
                    job.carNo,
                    (job.customer==null)?"":job.customer.UserName,
                    (job.outlet==null)?"":job.outlet.Name,
                    job.jobType.ToString(),
                    //(job.jobType==null)?"":job.jobType,
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

        private void btnAssgin_Click(object sender, EventArgs e)
        {
            //ManagerAssginFrm assgin = new ManagerAssginFrm();
            //assgin.ShowDialog();
            //ManagerFrm_Load(null, null);
            Editinfor();

        }

        private void btn_Msearch_Click(object sender, EventArgs e)
        {
            ManagerSearchFrm search = new ManagerSearchFrm();
            search.ShowDialog();
        }

        public void Editinfor()
        {
            JobInfo job = m_jobDict[ManagerJobList.SelectedRows[0].Cells[0].Value.ToString()];
            if (job != null)
            {
                ManagerAssginFrm assginfrm = new ManagerAssginFrm(job);
                assginfrm.ShowDialog();
                ManagerFrm_Load(null, null);
            }
        }

        private void btn_Jobstatistic_Click(object sender, EventArgs e)

        {
            IList<JobStatistic> jobstatus = JobInfoManager.GetJobStatistics();

            JobStatisticFrm jobStatistic = new JobStatisticFrm(jobstatus);
            jobStatistic.ShowDialog();
        }

        private void ManagerJobList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 1)
            {
                SearchByCarNoFrm searchByCarNo = new SearchByCarNoFrm();
                searchByCarNo.ShowDialog();
            }


        }
        private void AddLinkColumn()
        {
            System.Windows.Forms.DataGridViewColumn
            DataGridViewLinkColumn = new DataGridViewLinkColumn();

        }

        private void btn_signOut_Click(object sender, EventArgs e)
        {

        }
    }

}
