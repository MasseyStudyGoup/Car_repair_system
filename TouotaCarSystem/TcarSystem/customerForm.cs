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
    public partial class customerForm : Form
    {
        private Dictionary<string, JobInfo> m_jobDict = new Dictionary<string, JobInfo>();
        public customerForm()
        {
            InitializeComponent();
        }

        private void customerForm_Load(object sender, EventArgs e)
        {
            cusJobList.Rows.Clear();
            m_jobDict.Clear();
            IList<JobInfo> jobs = JobInfoManager.GetAllJobInfos();

            if (jobs != null)
            {
                foreach (JobInfo job in jobs)
                {

                    m_jobDict.Add("" + job.id, job);
                    cusJobList.Rows.Add(new string[] {
                    job.id.ToString(),
                    job.carNo,
                   // (job.customer==null)?"":job.customer.UserName,
                    (job.outlet==null)?"":job.outlet.Name,
                    job.jobType.ToString(),
                    //job.priority.ToString(),
                    job.jobStatus.ToString(),
                    job.jobDescription,
                    //(job.desk==null)?"":job.desk.UserName,
                    job.resolve.ToString(),
                    //job.comment,
                    job.createdate.ToString("yyyy-MM-dd HH:mm:ss")

                });
                }
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            CustomerAdd jobForm = new CustomerAdd();
            jobForm.ShowDialog();
            customerForm_Load(null, null);
        }

        private void btnUpdataJob_Click(object sender, EventArgs e)
        {
            EditJob();
        }

        

        private void cusJobList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditJob();
        }

        private void EditJob()
        {
            JobInfo job = m_jobDict[cusJobList.SelectedRows[0].Cells[0].Value.ToString()];
            if (job != null)
            {
                CustomerAdd jobForm = new CustomerAdd(job);
                jobForm.ShowDialog();
                customerForm_Load(null, null);

            }
        }
    }
}
//