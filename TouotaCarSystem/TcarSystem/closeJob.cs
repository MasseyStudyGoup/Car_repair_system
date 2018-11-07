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
    public partial class closeJob : Form
    {
        private JobInfo m_job;
        private static UserInfor user = UserInforBLL.CurrentUser;

        public closeJob()
        {
            InitializeComponent();
        }

        public closeJob(JobInfo currentJob)
        {
            m_job = currentJob;
            InitializeComponent();
           // this.CancelButton = btn_cancel;
            //this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;

        }

        private void closeJob_Load(object sender, EventArgs e)
        {
            if (m_job.id != null)
            {
                txID.Text = m_job.id.ToString();
                txCarNo.Text = m_job.carNo;
                txCName.Text = (m_job.customer == null) ? "" : m_job.customer.UserName;
                cbType.SelectedText = m_job.jobType.ToString();
                txDescrip.Text = (m_job.jobDescription == null) ? "" : m_job.jobDescription;

            }

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            m_job.jobDescription = txDescrip.Text;
            m_job.closedate = DateTime.Now;
            m_job.jobStatus = JobStatus.Closed;
            m_job.resolve = ResolveStatus.Solved;
            m_job.comment = txComment.Text;
            

            JobInfoManager.close(m_job);
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void txComment_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

