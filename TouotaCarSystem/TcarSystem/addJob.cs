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
    public partial class addJob : Form
    {
        private JobInfo m_job = new JobInfo();
        UserInfor user = UserInforBLL.CurrentUser;

        public addJob()
        {
            InitializeComponent();
            this.CancelButton = btn_cancel;
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        public addJob(JobInfo currentJob)
        {
            InitializeComponent();
            this.CancelButton = btn_cancel;
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            m_job = currentJob;
        }
        private void addJob_Load(object sender, EventArgs e)
        {
            if (m_job.id != null)
            {
                textBoxCarNo.Text = m_job.carNo;
                textBoxCName.Text = (m_job.customer == null) ? "" : m_job.customer.UserName;
                cbType.Text = m_job.jobType;
                jobDes.Text = m_job.jobDescription;

            }
            else
            {
                lbopen.Hide();
                cbOpen.Hide();
            }

        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {

            
            m_job.carNo = textBoxCarNo.Text;
            m_job.customer = UserInforBLL.GetUserByName(textBoxCName.Text);
            m_job.jobType = cbType.Text;
            m_job.jobDescription = jobDes.Text;
            m_job.priority = Priority.Normal;
            
            
            if (m_job.id == null)
                m_job.jobStatus = JobStatus.Open;
            else
                m_job.jobStatus = (JobStatus)Enum.Parse(typeof(JobStatus), cbOpen.Text);

            m_job.desk = user;
            m_job.createdate = DateTime.Now;

            if (m_job.jobStatus.CompareTo(JobStatus.Closed) == 1)
                m_job.resolve = ResolveStatus.Invalid;
            else
                m_job.resolve = ResolveStatus.Unresolved;

            if (m_job.jobStatus.CompareTo(JobStatus.Open) == 1)
                m_job.opendate = DateTime.Now;

            if (m_job.id == null)
                JobInfoManager.AddJob(m_job);
            else
                JobInfoManager.UpdateJob(m_job);

            DialogResult = System.Windows.Forms.DialogResult.OK;



        }

      
    }
}
